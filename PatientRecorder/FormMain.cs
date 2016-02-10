using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoBuf;
using System.Diagnostics;

namespace PatientRecorder
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		List<Record> records;
		bool recordsModified = false;

		private void MainForm_Load(object sender, EventArgs e)
		{
			Application.ThreadException += Application_ThreadException;

			dateTimePickerMax.Value = DateTime.Today;
			dateTimePickerMin.Value = DateTime.Today.AddDays(-30);

			if (File.Exists(Program.recordPath))
			{
				using (FileStream fs = new FileStream(Program.recordPath, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					records = Serializer.Deserialize<List<Record>>(fs);
				}
			}
			else
			{
				records = new List<Record>(8);
			}
			checkBoxInstantRefresh.Checked = true;
			toolStripStatusLabelRecordPath.Text = Program.recordPath2;
		}

		void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			MessageBox.Show(e.Exception.ToString(), "Beklenmedik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (recordsModified)
			{
				SaveRecords();
			}
		}

		internal void NewInstance(System.Collections.ObjectModel.ReadOnlyCollection<string> readOnlyCollection)
		{
			
		}

		private void FormMain_Shown(object sender, EventArgs e)
		{
			ActiveControl = textBoxName;
			textBoxName.Focus();
			SearchAsync();
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			SearchAsync();
		}

		bool _searching = false;
		bool Searching
		{
			get
			{
				return _searching;
			}
			
			set
			{
				if (_searching != value)
				{
					toolStripStatusLabelSearchStatus.Text = (_searching = value) ? "Aranıyor..." : "Tamamlandı";
					if (checkBoxInstantRefresh.Checked)
						buttonSearch.Text = value ? "Durdur" : "Ara";
					else
						buttonSearch.Text = value ? "Aranıyor..." : "Ara";
				}
			}
		}

		public static bool ListItemsContains(IEnumerable<string> haystack, string needle)
		{
			if (haystack == null || string.IsNullOrWhiteSpace(needle))
				return false;

			foreach (string item in haystack)
			{
				if (item != null && item.Contains(needle))
					return true;
			}
			return false;
		}

		public static bool ListItemsContainsAll(string str, IEnumerable<string> needles)
		{
			if (str == null || needles == null)
				return false;
			
			foreach (var needle in needles)
			{
				if (needle == null || !str.Contains(needle))
					return false;
			}
			return true;
		}

		public static bool ListItemsContainsAny(IEnumerable<string> haystack, IEnumerable<string> needles)
		{
			if (haystack == null || needles == null)
				return false;

			foreach (string item in haystack)
			{
				foreach (var needle in needles)
				{
					if (item != null && item.Contains(needle))
						return true;
				}
			}
			return false;
		}

		private void buttonNewRecord_Click(object sender, EventArgs e)
		{
			Record record = new Record();
			using (FormRecord fr = new FormRecord(record, true))
			{
				if(fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					records.Add(record);
					recordsModified = true;
					if (Satisfies(record))
						InsertRecordToList(0, record);
				}
			}
		}

		private void buttonLastWeek_Click(object sender, EventArgs e)
		{
			dateTimePickerMax.Value = DateTime.Today;
			dateTimePickerMin.Value = DateTime.Today.AddDays(-7);
		}

		private void buttonLastMonth_Click(object sender, EventArgs e)
		{
			dateTimePickerMax.Value = DateTime.Today;
			dateTimePickerMin.Value = DateTime.Today.AddDays(-30);
		}

		private void buttonLastYear_Click(object sender, EventArgs e)
		{
			dateTimePickerMax.Value = DateTime.Today;
			dateTimePickerMin.Value = DateTime.Today.AddDays(-365);
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer.Stop();
			SaveRecords();
		}

		public void SaveRecords()
		{
			using (FileStream fs = new FileStream(Program.recordPath, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				Serializer.Serialize(fs, records);
			}
			string dir = Path.GetDirectoryName(Program.recordPath2);
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
			using (FileStream fs = new FileStream(Program.recordPath2, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				Serializer.Serialize(fs, records);
			}
			recordsModified = false;
		}

		public void SearchAsync()
		{
			if (backgroundWorkerSearch.IsBusy)
			{
				while (backgroundWorkerSearch.IsBusy)
					backgroundWorkerSearch.CancelAsync();
			}
			Searching = true;
			listViewRecords.Items.Clear();
			if (PrepareSearchArgs(true))
				backgroundWorkerSearch.RunWorkerAsync();
		}

		public bool PrepareSearchArgs(bool showError)
		{
			if (SearchArgs.sloan = checkBoxLoan.Checked)
			{
				if (!int.TryParse(textBoxLoanMin.Text, out SearchArgs.loanMin))
				{
					if (showError)
					{
						MessageBox.Show("Minimum borç aralığı bir tamsayı değil");
						return false;
					}
					else
						SearchArgs.sloan = false;
				}
				if (!int.TryParse(textBoxLoanMax.Text, out SearchArgs.loanMax))
				{
					if (showError)
					{
						MessageBox.Show("Maximum borç aralığı bir tamsayı değil");
						return false;
					}
					else
						SearchArgs.sloan = false;
				}
			}
			if (SearchArgs.sname = checkBoxName.Checked && textBoxName.Text.Length > 0)
			{
				SearchArgs.name = textBoxName.Text.Trim();
			}
			if (SearchArgs.sphone = checkBoxPhone.Checked && textBoxPhone.Text.Length > 0)
			{
				SearchArgs.phone = textBoxPhone.Text.Trim();
			}
			if (SearchArgs.sjob = checkBoxJob.Checked && comboBoxJob.Text.Length > 0)
			{
				SearchArgs.job = comboBoxJob.Text.Trim();
			}
			if (SearchArgs.sdate = checkBoxDate.Checked)
			{
				SearchArgs.dateMin = dateTimePickerMin.Value;
				SearchArgs.dateMax = dateTimePickerMax.Value;
			}
			SearchArgs.sOpen = checkBoxSearchOpen.Checked;
			SearchArgs.sClosed = checkBoxSearchClosed.Checked;

			return true;
		}

		private void Event_InstantRefresh(object sender, EventArgs e)
		{
			if (checkBoxInstantRefresh.Checked)
			{
				if (sender is TextBox || sender is ComboBox)
				{
					if ((checkBoxName.Checked && textBoxName.TextLength > 1) || (checkBoxPhone.Checked && textBoxPhone.TextLength > 2) || (checkBoxJob.Checked && comboBoxJob.Text.Length > 2))
						SearchAsync();
				}
				else
					SearchAsync();
			}
		}

		private static class SearchArgs
		{
			public static string name, phone, job;
			public static DateTime dateMin, dateMax;
			public static int loanMin, loanMax;
			public static bool sname, sphone, sjob, sdate, sloan, sOpen, sClosed;
		}

		private void InsertRecordToList(int index, Record record)
		{
			var item = new ListViewItem(record.name);
			item.Tag = record;
			item.SubItems.AddRange(new string[] { record.surname, record.phone, record.dateCreation.ToShortDateString(), record.dateModification.ToShortDateString(), record.jobs.ToListString(), record.payment.ToString(), record.payed.ToString(), (record.payment - record.payed).ToString(), record.closed ? "Kapalı" : "Açık" });
			item.ToolTipText = record.description;
			listViewRecords.Items.Insert(index, item);
			UpdateResultCount();
		}

		private void AddRecordToList(Record record)
		{
			var item = new ListViewItem(record.name);
			item.Tag = record;
			item.SubItems.AddRange(new string[] { record.surname, record.phone, record.dateCreation.ToShortDateString(), record.dateModification.ToShortDateString(), record.jobs.ToListString(), record.payment.ToString(), record.payed.ToString(), (record.payment - record.payed).ToString(), record.closed ? "Kapalı" : "Açık" });
			item.ToolTipText = record.description;
			listViewRecords.Items.Add(item);
			UpdateResultCount();
		}

		private static void ReflectRecordChange(ListViewItem item)
		{
			var record = (Record)item.Tag;
			item.Text = record.name;
			var subs = new string[] { 
				record.name, 
				record.surname, 
				record.phone, 
				record.dateCreation.ToShortDateString(), 
				record.dateModification.ToShortDateString(), 
				record.jobs.ToListString(), 
				record.payment.ToString(), 
				record.payed.ToString(), 
				(record.payment - record.payed).ToString(), 
				record.closed ? "Kapalı" : "Açık"
			};
			for (int i = 0; i < subs.Length; i++)
			{
				item.SubItems[i].Text = subs[i];
			}
			item.ToolTipText = record.description;
		}

		private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = records.Count - 1; i >= 0; i--)
			{
				var record = records[i];
				if (Satisfies(record))
				{
					if (listViewRecords.InvokeRequired)
						listViewRecords.Invoke((Action<Record>)AddRecordToList, record);
					else
						AddRecordToList(record);
				}
				if (backgroundWorkerSearch.CancellationPending)
					return;
				backgroundWorkerSearch.ReportProgress((records.Count - i) / records.Count * 100);
			}
		}

		private bool DateFilter(ref DateTime dateMin, ref DateTime dateMax, IEnumerable<CheckPoint> checkPoints)
		{
			bool result = true;
			foreach (var check in checkPoints)
			{
				if (!(check.date >= dateMin && check.date <= dateMax))
				{
					result = false;
					break;
				}
			}
			return result;
		}

		private bool Satisfies(Record record)
		{
			if (record == null)
				throw new ArgumentNullException("record");

			string[] names = !SearchArgs.sname || string.IsNullOrWhiteSpace(SearchArgs.name) ? null : SearchArgs.name.ToLower(Program.cult).Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			long loan = record.payment - record.payed;
			if (((SearchArgs.sOpen && !record.closed) || (SearchArgs.sClosed && record.closed)) &&
				(!SearchArgs.sname || string.IsNullOrWhiteSpace(SearchArgs.name) || 
					(SearchArgs.sname && (!string.IsNullOrWhiteSpace(record.name) && !string.IsNullOrWhiteSpace(record.surname) && ListItemsContainsAll(record.name.ToLower(Program.cult) + ' ' +  record.surname.ToLower(Program.cult), names)))) &&
				(!SearchArgs.sphone || string.IsNullOrWhiteSpace(SearchArgs.phone) || 
					(SearchArgs.sphone && !string.IsNullOrWhiteSpace(record.phone) && record.phone.Contains(SearchArgs.phone))) &&
				(!SearchArgs.sdate || (SearchArgs.sdate && ((record.dateCreation <= SearchArgs.dateMax && record.dateCreation >= SearchArgs.dateMin) || 
					(record.dateModification <= SearchArgs.dateMax && record.dateModification >= SearchArgs.dateMin) || 
					(record.checkPoints != null && (DateFilter(ref SearchArgs.dateMin, ref SearchArgs.dateMax, record.checkPoints)))))) &&
				(!SearchArgs.sjob || string.IsNullOrWhiteSpace(SearchArgs.job) || 
					(SearchArgs.sjob && ListItemsContains(record.jobs, SearchArgs.job))) &&
				(!SearchArgs.sloan || (SearchArgs.sloan && loan <= SearchArgs.loanMax && loan >= SearchArgs.loanMin)))
				return true;
			else
				return false;
		}

		private void backgroundWorkerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			toolStripProgressBarSearch.Value = e.ProgressPercentage;
		}

		private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show(e.Error.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!e.Cancelled)
			{
				Searching = false;
				toolStripProgressBarSearch.Value = 100;
			}
			UpdateResultCount();
		}

		private void UpdateResultCount()
		{
			toolStripStatusLabelSearchResult.Text = listViewRecords.Items.Count.ToString() + " Sonuç";
		}

		private void listViewRecords_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listViewRecords.SelectedItems.Count != 1)
				return;

			var record = (Record)listViewRecords.SelectedItems[0].Tag;
			using (FormRecord fr = new FormRecord(record, false))
			{
				if (fr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					recordsModified = true;
					PrepareSearchArgs(false);
					if (!Satisfies(record))
						listViewRecords.SelectedItems[0].Remove();
					else
						ReflectRecordChange(listViewRecords.SelectedItems[0]);
				}
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			ListViewItem[] items = new ListViewItem[listViewRecords.SelectedItems.Count];
			listViewRecords.SelectedItems.CopyTo(items, 0);
			for (int i = 0; i < items.Length; i++)
			{
				Record r = (Record)items[i].Tag;
				records.Remove(r);
				items[i].Remove();
			}
		}

		private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewRecords.SelectedItems.Count == 1)
				textBoxDescription.Text = listViewRecords.SelectedItems[0].ToolTipText;
			else
				textBoxDescription.Clear();
		}

		private void toolStripStatusLabelRecordPath_Click(object sender, EventArgs e)
		{
			ProcessStartInfo psi = new ProcessStartInfo("explorer", "/select," + Program.recordPath2);
			Process.Start(psi);
		}
	}
}
