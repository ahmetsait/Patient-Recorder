using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatientRecorder
{
	public partial class FormRecord : Form
	{
		public FormRecord(Record record, bool isNew)
		{
			if (record == null)
				throw new ArgumentNullException("record");
			InitializeComponent();
			this.record = record;
			this.isNew = isNew;
		}

		Record record;
		bool isNew;

		private void FormRecord_Load(object sender, EventArgs e)
		{
			if (isNew)
			{
				dateTimePickerCreation.Value = DateTime.Today;
				comboBoxColor.SelectedIndex = 0;
			}
			else
			{
				dateTimePickerCreation.Enabled = false;
				textBoxName.Text = record.name;
				textBoxSurname.Text = record.surname;
				maskedTextBoxPhone.Text = record.phone ?? "";
				dateTimePickerCreation.Value = record.dateCreation;
				listViewJobs.Items.Clear();
				if (record.jobs != null)
				{
					foreach (var job in record.jobs)
					{
						listViewJobs.Items.Add(job);
					}
				}
				textBoxPayment.Text = record.payment.ToString();
				textBoxPayed.Text = "0"; // record.payed.ToString();
				textBoxDescription.Text = record.description;
				comboBoxColor.SelectedIndex = (int)record.color;
				if (record.checkPoints != null)
				{
					for (int i = record.checkPoints.Count - 1; i >= 0; i--)
					{
						var check = record.checkPoints[i];
						ListViewItem item = new ListViewItem(check.date.ToShortDateString());
						item.SubItems.AddRange(new string[] { check.payment.ToString(), check.payed.ToString(), check.sumPayed.ToString(), (check.payment - check.sumPayed).ToString() });
						listViewCheckPoint.Items.Add(item);
					}
				}
			}
			labelIsClosed.Text = (checkBoxCloseRecord.Checked = record.closed) ? "Kayıt kapalı" : "";
			dateTimePickerModification.Value = DateTime.Today;
		}

		private int? Loan
		{
			set
			{
				labelLoan.Text = value.HasValue ? value.ToString() + " TL" : "??? TL";
			}
		}

		private void buttonResetLoan_Click(object sender, EventArgs e)
		{
			int payment;
			if (int.TryParse(textBoxPayment.Text.Trim(), out payment))
			{
				textBoxPayed.Text = textBoxPayment.Text;
			}
		}

		private void UpdateLoan()
		{
			int payment, payed;
			if (int.TryParse(textBoxPayment.Text, out payment) && int.TryParse(textBoxPayed.Text, out payed))
			{
				if (payment >= payed)
				{
					Loan = payment - payed - (record == null ? 0 : record.payed);
				}
			}
			else
			{
				Loan = null;
			}
		}

		private void textBoxPayment_TextChanged(object sender, EventArgs e)
		{
			UpdateLoan();
		}

		private void textBoxPayed_TextChanged(object sender, EventArgs e)
		{
			UpdateLoan();
		}

		private void textBoxPayment_Validating(object sender, CancelEventArgs e)
		{
			int payment, payed;
			if (int.TryParse(textBoxPayment.Text, out payment) && int.TryParse(textBoxPayed.Text, out payed))
			{
				if (payment < payed)
				{
					textBoxPayment.Text = payed.ToString();
				}
			}
			else if (!int.TryParse(textBoxPayment.Text, out payment))
			{
				if (int.TryParse(textBoxPayment.Text.Trim(), out payment))
					MessageBox.Show("\"Tutar\" bir tamsayı değil");
				e.Cancel = true;
			}
		}

		private void textBoxPayed_Validating(object sender, CancelEventArgs e)
		{
			int payment, payed;
			if (int.TryParse(textBoxPayment.Text, out payment) && int.TryParse(textBoxPayed.Text, out payed))
			{
				if (payment < payed)
				{
					textBoxPayed.Text = payed.ToString();
				}
			}
			else if (!int.TryParse(textBoxPayed.Text, out payed))
			{
				if (int.TryParse(textBoxPayed.Text.Trim(), out payed))
					MessageBox.Show("\"Alınan\" bir tamsayı değil");
				e.Cancel = true;
			}
		}

		private void buttonJobAdd_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(comboBoxJob.Text))
			{
				listViewJobs.Items.Add(comboBoxJob.Text);
			}
		}

		private void buttonJobDelete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem job in listViewJobs.SelectedItems)
			{
				listViewJobs.Items.Remove(job);
			}
		}

		char[] phoneRemoval = { ' ', '-', '(', ')' };

		string phone;

		private void buttonAccept_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text))
			{
				MessageBox.Show("Ad / Soyad kısmı boş bırakılamaz");
				return;
			}
			StringBuilder thePhone = new StringBuilder(10, 10);
			for (int i = 0; i < maskedTextBoxPhone.Text.Length; i++)
				if (!phoneRemoval.Contains(maskedTextBoxPhone.Text[i]))
					thePhone.Append(maskedTextBoxPhone.Text[i]);
			phone = thePhone.ToString();
			if (phone.Length != 10 && phone.Length != 0)
			{
				MessageBox.Show("Eksik yada yanlış telefon numarası");
				return;
			}
			int payment, payed;
			if (!int.TryParse(textBoxPayment.Text.Trim(), out payment))
			{
				MessageBox.Show("\"Tutar\" bir tamsayı değil");
				return;
			}
			if (!int.TryParse(textBoxPayed.Text.Trim(), out payed))
			{
				MessageBox.Show("\"Alınan\" bir tamsayı değil");
				return;
			}
			if (payed > payment)
			{
				MessageBox.Show("\"Alınan\" \"Tutar\"dan büyük olamaz");
				return;
			}
			if (payment < 0)
			{
				MessageBox.Show("Tutar 0'dan küçük olamaz");
				return;
			}
			if (dateTimePickerCreation.Value > DateTime.Today || dateTimePickerModification.Value > DateTime.Today)
			{
				MessageBox.Show("\"Oluşturma\" veya \"Değiştirme\" tarihi gelecekte olamaz");
				return;
			}
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void FormRecord_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				record.name = textBoxName.Text.Trim();
				record.surname = textBoxSurname.Text.Trim();

				record.phone = phone;

				List<string> jobs = new List<string>();
				foreach (ListViewItem item in listViewJobs.Items)
					jobs.Add(item.Text);
				record.jobs = jobs;

				record.payment = int.Parse(textBoxPayment.Text);

				int payed = int.Parse(textBoxPayed.Text);

				if (isNew)
					record.payed = payed;
				else
					record.payed += payed;
				
				record.dateCreation = dateTimePickerCreation.Value;
				record.dateModification = dateTimePickerModification.Value;
				record.description = textBoxDescription.Text;
				record.closed = checkBoxCloseRecord.Checked;
				record.color = (DentColor)comboBoxColor.SelectedIndex;

				{
					if (record.checkPoints == null)
						record.checkPoints = new List<CheckPoint>();
					if (record.checkPoints.Count == 0 || record.checkPoints.Count > 0 && (record.payed != 0 || record.checkPoints[record.checkPoints.Count - 1].payment != record.payment))
					{
						record.checkPoints.Add(new CheckPoint(ref record.dateModification, record.payment, payed, record.payed));
					}
				}
			}
		}
	}
}
