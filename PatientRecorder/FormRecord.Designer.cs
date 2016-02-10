namespace PatientRecorder
{
	partial class FormRecord
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
			this.labelLoan = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxPayed = new System.Windows.Forms.TextBox();
			this.textBoxPayment = new System.Windows.Forms.TextBox();
			this.buttonJobDelete = new System.Windows.Forms.Button();
			this.buttonJobAdd = new System.Windows.Forms.Button();
			this.comboBoxJob = new System.Windows.Forms.ComboBox();
			this.dateTimePickerCreation = new System.Windows.Forms.DateTimePicker();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.listViewJobs = new System.Windows.Forms.ListView();
			this.columnHeaderDefault = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBoxSurname = new System.Windows.Forms.TextBox();
			this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelPayed = new System.Windows.Forms.Label();
			this.labelSurname = new System.Windows.Forms.Label();
			this.labelPayment = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.labelJob = new System.Windows.Forms.Label();
			this.labelCreationDate = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.buttonResetLoan = new System.Windows.Forms.Button();
			this.labelModificationDate = new System.Windows.Forms.Label();
			this.dateTimePickerModification = new System.Windows.Forms.DateTimePicker();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.checkBoxCloseRecord = new System.Windows.Forms.CheckBox();
			this.labelIsClosed = new System.Windows.Forms.Label();
			this.comboBoxColor = new System.Windows.Forms.ComboBox();
			this.labelColor = new System.Windows.Forms.Label();
			this.listViewCheckPoint = new System.Windows.Forms.ListView();
			this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPayed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderLoan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// labelLoan
			// 
			this.labelLoan.AutoSize = true;
			this.labelLoan.Location = new System.Drawing.Point(208, 256);
			this.labelLoan.Name = "labelLoan";
			this.labelLoan.Size = new System.Drawing.Size(27, 17);
			this.labelLoan.TabIndex = 33;
			this.labelLoan.Text = "0 TL";
			this.labelLoan.UseCompatibleTextRendering = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(139, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 17);
			this.label4.TabIndex = 32;
			this.label4.Text = "Kalan Borç:";
			this.label4.UseCompatibleTextRendering = true;
			// 
			// textBoxPayed
			// 
			this.textBoxPayed.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.textBoxPayed.Location = new System.Drawing.Point(52, 251);
			this.textBoxPayed.Name = "textBoxPayed";
			this.textBoxPayed.Size = new System.Drawing.Size(81, 23);
			this.textBoxPayed.TabIndex = 9;
			this.textBoxPayed.Text = "0";
			this.textBoxPayed.TextChanged += new System.EventHandler(this.textBoxPayed_TextChanged);
			this.textBoxPayed.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPayed_Validating);
			// 
			// textBoxPayment
			// 
			this.textBoxPayment.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.textBoxPayment.Location = new System.Drawing.Point(52, 222);
			this.textBoxPayment.Name = "textBoxPayment";
			this.textBoxPayment.Size = new System.Drawing.Size(81, 23);
			this.textBoxPayment.TabIndex = 8;
			this.textBoxPayment.Text = "0";
			this.textBoxPayment.TextChanged += new System.EventHandler(this.textBoxPayment_TextChanged);
			this.textBoxPayment.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPayment_Validating);
			// 
			// buttonJobDelete
			// 
			this.buttonJobDelete.AutoSize = true;
			this.buttonJobDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonJobDelete.Location = new System.Drawing.Point(174, 183);
			this.buttonJobDelete.Name = "buttonJobDelete";
			this.buttonJobDelete.Size = new System.Drawing.Size(28, 23);
			this.buttonJobDelete.TabIndex = 0;
			this.buttonJobDelete.TabStop = false;
			this.buttonJobDelete.Text = "Sil";
			this.buttonJobDelete.UseVisualStyleBackColor = true;
			this.buttonJobDelete.Click += new System.EventHandler(this.buttonJobDelete_Click);
			// 
			// buttonJobAdd
			// 
			this.buttonJobAdd.AutoSize = true;
			this.buttonJobAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonJobAdd.Location = new System.Drawing.Point(149, 154);
			this.buttonJobAdd.Name = "buttonJobAdd";
			this.buttonJobAdd.Size = new System.Drawing.Size(53, 23);
			this.buttonJobAdd.TabIndex = 7;
			this.buttonJobAdd.Text = "Ekle >>";
			this.buttonJobAdd.UseVisualStyleBackColor = true;
			this.buttonJobAdd.Click += new System.EventHandler(this.buttonJobAdd_Click);
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
			this.comboBoxJob.Location = new System.Drawing.Point(64, 124);
			this.comboBoxJob.Name = "comboBoxJob";
			this.comboBoxJob.Size = new System.Drawing.Size(138, 24);
			this.comboBoxJob.TabIndex = 6;
			// 
			// dateTimePickerCreation
			// 
			this.dateTimePickerCreation.Location = new System.Drawing.Point(109, 72);
			this.dateTimePickerCreation.Name = "dateTimePickerCreation";
			this.dateTimePickerCreation.Size = new System.Drawing.Size(181, 20);
			this.dateTimePickerCreation.TabIndex = 4;
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxName.Location = new System.Drawing.Point(39, 12);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(137, 23);
			this.textBoxName.TabIndex = 1;
			// 
			// listViewJobs
			// 
			this.listViewJobs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDefault});
			this.listViewJobs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.listViewJobs.FullRowSelect = true;
			this.listViewJobs.GridLines = true;
			this.listViewJobs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewJobs.Location = new System.Drawing.Point(208, 124);
			this.listViewJobs.Name = "listViewJobs";
			this.listViewJobs.Size = new System.Drawing.Size(144, 97);
			this.listViewJobs.TabIndex = 10;
			this.listViewJobs.TabStop = false;
			this.listViewJobs.UseCompatibleStateImageBehavior = false;
			this.listViewJobs.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderDefault
			// 
			this.columnHeaderDefault.Text = "Yapılan İş";
			this.columnHeaderDefault.Width = 125;
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.textBoxSurname.Location = new System.Drawing.Point(227, 12);
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new System.Drawing.Size(125, 23);
			this.textBoxSurname.TabIndex = 2;
			// 
			// maskedTextBoxPhone
			// 
			this.maskedTextBoxPhone.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.maskedTextBoxPhone.Location = new System.Drawing.Point(64, 43);
			this.maskedTextBoxPhone.Mask = "(999) 000-00 00";
			this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
			this.maskedTextBoxPhone.Size = new System.Drawing.Size(112, 23);
			this.maskedTextBoxPhone.TabIndex = 3;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 17);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(21, 17);
			this.labelName.TabIndex = 16;
			this.labelName.Text = "Ad:";
			this.labelName.UseCompatibleTextRendering = true;
			// 
			// labelPayed
			// 
			this.labelPayed.AutoSize = true;
			this.labelPayed.Location = new System.Drawing.Point(12, 256);
			this.labelPayed.Name = "labelPayed";
			this.labelPayed.Size = new System.Drawing.Size(39, 17);
			this.labelPayed.TabIndex = 15;
			this.labelPayed.Text = "Alınan:";
			this.labelPayed.UseCompatibleTextRendering = true;
			// 
			// labelSurname
			// 
			this.labelSurname.AutoSize = true;
			this.labelSurname.Location = new System.Drawing.Point(182, 17);
			this.labelSurname.Name = "labelSurname";
			this.labelSurname.Size = new System.Drawing.Size(39, 17);
			this.labelSurname.TabIndex = 14;
			this.labelSurname.Text = "Soyad:";
			this.labelSurname.UseCompatibleTextRendering = true;
			// 
			// labelPayment
			// 
			this.labelPayment.AutoSize = true;
			this.labelPayment.Location = new System.Drawing.Point(12, 227);
			this.labelPayment.Name = "labelPayment";
			this.labelPayment.Size = new System.Drawing.Size(34, 17);
			this.labelPayment.TabIndex = 13;
			this.labelPayment.Text = "Tutar:";
			this.labelPayment.UseCompatibleTextRendering = true;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(12, 48);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(45, 17);
			this.labelPhone.TabIndex = 12;
			this.labelPhone.Text = "Telefon:";
			this.labelPhone.UseCompatibleTextRendering = true;
			// 
			// labelJob
			// 
			this.labelJob.AutoSize = true;
			this.labelJob.Location = new System.Drawing.Point(12, 129);
			this.labelJob.Name = "labelJob";
			this.labelJob.Size = new System.Drawing.Size(16, 17);
			this.labelJob.TabIndex = 18;
			this.labelJob.Text = "İş:";
			this.labelJob.UseCompatibleTextRendering = true;
			// 
			// labelCreationDate
			// 
			this.labelCreationDate.AutoSize = true;
			this.labelCreationDate.Location = new System.Drawing.Point(12, 75);
			this.labelCreationDate.Name = "labelCreationDate";
			this.labelCreationDate.Size = new System.Drawing.Size(91, 17);
			this.labelCreationDate.TabIndex = 11;
			this.labelCreationDate.Text = "Oluşturma Tarihi:";
			this.labelCreationDate.UseCompatibleTextRendering = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(12, 467);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 34;
			this.buttonCancel.TabStop = false;
			this.buttonCancel.Text = "İptal";
			this.buttonCancel.UseCompatibleTextRendering = true;
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonAccept
			// 
			this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAccept.Location = new System.Drawing.Point(277, 467);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(75, 23);
			this.buttonAccept.TabIndex = 50;
			this.buttonAccept.Text = "Kaydet";
			this.buttonAccept.UseCompatibleTextRendering = true;
			this.buttonAccept.UseVisualStyleBackColor = true;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// buttonResetLoan
			// 
			this.buttonResetLoan.Location = new System.Drawing.Point(271, 251);
			this.buttonResetLoan.Name = "buttonResetLoan";
			this.buttonResetLoan.Size = new System.Drawing.Size(81, 23);
			this.buttonResetLoan.TabIndex = 10;
			this.buttonResetLoan.Text = "Borcu Sil";
			this.buttonResetLoan.UseCompatibleTextRendering = true;
			this.buttonResetLoan.UseVisualStyleBackColor = true;
			this.buttonResetLoan.Click += new System.EventHandler(this.buttonResetLoan_Click);
			// 
			// labelModificationDate
			// 
			this.labelModificationDate.AutoSize = true;
			this.labelModificationDate.Location = new System.Drawing.Point(12, 101);
			this.labelModificationDate.Name = "labelModificationDate";
			this.labelModificationDate.Size = new System.Drawing.Size(90, 17);
			this.labelModificationDate.TabIndex = 11;
			this.labelModificationDate.Text = "Değiştirme Tarih:";
			this.labelModificationDate.UseCompatibleTextRendering = true;
			// 
			// dateTimePickerModification
			// 
			this.dateTimePickerModification.Enabled = false;
			this.dateTimePickerModification.Location = new System.Drawing.Point(109, 98);
			this.dateTimePickerModification.Name = "dateTimePickerModification";
			this.dateTimePickerModification.Size = new System.Drawing.Size(181, 20);
			this.dateTimePickerModification.TabIndex = 5;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxDescription.Location = new System.Drawing.Point(12, 383);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(340, 78);
			this.textBoxDescription.TabIndex = 11;
			// 
			// checkBoxCloseRecord
			// 
			this.checkBoxCloseRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.checkBoxCloseRecord.AutoSize = true;
			this.checkBoxCloseRecord.Location = new System.Drawing.Point(141, 472);
			this.checkBoxCloseRecord.Name = "checkBoxCloseRecord";
			this.checkBoxCloseRecord.Size = new System.Drawing.Size(82, 18);
			this.checkBoxCloseRecord.TabIndex = 51;
			this.checkBoxCloseRecord.Text = "Kaydı kapat";
			this.checkBoxCloseRecord.UseCompatibleTextRendering = true;
			this.checkBoxCloseRecord.UseVisualStyleBackColor = true;
			// 
			// labelIsClosed
			// 
			this.labelIsClosed.ForeColor = System.Drawing.Color.Red;
			this.labelIsClosed.Location = new System.Drawing.Point(227, 38);
			this.labelIsClosed.Name = "labelIsClosed";
			this.labelIsClosed.Size = new System.Drawing.Size(125, 31);
			this.labelIsClosed.TabIndex = 52;
			this.labelIsClosed.Text = "Kayıt kapalı";
			this.labelIsClosed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBoxColor
			// 
			this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxColor.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.comboBoxColor.FormattingEnabled = true;
			this.comboBoxColor.Items.AddRange(new object[] {
            "Yok",
            "A1",
            "A2",
            "A3",
            "A3.5",
            "A4",
            "B1",
            "B2",
            "B3",
            "B4",
            "C1",
            "C2",
            "C3",
            "C4",
            "D2",
            "D3",
            "D4"});
			this.comboBoxColor.Location = new System.Drawing.Point(52, 192);
			this.comboBoxColor.Name = "comboBoxColor";
			this.comboBoxColor.Size = new System.Drawing.Size(81, 24);
			this.comboBoxColor.TabIndex = 6;
			this.comboBoxColor.TabStop = false;
			// 
			// labelColor
			// 
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new System.Drawing.Point(12, 197);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(34, 17);
			this.labelColor.TabIndex = 13;
			this.labelColor.Text = "Renk:";
			this.labelColor.UseCompatibleTextRendering = true;
			// 
			// listViewCheckPoint
			// 
			this.listViewCheckPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewCheckPoint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderPayment,
            this.columnHeaderPayed,
            this.columnHeaderLoan});
			this.listViewCheckPoint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.listViewCheckPoint.FullRowSelect = true;
			this.listViewCheckPoint.GridLines = true;
			this.listViewCheckPoint.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewCheckPoint.Location = new System.Drawing.Point(12, 280);
			this.listViewCheckPoint.Name = "listViewCheckPoint";
			this.listViewCheckPoint.Size = new System.Drawing.Size(340, 97);
			this.listViewCheckPoint.TabIndex = 10;
			this.listViewCheckPoint.TabStop = false;
			this.listViewCheckPoint.UseCompatibleStateImageBehavior = false;
			this.listViewCheckPoint.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderDate
			// 
			this.columnHeaderDate.Text = "Tarih";
			this.columnHeaderDate.Width = 125;
			// 
			// columnHeaderPayment
			// 
			this.columnHeaderPayment.Text = "Tutar";
			this.columnHeaderPayment.Width = 52;
			// 
			// columnHeaderPayed
			// 
			this.columnHeaderPayed.Text = "Alınan";
			this.columnHeaderPayed.Width = 54;
			// 
			// columnHeaderLoan
			// 
			this.columnHeaderLoan.Text = "Borç";
			this.columnHeaderLoan.Width = 53;
			// 
			// FormRecord
			// 
			this.AcceptButton = this.buttonAccept;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(364, 502);
			this.Controls.Add(this.listViewCheckPoint);
			this.Controls.Add(this.labelIsClosed);
			this.Controls.Add(this.checkBoxCloseRecord);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.buttonAccept);
			this.Controls.Add(this.buttonResetLoan);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelLoan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPayed);
			this.Controls.Add(this.textBoxPayment);
			this.Controls.Add(this.buttonJobDelete);
			this.Controls.Add(this.buttonJobAdd);
			this.Controls.Add(this.comboBoxColor);
			this.Controls.Add(this.comboBoxJob);
			this.Controls.Add(this.dateTimePickerModification);
			this.Controls.Add(this.dateTimePickerCreation);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.listViewJobs);
			this.Controls.Add(this.textBoxSurname);
			this.Controls.Add(this.maskedTextBoxPhone);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelPayed);
			this.Controls.Add(this.labelSurname);
			this.Controls.Add(this.labelColor);
			this.Controls.Add(this.labelPayment);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelModificationDate);
			this.Controls.Add(this.labelJob);
			this.Controls.Add(this.labelCreationDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormRecord";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Hasta Kayıt";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRecord_FormClosed);
			this.Load += new System.EventHandler(this.FormRecord_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLoan;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxPayed;
		private System.Windows.Forms.TextBox textBoxPayment;
		private System.Windows.Forms.Button buttonJobDelete;
		private System.Windows.Forms.Button buttonJobAdd;
		private System.Windows.Forms.ComboBox comboBoxJob;
		private System.Windows.Forms.DateTimePicker dateTimePickerCreation;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.ListView listViewJobs;
		private System.Windows.Forms.ColumnHeader columnHeaderDefault;
		private System.Windows.Forms.TextBox textBoxSurname;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelPayed;
		private System.Windows.Forms.Label labelSurname;
		private System.Windows.Forms.Label labelPayment;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Label labelJob;
		private System.Windows.Forms.Label labelCreationDate;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonAccept;
		private System.Windows.Forms.Button buttonResetLoan;
		private System.Windows.Forms.Label labelModificationDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerModification;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.CheckBox checkBoxCloseRecord;
		private System.Windows.Forms.Label labelIsClosed;
		private System.Windows.Forms.ComboBox comboBoxColor;
		private System.Windows.Forms.Label labelColor;
		private System.Windows.Forms.ListView listViewCheckPoint;
		private System.Windows.Forms.ColumnHeader columnHeaderDate;
		private System.Windows.Forms.ColumnHeader columnHeaderPayed;
		private System.Windows.Forms.ColumnHeader columnHeaderLoan;
		private System.Windows.Forms.ColumnHeader columnHeaderPayment;

	}
}