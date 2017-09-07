namespace FinalProject1.GUI
{
    partial class FormSalesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesManager));
            this.listViewClientShow = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddressStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostalCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFaxNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCreditLimit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxButtonsClient = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSortEmp = new System.Windows.Forms.ComboBox();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.buttonListClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.comboBoxSearchClient = new System.Windows.Forms.ComboBox();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonExitClient = new System.Windows.Forms.Button();
            this.buttonClearClient = new System.Windows.Forms.Button();
            this.buttonSaveClient = new System.Windows.Forms.Button();
            this.groupBoxInfoClient = new System.Windows.Forms.GroupBox();
            this.textBoxCreditClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.textBoxEmailClient = new System.Windows.Forms.TextBox();
            this.labelEmailClient = new System.Windows.Forms.Label();
            this.textBoxPostalCodeClient = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxCityClient = new System.Windows.Forms.TextBox();
            this.textBoxStreetClient = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.textBoxPhoneClient = new System.Windows.Forms.TextBox();
            this.textBoxFaxNumClient = new System.Windows.Forms.TextBox();
            this.textBoxNameClient = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFaxNumber = new System.Windows.Forms.Label();
            this.labelNameClient = new System.Windows.Forms.Label();
            this.textBoxIDClient = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitleName = new System.Windows.Forms.Label();
            this.groupBoxButtonsClient.SuspendLayout();
            this.groupBoxInfoClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewClientShow
            // 
            this.listViewClientShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewClientShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderAddressStreet,
            this.columnHeaderCity,
            this.columnHeaderPostalCode,
            this.columnHeaderFaxNum,
            this.columnHeaderTel,
            this.columnHeaderEmail,
            this.columnHeaderAccount,
            this.columnHeaderCreditLimit});
            this.listViewClientShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClientShow.FullRowSelect = true;
            this.listViewClientShow.GridLines = true;
            this.listViewClientShow.Location = new System.Drawing.Point(257, 50);
            this.listViewClientShow.Name = "listViewClientShow";
            this.listViewClientShow.Size = new System.Drawing.Size(840, 533);
            this.listViewClientShow.TabIndex = 3;
            this.listViewClientShow.UseCompatibleStateImageBehavior = false;
            this.listViewClientShow.View = System.Windows.Forms.View.Details;
            this.listViewClientShow.SelectedIndexChanged += new System.EventHandler(this.listViewClient_SelectedIndexChanged);
            this.listViewClientShow.DoubleClick += new System.EventHandler(this.listViewDoubleClickSales);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 56;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 68;
            // 
            // columnHeaderAddressStreet
            // 
            this.columnHeaderAddressStreet.DisplayIndex = 3;
            this.columnHeaderAddressStreet.Text = "Address(Street)";
            this.columnHeaderAddressStreet.Width = 113;
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.DisplayIndex = 4;
            this.columnHeaderCity.Text = "City";
            this.columnHeaderCity.Width = 50;
            // 
            // columnHeaderPostalCode
            // 
            this.columnHeaderPostalCode.DisplayIndex = 5;
            this.columnHeaderPostalCode.Text = "Postal Code";
            this.columnHeaderPostalCode.Width = 91;
            // 
            // columnHeaderFaxNum
            // 
            this.columnHeaderFaxNum.DisplayIndex = 2;
            this.columnHeaderFaxNum.Text = "Fax Number";
            this.columnHeaderFaxNum.Width = 97;
            // 
            // columnHeaderTel
            // 
            this.columnHeaderTel.Text = "Phone Number";
            this.columnHeaderTel.Width = 95;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "E-mail";
            this.columnHeaderEmail.Width = 88;
            // 
            // columnHeaderAccount
            // 
            this.columnHeaderAccount.Text = "Account";
            this.columnHeaderAccount.Width = 87;
            // 
            // columnHeaderCreditLimit
            // 
            this.columnHeaderCreditLimit.Text = "Credit Limit";
            this.columnHeaderCreditLimit.Width = 90;
            // 
            // groupBoxButtonsClient
            // 
            this.groupBoxButtonsClient.Controls.Add(this.button1);
            this.groupBoxButtonsClient.Controls.Add(this.comboBoxSortEmp);
            this.groupBoxButtonsClient.Controls.Add(this.buttonSearchClient);
            this.groupBoxButtonsClient.Controls.Add(this.textBoxSearchClient);
            this.groupBoxButtonsClient.Controls.Add(this.buttonListClient);
            this.groupBoxButtonsClient.Controls.Add(this.buttonDeleteClient);
            this.groupBoxButtonsClient.Controls.Add(this.comboBoxSearchClient);
            this.groupBoxButtonsClient.Location = new System.Drawing.Point(12, 42);
            this.groupBoxButtonsClient.Name = "groupBoxButtonsClient";
            this.groupBoxButtonsClient.Size = new System.Drawing.Size(239, 153);
            this.groupBoxButtonsClient.TabIndex = 30;
            this.groupBoxButtonsClient.TabStop = false;
            this.groupBoxButtonsClient.Enter += new System.EventHandler(this.groupBoxButtonsClient_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show All(Binary)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSortEmp
            // 
            this.comboBoxSortEmp.FormattingEnabled = true;
            this.comboBoxSortEmp.Items.AddRange(new object[] {
            "Sort By ID",
            "Sort By Name"});
            this.comboBoxSortEmp.Location = new System.Drawing.Point(5, 91);
            this.comboBoxSortEmp.Name = "comboBoxSortEmp";
            this.comboBoxSortEmp.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSortEmp.TabIndex = 2;
            this.comboBoxSortEmp.Text = "List Sort By";
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buttonSearchClient.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchClient.Image")));
            this.buttonSearchClient.Location = new System.Drawing.Point(127, 19);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(98, 27);
            this.buttonSearchClient.TabIndex = 3;
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(5, 52);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(104, 20);
            this.textBoxSearchClient.TabIndex = 1;
            // 
            // buttonListClient
            // 
            this.buttonListClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListClient.Location = new System.Drawing.Point(126, 85);
            this.buttonListClient.Name = "buttonListClient";
            this.buttonListClient.Size = new System.Drawing.Size(100, 29);
            this.buttonListClient.TabIndex = 5;
            this.buttonListClient.Text = "Show &All";
            this.buttonListClient.UseVisualStyleBackColor = true;
            this.buttonListClient.Click += new System.EventHandler(this.buttonListClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(127, 52);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(99, 29);
            this.buttonDeleteClient.TabIndex = 4;
            this.buttonDeleteClient.Text = "&Delete";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // comboBoxSearchClient
            // 
            this.comboBoxSearchClient.FormattingEnabled = true;
            this.comboBoxSearchClient.Items.AddRange(new object[] {
            "Search By Id",
            "Search By Name"});
            this.comboBoxSearchClient.Location = new System.Drawing.Point(5, 19);
            this.comboBoxSearchClient.Name = "comboBoxSearchClient";
            this.comboBoxSearchClient.Size = new System.Drawing.Size(104, 21);
            this.comboBoxSearchClient.TabIndex = 0;
            this.comboBoxSearchClient.Text = "Enter search type";
            this.comboBoxSearchClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchClient_SelectedIndexChanged);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateClient.Location = new System.Drawing.Point(117, 314);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(98, 31);
            this.buttonUpdateClient.TabIndex = 12;
            this.buttonUpdateClient.Text = "&Update";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // buttonExitClient
            // 
            this.buttonExitClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitClient.Location = new System.Drawing.Point(117, 351);
            this.buttonExitClient.Name = "buttonExitClient";
            this.buttonExitClient.Size = new System.Drawing.Size(98, 31);
            this.buttonExitClient.TabIndex = 13;
            this.buttonExitClient.Text = "E&xit";
            this.buttonExitClient.UseVisualStyleBackColor = true;
            this.buttonExitClient.Click += new System.EventHandler(this.buttonExitClient_Click);
            // 
            // buttonClearClient
            // 
            this.buttonClearClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearClient.Location = new System.Drawing.Point(1, 351);
            this.buttonClearClient.Name = "buttonClearClient";
            this.buttonClearClient.Size = new System.Drawing.Size(98, 31);
            this.buttonClearClient.TabIndex = 11;
            this.buttonClearClient.Text = "&Clear";
            this.buttonClearClient.UseVisualStyleBackColor = true;
            this.buttonClearClient.Click += new System.EventHandler(this.buttonClearClient_Click);
            // 
            // buttonSaveClient
            // 
            this.buttonSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveClient.Location = new System.Drawing.Point(0, 314);
            this.buttonSaveClient.Name = "buttonSaveClient";
            this.buttonSaveClient.Size = new System.Drawing.Size(100, 31);
            this.buttonSaveClient.TabIndex = 10;
            this.buttonSaveClient.Text = "&Save";
            this.buttonSaveClient.UseVisualStyleBackColor = true;
            this.buttonSaveClient.Click += new System.EventHandler(this.buttonSaveClient_Click);
            // 
            // groupBoxInfoClient
            // 
            this.groupBoxInfoClient.Controls.Add(this.textBoxCreditClient);
            this.groupBoxInfoClient.Controls.Add(this.label2);
            this.groupBoxInfoClient.Controls.Add(this.textBoxAccount);
            this.groupBoxInfoClient.Controls.Add(this.label1);
            this.groupBoxInfoClient.Controls.Add(this.labelAccount);
            this.groupBoxInfoClient.Controls.Add(this.textBoxEmailClient);
            this.groupBoxInfoClient.Controls.Add(this.labelEmailClient);
            this.groupBoxInfoClient.Controls.Add(this.textBoxPostalCodeClient);
            this.groupBoxInfoClient.Controls.Add(this.labelPostalCode);
            this.groupBoxInfoClient.Controls.Add(this.textBoxCityClient);
            this.groupBoxInfoClient.Controls.Add(this.buttonUpdateClient);
            this.groupBoxInfoClient.Controls.Add(this.buttonClearClient);
            this.groupBoxInfoClient.Controls.Add(this.buttonExitClient);
            this.groupBoxInfoClient.Controls.Add(this.textBoxStreetClient);
            this.groupBoxInfoClient.Controls.Add(this.labelCity);
            this.groupBoxInfoClient.Controls.Add(this.buttonSaveClient);
            this.groupBoxInfoClient.Controls.Add(this.labelStreet);
            this.groupBoxInfoClient.Controls.Add(this.textBoxPhoneClient);
            this.groupBoxInfoClient.Controls.Add(this.textBoxFaxNumClient);
            this.groupBoxInfoClient.Controls.Add(this.textBoxNameClient);
            this.groupBoxInfoClient.Controls.Add(this.labelPhone);
            this.groupBoxInfoClient.Controls.Add(this.labelFaxNumber);
            this.groupBoxInfoClient.Controls.Add(this.labelNameClient);
            this.groupBoxInfoClient.Controls.Add(this.textBoxIDClient);
            this.groupBoxInfoClient.Controls.Add(this.labelId);
            this.groupBoxInfoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoClient.Location = new System.Drawing.Point(12, 201);
            this.groupBoxInfoClient.Name = "groupBoxInfoClient";
            this.groupBoxInfoClient.Size = new System.Drawing.Size(239, 389);
            this.groupBoxInfoClient.TabIndex = 29;
            this.groupBoxInfoClient.TabStop = false;
            this.groupBoxInfoClient.Text = "Info Client";
            this.groupBoxInfoClient.Enter += new System.EventHandler(this.groupBoxInfoClient_Enter);
            // 
            // textBoxCreditClient
            // 
            this.textBoxCreditClient.Location = new System.Drawing.Point(110, 279);
            this.textBoxCreditClient.Name = "textBoxCreditClient";
            this.textBoxCreditClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxCreditClient.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Credit :";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(110, 247);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(114, 21);
            this.textBoxAccount.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "(4-Digit)";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.Location = new System.Drawing.Point(5, 250);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(62, 13);
            this.labelAccount.TabIndex = 53;
            this.labelAccount.Text = "Account :";
            // 
            // textBoxEmailClient
            // 
            this.textBoxEmailClient.Location = new System.Drawing.Point(110, 135);
            this.textBoxEmailClient.Name = "textBoxEmailClient";
            this.textBoxEmailClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxEmailClient.TabIndex = 4;
            // 
            // labelEmailClient
            // 
            this.labelEmailClient.AutoSize = true;
            this.labelEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailClient.Location = new System.Drawing.Point(6, 135);
            this.labelEmailClient.Name = "labelEmailClient";
            this.labelEmailClient.Size = new System.Drawing.Size(52, 15);
            this.labelEmailClient.TabIndex = 24;
            this.labelEmailClient.Text = "Email :";
            // 
            // textBoxPostalCodeClient
            // 
            this.textBoxPostalCodeClient.Location = new System.Drawing.Point(110, 216);
            this.textBoxPostalCodeClient.Name = "textBoxPostalCodeClient";
            this.textBoxPostalCodeClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxPostalCodeClient.TabIndex = 7;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostalCode.Location = new System.Drawing.Point(6, 217);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(92, 15);
            this.labelPostalCode.TabIndex = 22;
            this.labelPostalCode.Text = "Postal Code :";
            // 
            // textBoxCityClient
            // 
            this.textBoxCityClient.Location = new System.Drawing.Point(110, 190);
            this.textBoxCityClient.Name = "textBoxCityClient";
            this.textBoxCityClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxCityClient.TabIndex = 6;
            // 
            // textBoxStreetClient
            // 
            this.textBoxStreetClient.Location = new System.Drawing.Point(110, 163);
            this.textBoxStreetClient.Name = "textBoxStreetClient";
            this.textBoxStreetClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxStreetClient.TabIndex = 5;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(6, 191);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 15);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "City :";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreet.Location = new System.Drawing.Point(5, 168);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(53, 15);
            this.labelStreet.TabIndex = 18;
            this.labelStreet.Text = "Street :";
            // 
            // textBoxPhoneClient
            // 
            this.textBoxPhoneClient.Location = new System.Drawing.Point(110, 107);
            this.textBoxPhoneClient.Name = "textBoxPhoneClient";
            this.textBoxPhoneClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxPhoneClient.TabIndex = 3;
            // 
            // textBoxFaxNumClient
            // 
            this.textBoxFaxNumClient.Location = new System.Drawing.Point(110, 81);
            this.textBoxFaxNumClient.Name = "textBoxFaxNumClient";
            this.textBoxFaxNumClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxFaxNumClient.TabIndex = 2;
            // 
            // textBoxNameClient
            // 
            this.textBoxNameClient.Location = new System.Drawing.Point(110, 54);
            this.textBoxNameClient.Name = "textBoxNameClient";
            this.textBoxNameClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxNameClient.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(6, 107);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(111, 15);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone Number :";
            // 
            // labelFaxNumber
            // 
            this.labelFaxNumber.AutoSize = true;
            this.labelFaxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaxNumber.Location = new System.Drawing.Point(6, 82);
            this.labelFaxNumber.Name = "labelFaxNumber";
            this.labelFaxNumber.Size = new System.Drawing.Size(89, 15);
            this.labelFaxNumber.TabIndex = 13;
            this.labelFaxNumber.Text = "Fax Number:";
            // 
            // labelNameClient
            // 
            this.labelNameClient.AutoSize = true;
            this.labelNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameClient.Location = new System.Drawing.Point(5, 55);
            this.labelNameClient.Name = "labelNameClient";
            this.labelNameClient.Size = new System.Drawing.Size(49, 15);
            this.labelNameClient.TabIndex = 12;
            this.labelNameClient.Text = "Name:";
            // 
            // textBoxIDClient
            // 
            this.textBoxIDClient.Location = new System.Drawing.Point(111, 16);
            this.textBoxIDClient.Name = "textBoxIDClient";
            this.textBoxIDClient.Size = new System.Drawing.Size(114, 21);
            this.textBoxIDClient.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(6, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(80, 15);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "ID Number:";
            // 
            // labelTitleName
            // 
            this.labelTitleName.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitleName.Location = new System.Drawing.Point(10, 9);
            this.labelTitleName.Name = "labelTitleName";
            this.labelTitleName.Size = new System.Drawing.Size(1076, 23);
            this.labelTitleName.TabIndex = 31;
            this.labelTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 610);
            this.Controls.Add(this.labelTitleName);
            this.Controls.Add(this.groupBoxButtonsClient);
            this.Controls.Add(this.groupBoxInfoClient);
            this.Controls.Add(this.listViewClientShow);
            this.Name = "FormSalesManager";
            this.Text = "FormSalesManager";
            this.Load += new System.EventHandler(this.FormSalesManager_Load);
            this.groupBoxButtonsClient.ResumeLayout(false);
            this.groupBoxButtonsClient.PerformLayout();
            this.groupBoxInfoClient.ResumeLayout(false);
            this.groupBoxInfoClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewClientShow;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFaxNum;
        private System.Windows.Forms.ColumnHeader columnHeaderAddressStreet;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderPostalCode;
        private System.Windows.Forms.ColumnHeader columnHeaderTel;
        private System.Windows.Forms.GroupBox groupBoxButtonsClient;
        private System.Windows.Forms.Button buttonListClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Button buttonExitClient;
        private System.Windows.Forms.Button buttonClearClient;
        private System.Windows.Forms.Button buttonSaveClient;
        private System.Windows.Forms.GroupBox groupBoxInfoClient;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.ComboBox comboBoxSearchClient;
        private System.Windows.Forms.TextBox textBoxPhoneClient;
        private System.Windows.Forms.TextBox textBoxFaxNumClient;
        private System.Windows.Forms.TextBox textBoxNameClient;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFaxNumber;
        private System.Windows.Forms.Label labelNameClient;
        private System.Windows.Forms.TextBox textBoxIDClient;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxPostalCodeClient;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxCityClient;
        private System.Windows.Forms.TextBox textBoxStreetClient;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox textBoxEmailClient;
        private System.Windows.Forms.Label labelEmailClient;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSortEmp;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ColumnHeader columnHeaderAccount;
        private System.Windows.Forms.ColumnHeader columnHeaderCreditLimit;
        private System.Windows.Forms.TextBox textBoxCreditClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTitleName;
    }
}