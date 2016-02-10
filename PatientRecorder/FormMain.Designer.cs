namespace PatientRecorder
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panelName = new System.Windows.Forms.Panel();
			this.checkBoxName = new System.Windows.Forms.CheckBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.panelPhone = new System.Windows.Forms.Panel();
			this.checkBoxPhone = new System.Windows.Forms.CheckBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.panelDate = new System.Windows.Forms.Panel();
			this.buttonLastYear = new System.Windows.Forms.Button();
			this.buttonLastMonth = new System.Windows.Forms.Button();
			this.buttonLastWeek = new System.Windows.Forms.Button();
			this.checkBoxDate = new System.Windows.Forms.CheckBox();
			this.dateTimePickerMax = new System.Windows.Forms.DateTimePicker();
			this.labelDate = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePickerMin = new System.Windows.Forms.DateTimePicker();
			this.panelJob = new System.Windows.Forms.Panel();
			this.checkBoxJob = new System.Windows.Forms.CheckBox();
			this.labelJob = new System.Windows.Forms.Label();
			this.comboBoxJob = new System.Windows.Forms.ComboBox();
			this.panelLoan = new System.Windows.Forms.Panel();
			this.checkBoxLoan = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLoanMin = new System.Windows.Forms.TextBox();
			this.labelLoan = new System.Windows.Forms.Label();
			this.textBoxLoanMax = new System.Windows.Forms.TextBox();
			this.flowLayoutPanelOC = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBoxSearchOpen = new System.Windows.Forms.CheckBox();
			this.checkBoxSearchClosed = new System.Windows.Forms.CheckBox();
			this.checkBoxInstantRefresh = new System.Windows.Forms.CheckBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonNewRecord = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listViewRecords = new System.Windows.Forms.ListView();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCreation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderModification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderJobs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderLoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBarSearch = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabelSearchStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelRecordPath = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelSearchResult = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.flowLayoutPanel.SuspendLayout();
			this.panelName.SuspendLayout();
			this.panelPhone.SuspendLayout();
			this.panelDate.SuspendLayout();
			this.panelJob.SuspendLayout();
			this.panelLoan.SuspendLayout();
			this.flowLayoutPanelOC.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer.Panel1.Controls.Add(this.flowLayoutPanel);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
			this.splitContainer.Panel2.Controls.Add(this.splitContainer1);
			this.splitContainer.Size = new System.Drawing.Size(984, 440);
			this.splitContainer.SplitterDistance = 300;
			this.splitContainer.SplitterWidth = 8;
			this.splitContainer.TabIndex = 0;
			this.splitContainer.TabStop = false;
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoSize = true;
			this.flowLayoutPanel.Controls.Add(this.panelName);
			this.flowLayoutPanel.Controls.Add(this.panelPhone);
			this.flowLayoutPanel.Controls.Add(this.panelDate);
			this.flowLayoutPanel.Controls.Add(this.panelJob);
			this.flowLayoutPanel.Controls.Add(this.panelLoan);
			this.flowLayoutPanel.Controls.Add(this.flowLayoutPanelOC);
			this.flowLayoutPanel.Controls.Add(this.checkBoxInstantRefresh);
			this.flowLayoutPanel.Controls.Add(this.buttonSearch);
			this.flowLayoutPanel.Controls.Add(this.buttonNewRecord);
			this.flowLayoutPanel.Controls.Add(this.buttonDelete);
			this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(300, 440);
			this.flowLayoutPanel.TabIndex = 13;
			this.flowLayoutPanel.WrapContents = false;
			// 
			// panelName
			// 
			this.panelName.AutoSize = true;
			this.panelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelName.Controls.Add(this.checkBoxName);
			this.panelName.Controls.Add(this.labelName);
			this.panelName.Controls.Add(this.textBoxName);
			this.panelName.Location = new System.Drawing.Point(3, 3);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(232, 29);
			this.panelName.TabIndex = 13;
			// 
			// checkBoxName
			// 
			this.checkBoxName.AutoSize = true;
			this.checkBoxName.Checked = true;
			this.checkBoxName.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxName.Location = new System.Drawing.Point(3, 8);
			this.checkBoxName.Name = "checkBoxName";
			this.checkBoxName.Size = new System.Drawing.Size(15, 14);
			this.checkBoxName.TabIndex = 7;
			this.checkBoxName.TabStop = false;
			this.toolTip.SetToolTip(this.checkBoxName, "Ad\'a göre filtrele");
			this.checkBoxName.UseVisualStyleBackColor = true;
			this.checkBoxName.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(24, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(62, 17);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Ad / Soyad:";
			this.labelName.UseCompatibleTextRendering = true;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.textBoxName.Location = new System.Drawing.Point(92, 3);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(137, 23);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.TextChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// panelPhone
			// 
			this.panelPhone.AutoSize = true;
			this.panelPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelPhone.Controls.Add(this.checkBoxPhone);
			this.panelPhone.Controls.Add(this.labelPhone);
			this.panelPhone.Controls.Add(this.textBoxPhone);
			this.panelPhone.Location = new System.Drawing.Point(3, 38);
			this.panelPhone.Name = "panelPhone";
			this.panelPhone.Size = new System.Drawing.Size(194, 29);
			this.panelPhone.TabIndex = 14;
			// 
			// checkBoxPhone
			// 
			this.checkBoxPhone.AutoSize = true;
			this.checkBoxPhone.Location = new System.Drawing.Point(3, 8);
			this.checkBoxPhone.Name = "checkBoxPhone";
			this.checkBoxPhone.Size = new System.Drawing.Size(15, 14);
			this.checkBoxPhone.TabIndex = 7;
			this.checkBoxPhone.TabStop = false;
			this.toolTip.SetToolTip(this.checkBoxPhone, "Telefon\'a göre filtrele");
			this.checkBoxPhone.UseVisualStyleBackColor = true;
			this.checkBoxPhone.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(24, 8);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(45, 17);
			this.labelPhone.TabIndex = 1;
			this.labelPhone.Text = "Telefon:";
			this.labelPhone.UseCompatibleTextRendering = true;
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxPhone.Location = new System.Drawing.Point(75, 3);
			this.textBoxPhone.MaxLength = 10;
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(116, 23);
			this.textBoxPhone.TabIndex = 1;
			this.textBoxPhone.TextChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// panelDate
			// 
			this.panelDate.AutoSize = true;
			this.panelDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelDate.Controls.Add(this.buttonLastYear);
			this.panelDate.Controls.Add(this.buttonLastMonth);
			this.panelDate.Controls.Add(this.buttonLastWeek);
			this.panelDate.Controls.Add(this.checkBoxDate);
			this.panelDate.Controls.Add(this.dateTimePickerMax);
			this.panelDate.Controls.Add(this.labelDate);
			this.panelDate.Controls.Add(this.label2);
			this.panelDate.Controls.Add(this.label3);
			this.panelDate.Controls.Add(this.dateTimePickerMin);
			this.panelDate.Location = new System.Drawing.Point(3, 73);
			this.panelDate.Name = "panelDate";
			this.panelDate.Size = new System.Drawing.Size(279, 111);
			this.panelDate.TabIndex = 14;
			// 
			// buttonLastYear
			// 
			this.buttonLastYear.Location = new System.Drawing.Point(3, 85);
			this.buttonLastYear.Name = "buttonLastYear";
			this.buttonLastYear.Size = new System.Drawing.Size(80, 23);
			this.buttonLastYear.TabIndex = 8;
			this.buttonLastYear.Text = "Son 365 Gün";
			this.buttonLastYear.UseCompatibleTextRendering = true;
			this.buttonLastYear.UseVisualStyleBackColor = true;
			this.buttonLastYear.Click += new System.EventHandler(this.buttonLastYear_Click);
			// 
			// buttonLastMonth
			// 
			this.buttonLastMonth.Location = new System.Drawing.Point(3, 56);
			this.buttonLastMonth.Name = "buttonLastMonth";
			this.buttonLastMonth.Size = new System.Drawing.Size(80, 23);
			this.buttonLastMonth.TabIndex = 8;
			this.buttonLastMonth.Text = "Son 30 Gün";
			this.buttonLastMonth.UseCompatibleTextRendering = true;
			this.buttonLastMonth.UseVisualStyleBackColor = true;
			this.buttonLastMonth.Click += new System.EventHandler(this.buttonLastMonth_Click);
			// 
			// buttonLastWeek
			// 
			this.buttonLastWeek.Location = new System.Drawing.Point(3, 27);
			this.buttonLastWeek.Name = "buttonLastWeek";
			this.buttonLastWeek.Size = new System.Drawing.Size(80, 23);
			this.buttonLastWeek.TabIndex = 8;
			this.buttonLastWeek.Text = "Son 7 Gün";
			this.buttonLastWeek.UseCompatibleTextRendering = true;
			this.buttonLastWeek.UseVisualStyleBackColor = true;
			this.buttonLastWeek.Click += new System.EventHandler(this.buttonLastWeek_Click);
			// 
			// checkBoxDate
			// 
			this.checkBoxDate.AutoSize = true;
			this.checkBoxDate.Location = new System.Drawing.Point(3, 7);
			this.checkBoxDate.Name = "checkBoxDate";
			this.checkBoxDate.Size = new System.Drawing.Size(15, 14);
			this.checkBoxDate.TabIndex = 7;
			this.checkBoxDate.TabStop = false;
			this.toolTip.SetToolTip(this.checkBoxDate, "Tarih\'e göre filtrele");
			this.checkBoxDate.UseVisualStyleBackColor = true;
			this.checkBoxDate.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// dateTimePickerMax
			// 
			this.dateTimePickerMax.Location = new System.Drawing.Point(95, 70);
			this.dateTimePickerMax.Name = "dateTimePickerMax";
			this.dateTimePickerMax.Size = new System.Drawing.Size(181, 20);
			this.dateTimePickerMax.TabIndex = 5;
			this.dateTimePickerMax.TabStop = false;
			this.dateTimePickerMax.ValueChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(24, 7);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(68, 17);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Tarih Aralığı:";
			this.labelDate.UseCompatibleTextRendering = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Başlangıç:";
			this.label2.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(95, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Bitiş:";
			this.label3.UseCompatibleTextRendering = true;
			// 
			// dateTimePickerMin
			// 
			this.dateTimePickerMin.Location = new System.Drawing.Point(95, 27);
			this.dateTimePickerMin.Name = "dateTimePickerMin";
			this.dateTimePickerMin.Size = new System.Drawing.Size(181, 20);
			this.dateTimePickerMin.TabIndex = 4;
			this.dateTimePickerMin.TabStop = false;
			this.dateTimePickerMin.ValueChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// panelJob
			// 
			this.panelJob.AutoSize = true;
			this.panelJob.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelJob.Controls.Add(this.checkBoxJob);
			this.panelJob.Controls.Add(this.labelJob);
			this.panelJob.Controls.Add(this.comboBoxJob);
			this.panelJob.Location = new System.Drawing.Point(3, 190);
			this.panelJob.Name = "panelJob";
			this.panelJob.Size = new System.Drawing.Size(199, 30);
			this.panelJob.TabIndex = 12;
			// 
			// checkBoxJob
			// 
			this.checkBoxJob.AutoSize = true;
			this.checkBoxJob.Location = new System.Drawing.Point(3, 8);
			this.checkBoxJob.Name = "checkBoxJob";
			this.checkBoxJob.Size = new System.Drawing.Size(15, 14);
			this.checkBoxJob.TabIndex = 7;
			this.checkBoxJob.TabStop = false;
			this.toolTip.SetToolTip(this.checkBoxJob, "İş\'e göre filtrele");
			this.checkBoxJob.UseVisualStyleBackColor = true;
			this.checkBoxJob.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// labelJob
			// 
			this.labelJob.AutoSize = true;
			this.labelJob.Location = new System.Drawing.Point(24, 8);
			this.labelJob.Name = "labelJob";
			this.labelJob.Size = new System.Drawing.Size(16, 17);
			this.labelJob.TabIndex = 1;
			this.labelJob.Text = "İş:";
			this.toolTip.SetToolTip(this.labelJob, "İş\'e göre kayıt bul");
			this.labelJob.UseCompatibleTextRendering = true;
			// 
			// comboBoxJob
			// 
			this.comboBoxJob.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.comboBoxJob.FormattingEnabled = true;
			this.comboBoxJob.Items.AddRange(new object[] {
            "diş çekimi",
            "cerrahi çekim",
            "kanal tedavisi",
            "lazer dolgu",
            "zirkonyum kron",
            "porselen kron",
            "alt total protez",
            "üst total protez",
            "alt porselen total protez",
            "üst porselen total protez",
            "alt parsiyel çelik protez",
            "üst parsiyel çelik protez",
            "implant avrupa",
            "implant yerli",
            "detertraj",
            "röntgen",
            "diş eti tedavisi",
            "ilaç tedavisi"});
			this.comboBoxJob.Location = new System.Drawing.Point(48, 3);
			this.comboBoxJob.Name = "comboBoxJob";
			this.comboBoxJob.Size = new System.Drawing.Size(148, 24);
			this.comboBoxJob.TabIndex = 6;
			this.comboBoxJob.TextChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// panelLoan
			// 
			this.panelLoan.AutoSize = true;
			this.panelLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelLoan.Controls.Add(this.checkBoxLoan);
			this.panelLoan.Controls.Add(this.label1);
			this.panelLoan.Controls.Add(this.textBoxLoanMin);
			this.panelLoan.Controls.Add(this.labelLoan);
			this.panelLoan.Controls.Add(this.textBoxLoanMax);
			this.panelLoan.Location = new System.Drawing.Point(3, 226);
			this.panelLoan.Name = "panelLoan";
			this.panelLoan.Size = new System.Drawing.Size(220, 29);
			this.panelLoan.TabIndex = 11;
			// 
			// checkBoxLoan
			// 
			this.checkBoxLoan.AutoSize = true;
			this.checkBoxLoan.Location = new System.Drawing.Point(3, 8);
			this.checkBoxLoan.Name = "checkBoxLoan";
			this.checkBoxLoan.Size = new System.Drawing.Size(15, 14);
			this.checkBoxLoan.TabIndex = 7;
			this.checkBoxLoan.TabStop = false;
			this.toolTip.SetToolTip(this.checkBoxLoan, "Borç Aralığına göre filtrele");
			this.checkBoxLoan.UseVisualStyleBackColor = true;
			this.checkBoxLoan.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(150, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "-";
			// 
			// textBoxLoanMin
			// 
			this.textBoxLoanMin.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.textBoxLoanMin.Location = new System.Drawing.Point(93, 3);
			this.textBoxLoanMin.Name = "textBoxLoanMin";
			this.textBoxLoanMin.Size = new System.Drawing.Size(51, 23);
			this.textBoxLoanMin.TabIndex = 7;
			this.textBoxLoanMin.TextChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// labelLoan
			// 
			this.labelLoan.AutoSize = true;
			this.labelLoan.Location = new System.Drawing.Point(24, 8);
			this.labelLoan.Name = "labelLoan";
			this.labelLoan.Size = new System.Drawing.Size(65, 17);
			this.labelLoan.TabIndex = 9;
			this.labelLoan.Text = "Borç Aralığı:";
			this.labelLoan.UseCompatibleTextRendering = true;
			// 
			// textBoxLoanMax
			// 
			this.textBoxLoanMax.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.textBoxLoanMax.Location = new System.Drawing.Point(166, 3);
			this.textBoxLoanMax.Name = "textBoxLoanMax";
			this.textBoxLoanMax.Size = new System.Drawing.Size(51, 23);
			this.textBoxLoanMax.TabIndex = 8;
			this.textBoxLoanMax.TextChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// flowLayoutPanelOC
			// 
			this.flowLayoutPanelOC.AutoSize = true;
			this.flowLayoutPanelOC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanelOC.Controls.Add(this.checkBoxSearchOpen);
			this.flowLayoutPanelOC.Controls.Add(this.checkBoxSearchClosed);
			this.flowLayoutPanelOC.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanelOC.Location = new System.Drawing.Point(3, 261);
			this.flowLayoutPanelOC.Name = "flowLayoutPanelOC";
			this.flowLayoutPanelOC.Size = new System.Drawing.Size(132, 48);
			this.flowLayoutPanelOC.TabIndex = 1;
			// 
			// checkBoxSearchOpen
			// 
			this.checkBoxSearchOpen.AutoSize = true;
			this.checkBoxSearchOpen.Checked = true;
			this.checkBoxSearchOpen.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSearchOpen.Location = new System.Drawing.Point(3, 3);
			this.checkBoxSearchOpen.Name = "checkBoxSearchOpen";
			this.checkBoxSearchOpen.Size = new System.Drawing.Size(116, 18);
			this.checkBoxSearchOpen.TabIndex = 0;
			this.checkBoxSearchOpen.TabStop = false;
			this.checkBoxSearchOpen.Text = "Açık kayıtlarda ara";
			this.checkBoxSearchOpen.UseCompatibleTextRendering = true;
			this.checkBoxSearchOpen.UseVisualStyleBackColor = true;
			this.checkBoxSearchOpen.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// checkBoxSearchClosed
			// 
			this.checkBoxSearchClosed.AutoSize = true;
			this.checkBoxSearchClosed.Location = new System.Drawing.Point(3, 27);
			this.checkBoxSearchClosed.Name = "checkBoxSearchClosed";
			this.checkBoxSearchClosed.Size = new System.Drawing.Size(126, 18);
			this.checkBoxSearchClosed.TabIndex = 0;
			this.checkBoxSearchClosed.TabStop = false;
			this.checkBoxSearchClosed.Text = "Kapalı kayıtlarda ara";
			this.checkBoxSearchClosed.UseCompatibleTextRendering = true;
			this.checkBoxSearchClosed.UseVisualStyleBackColor = true;
			this.checkBoxSearchClosed.CheckedChanged += new System.EventHandler(this.Event_InstantRefresh);
			// 
			// checkBoxInstantRefresh
			// 
			this.checkBoxInstantRefresh.AutoSize = true;
			this.checkBoxInstantRefresh.Location = new System.Drawing.Point(3, 315);
			this.checkBoxInstantRefresh.Name = "checkBoxInstantRefresh";
			this.checkBoxInstantRefresh.Size = new System.Drawing.Size(139, 18);
			this.checkBoxInstantRefresh.TabIndex = 0;
			this.checkBoxInstantRefresh.TabStop = false;
			this.checkBoxInstantRefresh.Text = "Hızlı aramayı etkinleştir";
			this.checkBoxInstantRefresh.UseCompatibleTextRendering = true;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearch.Location = new System.Drawing.Point(202, 339);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(80, 23);
			this.buttonSearch.TabIndex = 50;
			this.buttonSearch.Text = "Ara";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonNewRecord
			// 
			this.buttonNewRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonNewRecord.Location = new System.Drawing.Point(105, 368);
			this.buttonNewRecord.Name = "buttonNewRecord";
			this.buttonNewRecord.Size = new System.Drawing.Size(75, 23);
			this.buttonNewRecord.TabIndex = 100;
			this.buttonNewRecord.Text = "Yeni Kayıt";
			this.buttonNewRecord.UseVisualStyleBackColor = true;
			this.buttonNewRecord.Click += new System.EventHandler(this.buttonNewRecord_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelete.Location = new System.Drawing.Point(202, 397);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(80, 23);
			this.buttonDelete.TabIndex = 50;
			this.buttonDelete.Text = "Kaydı Sil";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listViewRecords);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBoxDescription);
			this.splitContainer1.Size = new System.Drawing.Size(676, 440);
			this.splitContainer1.SplitterDistance = 353;
			this.splitContainer1.SplitterWidth = 8;
			this.splitContainer1.TabIndex = 2;
			this.splitContainer1.TabStop = false;
			// 
			// listViewRecords
			// 
			this.listViewRecords.AllowColumnReorder = true;
			this.listViewRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSurname,
            this.columnHeaderPhone,
            this.columnHeaderCreation,
            this.columnHeaderModification,
            this.columnHeaderJobs,
            this.columnHeaderPayment,
            this.columnHeaderPayed,
            this.columnHeaderLoan,
            this.columnHeaderStatus});
			this.listViewRecords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewRecords.FullRowSelect = true;
			this.listViewRecords.Location = new System.Drawing.Point(0, 0);
			this.listViewRecords.Name = "listViewRecords";
			this.listViewRecords.ShowItemToolTips = true;
			this.listViewRecords.Size = new System.Drawing.Size(676, 353);
			this.listViewRecords.TabIndex = 0;
			this.listViewRecords.TabStop = false;
			this.listViewRecords.UseCompatibleStateImageBehavior = false;
			this.listViewRecords.View = System.Windows.Forms.View.Details;
			this.listViewRecords.SelectedIndexChanged += new System.EventHandler(this.listViewRecords_SelectedIndexChanged);
			this.listViewRecords.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewRecords_MouseDoubleClick);
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Ad";
			this.columnHeaderName.Width = 89;
			// 
			// columnHeaderSurname
			// 
			this.columnHeaderSurname.Text = "Soyad";
			this.columnHeaderSurname.Width = 75;
			// 
			// columnHeaderPhone
			// 
			this.columnHeaderPhone.Text = "Telefon";
			this.columnHeaderPhone.Width = 94;
			// 
			// columnHeaderCreation
			// 
			this.columnHeaderCreation.Text = "Kayıt Tarihi";
			this.columnHeaderCreation.Width = 69;
			// 
			// columnHeaderModification
			// 
			this.columnHeaderModification.Text = "Son Değiştirme";
			this.columnHeaderModification.Width = 83;
			// 
			// columnHeaderJobs
			// 
			this.columnHeaderJobs.Text = "Yapılan İşler";
			this.columnHeaderJobs.Width = 92;
			// 
			// columnHeaderPayment
			// 
			this.columnHeaderPayment.Text = "Tutar";
			this.columnHeaderPayment.Width = 44;
			// 
			// columnHeaderPayed
			// 
			this.columnHeaderPayed.Text = "Alınan";
			this.columnHeaderPayed.Width = 42;
			// 
			// columnHeaderLoan
			// 
			this.columnHeaderLoan.Text = "Borç";
			this.columnHeaderLoan.Width = 38;
			// 
			// columnHeaderStatus
			// 
			this.columnHeaderStatus.Text = "Durum";
			this.columnHeaderStatus.Width = 43;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxDescription.Font = new System.Drawing.Font("Arial", 8.25F);
			this.textBoxDescription.Location = new System.Drawing.Point(0, 0);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(676, 79);
			this.textBoxDescription.TabIndex = 1;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarSearch,
            this.toolStripStatusLabelSearchStatus,
            this.toolStripStatusLabelRecordPath,
            this.toolStripStatusLabelSearchResult});
			this.statusStrip.Location = new System.Drawing.Point(0, 440);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(984, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripProgressBarSearch
			// 
			this.toolStripProgressBarSearch.Name = "toolStripProgressBarSearch";
			this.toolStripProgressBarSearch.Size = new System.Drawing.Size(100, 16);
			// 
			// toolStripStatusLabelSearchStatus
			// 
			this.toolStripStatusLabelSearchStatus.Name = "toolStripStatusLabelSearchStatus";
			this.toolStripStatusLabelSearchStatus.Size = new System.Drawing.Size(77, 17);
			this.toolStripStatusLabelSearchStatus.Text = "Search Status";
			// 
			// toolStripStatusLabelRecordPath
			// 
			this.toolStripStatusLabelRecordPath.Name = "toolStripStatusLabelRecordPath";
			this.toolStripStatusLabelRecordPath.Size = new System.Drawing.Size(395, 17);
			this.toolStripStatusLabelRecordPath.Spring = true;
			this.toolStripStatusLabelRecordPath.Text = "Record Path";
			this.toolStripStatusLabelRecordPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolStripStatusLabelRecordPath.Click += new System.EventHandler(this.toolStripStatusLabelRecordPath_Click);
			// 
			// toolStripStatusLabelSearchResult
			// 
			this.toolStripStatusLabelSearchResult.Name = "toolStripStatusLabelSearchResult";
			this.toolStripStatusLabelSearchResult.Size = new System.Drawing.Size(395, 17);
			this.toolStripStatusLabelSearchResult.Spring = true;
			this.toolStripStatusLabelSearchResult.Text = "Search Result";
			this.toolStripStatusLabelSearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 500;
			this.toolTip.ReshowDelay = 100;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 60000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// backgroundWorkerSearch
			// 
			this.backgroundWorkerSearch.WorkerReportsProgress = true;
			this.backgroundWorkerSearch.WorkerSupportsCancellation = true;
			this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
			this.backgroundWorkerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSearch_ProgressChanged);
			this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 462);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.statusStrip);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kayıt Defteri";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.flowLayoutPanel.ResumeLayout(false);
			this.flowLayoutPanel.PerformLayout();
			this.panelName.ResumeLayout(false);
			this.panelName.PerformLayout();
			this.panelPhone.ResumeLayout(false);
			this.panelPhone.PerformLayout();
			this.panelDate.ResumeLayout(false);
			this.panelDate.PerformLayout();
			this.panelJob.ResumeLayout(false);
			this.panelJob.PerformLayout();
			this.panelLoan.ResumeLayout(false);
			this.panelLoan.PerformLayout();
			this.flowLayoutPanelOC.ResumeLayout(false);
			this.flowLayoutPanelOC.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.CheckBox checkBoxJob;
		private System.Windows.Forms.CheckBox checkBoxDate;
		private System.Windows.Forms.CheckBox checkBoxPhone;
		private System.Windows.Forms.CheckBox checkBoxName;
		private System.Windows.Forms.ComboBox comboBoxJob;
		private System.Windows.Forms.DateTimePicker dateTimePickerMin;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelJob;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.TextBox textBoxLoanMax;
		private System.Windows.Forms.TextBox textBoxLoanMin;
		private System.Windows.Forms.Label labelLoan;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerMax;
		private System.Windows.Forms.CheckBox checkBoxLoan;
		private System.Windows.Forms.Panel panelName;
		private System.Windows.Forms.CheckBox checkBoxInstantRefresh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panelPhone;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Panel panelDate;
		private System.Windows.Forms.Panel panelJob;
		private System.Windows.Forms.Panel panelLoan;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderSurname;
		private System.Windows.Forms.ColumnHeader columnHeaderPhone;
		private System.Windows.Forms.ColumnHeader columnHeaderCreation;
		private System.Windows.Forms.ColumnHeader columnHeaderJobs;
		private System.Windows.Forms.ColumnHeader columnHeaderPayment;
		private System.Windows.Forms.ColumnHeader columnHeaderPayed;
		private System.Windows.Forms.ColumnHeader columnHeaderLoan;
		private System.Windows.Forms.Button buttonNewRecord;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSearchStatus;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarSearch;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSearchResult;
		private System.Windows.Forms.Button buttonLastMonth;
		private System.Windows.Forms.Button buttonLastWeek;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.ColumnHeader columnHeaderModification;
		private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.ListView listViewRecords;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox checkBoxSearchOpen;
		private System.Windows.Forms.CheckBox checkBoxSearchClosed;
		private System.Windows.Forms.ColumnHeader columnHeaderStatus;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOC;
		private System.Windows.Forms.Button buttonLastYear;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRecordPath;
	}
}

