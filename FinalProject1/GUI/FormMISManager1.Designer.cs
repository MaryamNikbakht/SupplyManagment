namespace FinalProject1.GUI
{
    partial class FormMISManager1
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxSortEmp = new System.Windows.Forms.ComboBox();
            this.buttonListEmp = new System.Windows.Forms.Button();
            this.buttonDeleteEmp = new System.Windows.Forms.Button();
            this.buttonSearchEmp = new System.Windows.Forms.Button();
            this.textBoxSearchEmp = new System.Windows.Forms.TextBox();
            this.comboBoxSearchEmp = new System.Windows.Forms.ComboBox();
            this.groupBoxAddEmployee = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitleEmp = new System.Windows.Forms.TextBox();
            this.buttonExitEmp = new System.Windows.Forms.Button();
            this.textBoxLNameEmp = new System.Windows.Forms.TextBox();
            this.buttonUpdateEmp = new System.Windows.Forms.Button();
            this.buttonClearEmp = new System.Windows.Forms.Button();
            this.textBoxFnameEmp = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.buttonSaveEmp = new System.Windows.Forms.Button();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxIDEmp = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.tabPageManageUser = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxSortUser = new System.Windows.Forms.ComboBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonListUser = new System.Windows.Forms.Button();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.textBoxSearchUser = new System.Windows.Forms.TextBox();
            this.comboBoxSearchUser = new System.Windows.Forms.ComboBox();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.columnHeaderIDUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTitleUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTitleUser = new System.Windows.Forms.TextBox();
            this.labelTitleUser = new System.Windows.Forms.Label();
            this.buttonExitUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.textBoxFullNameUser = new System.Windows.Forms.TextBox();
            this.labelFullNameUser = new System.Windows.Forms.Label();
            this.buttonClearUser = new System.Windows.Forms.Button();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.labelIdUser = new System.Windows.Forms.Label();
            this.labelNameTitle = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAddEmployee.SuspendLayout();
            this.tabPageManageUser.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageManageUser);
            this.tabControlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 51);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(754, 420);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.listViewEmployee);
            this.tabPageMain.Controls.Add(this.groupBox3);
            this.tabPageMain.Controls.Add(this.groupBoxAddEmployee);
            this.tabPageMain.Location = new System.Drawing.Point(4, 24);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(746, 392);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Manage Employee";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeadertitle});
            this.listViewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEmployee.FullRowSelect = true;
            this.listViewEmployee.GridLines = true;
            this.listViewEmployee.Location = new System.Drawing.Point(254, 6);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(486, 380);
            this.listViewEmployee.TabIndex = 28;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            this.listViewEmployee.SelectedIndexChanged += new System.EventHandler(this.listViewEmployee_SelectedIndexChanged);
            this.listViewEmployee.DoubleClick += new System.EventHandler(this.listViewEmployeeDoubleClich);
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Tag = "";
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 118;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Tag = "";
            this.columnHeaderFirstName.Text = "Fisrt Name";
            this.columnHeaderFirstName.Width = 125;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last name";
            this.columnHeaderLastName.Width = 83;
            // 
            // columnHeadertitle
            // 
            this.columnHeadertitle.Text = "Title";
            this.columnHeadertitle.Width = 85;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxSortEmp);
            this.groupBox3.Controls.Add(this.buttonListEmp);
            this.groupBox3.Controls.Add(this.buttonDeleteEmp);
            this.groupBox3.Controls.Add(this.buttonSearchEmp);
            this.groupBox3.Controls.Add(this.textBoxSearchEmp);
            this.groupBox3.Controls.Add(this.comboBoxSearchEmp);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, -2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 156);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboBoxSortEmp
            // 
            this.comboBoxSortEmp.FormattingEnabled = true;
            this.comboBoxSortEmp.Items.AddRange(new object[] {
            "Sort By ID",
            "Sort By First Name",
            "Sort By Last Name",
            "Sort By Title"});
            this.comboBoxSortEmp.Location = new System.Drawing.Point(9, 116);
            this.comboBoxSortEmp.Name = "comboBoxSortEmp";
            this.comboBoxSortEmp.Size = new System.Drawing.Size(102, 23);
            this.comboBoxSortEmp.TabIndex = 4;
            this.comboBoxSortEmp.Text = "List Sort By";
            // 
            // buttonListEmp
            // 
            this.buttonListEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListEmp.Location = new System.Drawing.Point(132, 116);
            this.buttonListEmp.Name = "buttonListEmp";
            this.buttonListEmp.Size = new System.Drawing.Size(99, 23);
            this.buttonListEmp.TabIndex = 5;
            this.buttonListEmp.Text = "Show &All";
            this.buttonListEmp.UseVisualStyleBackColor = true;
            this.buttonListEmp.Click += new System.EventHandler(this.buttonListEmp_Click);
            // 
            // buttonDeleteEmp
            // 
            this.buttonDeleteEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteEmp.Location = new System.Drawing.Point(132, 51);
            this.buttonDeleteEmp.Name = "buttonDeleteEmp";
            this.buttonDeleteEmp.Size = new System.Drawing.Size(99, 27);
            this.buttonDeleteEmp.TabIndex = 3;
            this.buttonDeleteEmp.Text = "&Delete";
            this.buttonDeleteEmp.UseVisualStyleBackColor = true;
            this.buttonDeleteEmp.Click += new System.EventHandler(this.buttonDeleteEmp_Click);
            // 
            // buttonSearchEmp
            // 
            this.buttonSearchEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchEmp.Location = new System.Drawing.Point(133, 19);
            this.buttonSearchEmp.Name = "buttonSearchEmp";
            this.buttonSearchEmp.Size = new System.Drawing.Size(98, 25);
            this.buttonSearchEmp.TabIndex = 2;
            this.buttonSearchEmp.Text = "&Search";
            this.buttonSearchEmp.UseVisualStyleBackColor = true;
            this.buttonSearchEmp.Click += new System.EventHandler(this.buttonSearchEmp_Click);
            // 
            // textBoxSearchEmp
            // 
            this.textBoxSearchEmp.Location = new System.Drawing.Point(10, 51);
            this.textBoxSearchEmp.Multiline = true;
            this.textBoxSearchEmp.Name = "textBoxSearchEmp";
            this.textBoxSearchEmp.Size = new System.Drawing.Size(98, 26);
            this.textBoxSearchEmp.TabIndex = 1;
            // 
            // comboBoxSearchEmp
            // 
            this.comboBoxSearchEmp.FormattingEnabled = true;
            this.comboBoxSearchEmp.Items.AddRange(new object[] {
            "Search By ID",
            "Search By First Name",
            "Search By Last Name"});
            this.comboBoxSearchEmp.Location = new System.Drawing.Point(9, 19);
            this.comboBoxSearchEmp.Name = "comboBoxSearchEmp";
            this.comboBoxSearchEmp.Size = new System.Drawing.Size(99, 23);
            this.comboBoxSearchEmp.TabIndex = 0;
            this.comboBoxSearchEmp.Text = "Enter search type";
            this.comboBoxSearchEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchEmp_SelectedIndexChanged);
            // 
            // groupBoxAddEmployee
            // 
            this.groupBoxAddEmployee.Controls.Add(this.label1);
            this.groupBoxAddEmployee.Controls.Add(this.textBoxTitleEmp);
            this.groupBoxAddEmployee.Controls.Add(this.buttonExitEmp);
            this.groupBoxAddEmployee.Controls.Add(this.textBoxLNameEmp);
            this.groupBoxAddEmployee.Controls.Add(this.buttonUpdateEmp);
            this.groupBoxAddEmployee.Controls.Add(this.buttonClearEmp);
            this.groupBoxAddEmployee.Controls.Add(this.textBoxFnameEmp);
            this.groupBoxAddEmployee.Controls.Add(this.labelTitle);
            this.groupBoxAddEmployee.Controls.Add(this.labelLname);
            this.groupBoxAddEmployee.Controls.Add(this.buttonSaveEmp);
            this.groupBoxAddEmployee.Controls.Add(this.labelFName);
            this.groupBoxAddEmployee.Controls.Add(this.textBoxIDEmp);
            this.groupBoxAddEmployee.Controls.Add(this.labelId);
            this.groupBoxAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddEmployee.Location = new System.Drawing.Point(9, 160);
            this.groupBoxAddEmployee.Name = "groupBoxAddEmployee";
            this.groupBoxAddEmployee.Size = new System.Drawing.Size(239, 226);
            this.groupBoxAddEmployee.TabIndex = 19;
            this.groupBoxAddEmployee.TabStop = false;
            this.groupBoxAddEmployee.Text = "Add New Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "(4 digits number)";
            // 
            // textBoxTitleEmp
            // 
            this.textBoxTitleEmp.Location = new System.Drawing.Point(132, 120);
            this.textBoxTitleEmp.Name = "textBoxTitleEmp";
            this.textBoxTitleEmp.Size = new System.Drawing.Size(102, 21);
            this.textBoxTitleEmp.TabIndex = 4;
            // 
            // buttonExitEmp
            // 
            this.buttonExitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitEmp.Location = new System.Drawing.Point(132, 189);
            this.buttonExitEmp.Name = "buttonExitEmp";
            this.buttonExitEmp.Size = new System.Drawing.Size(101, 31);
            this.buttonExitEmp.TabIndex = 8;
            this.buttonExitEmp.Text = "E&xit";
            this.buttonExitEmp.UseVisualStyleBackColor = true;
            this.buttonExitEmp.Click += new System.EventHandler(this.buttonExitEmp_Click);
            // 
            // textBoxLNameEmp
            // 
            this.textBoxLNameEmp.Location = new System.Drawing.Point(132, 85);
            this.textBoxLNameEmp.Name = "textBoxLNameEmp";
            this.textBoxLNameEmp.Size = new System.Drawing.Size(102, 21);
            this.textBoxLNameEmp.TabIndex = 3;
            // 
            // buttonUpdateEmp
            // 
            this.buttonUpdateEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateEmp.Location = new System.Drawing.Point(132, 152);
            this.buttonUpdateEmp.Name = "buttonUpdateEmp";
            this.buttonUpdateEmp.Size = new System.Drawing.Size(101, 31);
            this.buttonUpdateEmp.TabIndex = 6;
            this.buttonUpdateEmp.Text = "&Update";
            this.buttonUpdateEmp.UseVisualStyleBackColor = true;
            this.buttonUpdateEmp.Click += new System.EventHandler(this.buttonUpdateEmp_Click);
            // 
            // buttonClearEmp
            // 
            this.buttonClearEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEmp.Location = new System.Drawing.Point(10, 189);
            this.buttonClearEmp.Name = "buttonClearEmp";
            this.buttonClearEmp.Size = new System.Drawing.Size(98, 31);
            this.buttonClearEmp.TabIndex = 7;
            this.buttonClearEmp.Text = "&Clear";
            this.buttonClearEmp.UseVisualStyleBackColor = true;
            this.buttonClearEmp.Click += new System.EventHandler(this.buttonClearEmp_Click);
            // 
            // textBoxFnameEmp
            // 
            this.textBoxFnameEmp.Location = new System.Drawing.Point(132, 59);
            this.textBoxFnameEmp.Name = "textBoxFnameEmp";
            this.textBoxFnameEmp.Size = new System.Drawing.Size(102, 21);
            this.textBoxFnameEmp.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(6, 120);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(43, 15);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title :";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(6, 85);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(86, 15);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "Last Name*:";
            // 
            // buttonSaveEmp
            // 
            this.buttonSaveEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEmp.Location = new System.Drawing.Point(9, 152);
            this.buttonSaveEmp.Name = "buttonSaveEmp";
            this.buttonSaveEmp.Size = new System.Drawing.Size(99, 31);
            this.buttonSaveEmp.TabIndex = 5;
            this.buttonSaveEmp.Text = "A&dd";
            this.buttonSaveEmp.UseVisualStyleBackColor = true;
            this.buttonSaveEmp.Click += new System.EventHandler(this.buttonSaveEmp_Click);
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(6, 59);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(87, 15);
            this.labelFName.TabIndex = 2;
            this.labelFName.Text = "First Name*:";
            // 
            // textBoxIDEmp
            // 
            this.textBoxIDEmp.Location = new System.Drawing.Point(132, 15);
            this.textBoxIDEmp.Name = "textBoxIDEmp";
            this.textBoxIDEmp.Size = new System.Drawing.Size(102, 21);
            this.textBoxIDEmp.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(6, 16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(86, 15);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID Number*:";
            // 
            // tabPageManageUser
            // 
            this.tabPageManageUser.AutoScroll = true;
            this.tabPageManageUser.Controls.Add(this.groupBox5);
            this.tabPageManageUser.Controls.Add(this.listViewUser);
            this.tabPageManageUser.Controls.Add(this.groupBox1);
            this.tabPageManageUser.Location = new System.Drawing.Point(4, 24);
            this.tabPageManageUser.Name = "tabPageManageUser";
            this.tabPageManageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManageUser.Size = new System.Drawing.Size(746, 392);
            this.tabPageManageUser.TabIndex = 2;
            this.tabPageManageUser.Text = "Manage User";
            this.tabPageManageUser.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSortUser);
            this.groupBox5.Controls.Add(this.buttonDeleteUser);
            this.groupBox5.Controls.Add(this.buttonListUser);
            this.groupBox5.Controls.Add(this.buttonSearchUser);
            this.groupBox5.Controls.Add(this.textBoxSearchUser);
            this.groupBox5.Controls.Add(this.comboBoxSearchUser);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 144);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // comboBoxSortUser
            // 
            this.comboBoxSortUser.FormattingEnabled = true;
            this.comboBoxSortUser.Items.AddRange(new object[] {
            "Sort By ID",
            "Sort By FullName",
            "Sort By Title"});
            this.comboBoxSortUser.Location = new System.Drawing.Point(6, 109);
            this.comboBoxSortUser.Name = "comboBoxSortUser";
            this.comboBoxSortUser.Size = new System.Drawing.Size(111, 23);
            this.comboBoxSortUser.TabIndex = 2;
            this.comboBoxSortUser.Text = "List Sort By";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(129, 50);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(99, 26);
            this.buttonDeleteUser.TabIndex = 4;
            this.buttonDeleteUser.Text = "&Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonListUser
            // 
            this.buttonListUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListUser.Location = new System.Drawing.Point(130, 109);
            this.buttonListUser.Name = "buttonListUser";
            this.buttonListUser.Size = new System.Drawing.Size(98, 23);
            this.buttonListUser.TabIndex = 5;
            this.buttonListUser.Text = "Show &All";
            this.buttonListUser.UseVisualStyleBackColor = true;
            this.buttonListUser.Click += new System.EventHandler(this.buttonListUser_Click);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchUser.Location = new System.Drawing.Point(130, 19);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(98, 25);
            this.buttonSearchUser.TabIndex = 3;
            this.buttonSearchUser.Text = "&Search";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.Location = new System.Drawing.Point(6, 50);
            this.textBoxSearchUser.Multiline = true;
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Size = new System.Drawing.Size(111, 25);
            this.textBoxSearchUser.TabIndex = 1;
            // 
            // comboBoxSearchUser
            // 
            this.comboBoxSearchUser.FormattingEnabled = true;
            this.comboBoxSearchUser.Items.AddRange(new object[] {
            "Search By ID",
            "Search By Fullname"});
            this.comboBoxSearchUser.Location = new System.Drawing.Point(6, 19);
            this.comboBoxSearchUser.Name = "comboBoxSearchUser";
            this.comboBoxSearchUser.Size = new System.Drawing.Size(111, 23);
            this.comboBoxSearchUser.TabIndex = 0;
            this.comboBoxSearchUser.Text = "Enter search type";
            // 
            // listViewUser
            // 
            this.listViewUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIDUser,
            this.columnHeaderFullName,
            this.columnHeaderTitleUser,
            this.columnHeaderUserName,
            this.columnHeaderPassword});
            this.listViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUser.FullRowSelect = true;
            this.listViewUser.GridLines = true;
            this.listViewUser.Location = new System.Drawing.Point(251, 6);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(489, 380);
            this.listViewUser.TabIndex = 27;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            this.listViewUser.SelectedIndexChanged += new System.EventHandler(this.listViewUser_SelectedIndexChanged);
            this.listViewUser.DoubleClick += new System.EventHandler(this.listViewDoubleClickUser);
            // 
            // columnHeaderIDUser
            // 
            this.columnHeaderIDUser.Text = "ID";
            this.columnHeaderIDUser.Width = 47;
            // 
            // columnHeaderFullName
            // 
            this.columnHeaderFullName.Text = "Full Name";
            this.columnHeaderFullName.Width = 133;
            // 
            // columnHeaderTitleUser
            // 
            this.columnHeaderTitleUser.Text = "Title";
            this.columnHeaderTitleUser.Width = 85;
            // 
            // columnHeaderUserName
            // 
            this.columnHeaderUserName.Text = "User Name";
            this.columnHeaderUserName.Width = 106;
            // 
            // columnHeaderPassword
            // 
            this.columnHeaderPassword.Text = "Password";
            this.columnHeaderPassword.Width = 89;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTitleUser);
            this.groupBox1.Controls.Add(this.labelTitleUser);
            this.groupBox1.Controls.Add(this.buttonExitUser);
            this.groupBox1.Controls.Add(this.buttonUpdateUser);
            this.groupBox1.Controls.Add(this.textBoxFullNameUser);
            this.groupBox1.Controls.Add(this.labelFullNameUser);
            this.groupBox1.Controls.Add(this.buttonClearUser);
            this.groupBox1.Controls.Add(this.buttonSaveUser);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelUsername);
            this.groupBox1.Controls.Add(this.textBoxIdUser);
            this.groupBox1.Controls.Add(this.labelIdUser);
            this.groupBox1.Location = new System.Drawing.Point(9, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit User";
            // 
            // textBoxTitleUser
            // 
            this.textBoxTitleUser.Location = new System.Drawing.Point(134, 72);
            this.textBoxTitleUser.Name = "textBoxTitleUser";
            this.textBoxTitleUser.Size = new System.Drawing.Size(97, 21);
            this.textBoxTitleUser.TabIndex = 2;
            // 
            // labelTitleUser
            // 
            this.labelTitleUser.AutoSize = true;
            this.labelTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleUser.Location = new System.Drawing.Point(7, 71);
            this.labelTitleUser.Name = "labelTitleUser";
            this.labelTitleUser.Size = new System.Drawing.Size(43, 15);
            this.labelTitleUser.TabIndex = 18;
            this.labelTitleUser.Text = "Title :";
            // 
            // buttonExitUser
            // 
            this.buttonExitUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitUser.Location = new System.Drawing.Point(133, 187);
            this.buttonExitUser.Name = "buttonExitUser";
            this.buttonExitUser.Size = new System.Drawing.Size(98, 31);
            this.buttonExitUser.TabIndex = 8;
            this.buttonExitUser.Text = "E&xit";
            this.buttonExitUser.UseVisualStyleBackColor = true;
            this.buttonExitUser.Click += new System.EventHandler(this.buttonExitUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUser.Location = new System.Drawing.Point(134, 152);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(98, 31);
            this.buttonUpdateUser.TabIndex = 7;
            this.buttonUpdateUser.Text = "&Update";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // textBoxFullNameUser
            // 
            this.textBoxFullNameUser.Location = new System.Drawing.Point(134, 46);
            this.textBoxFullNameUser.Name = "textBoxFullNameUser";
            this.textBoxFullNameUser.Size = new System.Drawing.Size(97, 21);
            this.textBoxFullNameUser.TabIndex = 1;
            // 
            // labelFullNameUser
            // 
            this.labelFullNameUser.AutoSize = true;
            this.labelFullNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullNameUser.Location = new System.Drawing.Point(6, 44);
            this.labelFullNameUser.Name = "labelFullNameUser";
            this.labelFullNameUser.Size = new System.Drawing.Size(77, 15);
            this.labelFullNameUser.TabIndex = 14;
            this.labelFullNameUser.Text = "Full Name:";
            // 
            // buttonClearUser
            // 
            this.buttonClearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearUser.Location = new System.Drawing.Point(10, 187);
            this.buttonClearUser.Name = "buttonClearUser";
            this.buttonClearUser.Size = new System.Drawing.Size(110, 31);
            this.buttonClearUser.TabIndex = 6;
            this.buttonClearUser.Text = "&Clear";
            this.buttonClearUser.UseVisualStyleBackColor = true;
            this.buttonClearUser.Click += new System.EventHandler(this.buttonClearUser_Click);
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveUser.Location = new System.Drawing.Point(9, 152);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(111, 31);
            this.buttonSaveUser.TabIndex = 5;
            this.buttonSaveUser.Text = "A&dd";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(135, 127);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(97, 21);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(135, 101);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(97, 21);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(7, 128);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 15);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(7, 99);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 15);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "User Name :";
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Location = new System.Drawing.Point(134, 20);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(97, 21);
            this.textBoxIdUser.TabIndex = 0;
            this.textBoxIdUser.TextChanged += new System.EventHandler(this.textBoxIdUser_TextChanged);
            // 
            // labelIdUser
            // 
            this.labelIdUser.AutoSize = true;
            this.labelIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdUser.Location = new System.Drawing.Point(6, 20);
            this.labelIdUser.Name = "labelIdUser";
            this.labelIdUser.Size = new System.Drawing.Size(86, 15);
            this.labelIdUser.TabIndex = 0;
            this.labelIdUser.Text = "ID Number*:";
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameTitle.Location = new System.Drawing.Point(9, 9);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(753, 23);
            this.labelNameTitle.TabIndex = 9;
            this.labelNameTitle.Text = "Hello ";
            this.labelNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMISManager1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 485);
            this.Controls.Add(this.labelNameTitle);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMISManager1";
            this.Text = "Form MIS Manager1";
            this.Load += new System.EventHandler(this.FormMISManager1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxAddEmployee.ResumeLayout(false);
            this.groupBoxAddEmployee.PerformLayout();
            this.tabPageManageUser.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageManageUser;
        private System.Windows.Forms.Button buttonListUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonExitUser;
        private System.Windows.Forms.Button buttonClearUser;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader columnHeaderIDUser;
        private System.Windows.Forms.ColumnHeader columnHeaderFullName;
        private System.Windows.Forms.ColumnHeader columnHeaderUserName;
        private System.Windows.Forms.ColumnHeader columnHeaderPassword;
        private System.Windows.Forms.TextBox textBoxSearchUser;
        private System.Windows.Forms.ComboBox comboBoxSearchUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFullNameUser;
        private System.Windows.Forms.Label labelFullNameUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxIdUser;
        private System.Windows.Forms.Label labelIdUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonListEmp;
        private System.Windows.Forms.Button buttonDeleteEmp;
        private System.Windows.Forms.Button buttonSearchEmp;
        private System.Windows.Forms.Button buttonUpdateEmp;
        private System.Windows.Forms.TextBox textBoxSearchEmp;
        private System.Windows.Forms.ComboBox comboBoxSearchEmp;
        private System.Windows.Forms.GroupBox groupBoxAddEmployee;
        private System.Windows.Forms.TextBox textBoxTitleEmp;
        private System.Windows.Forms.Button buttonExitEmp;
        private System.Windows.Forms.TextBox textBoxLNameEmp;
        private System.Windows.Forms.Button buttonClearEmp;
        private System.Windows.Forms.TextBox textBoxFnameEmp;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Button buttonSaveEmp;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxIDEmp;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.ColumnHeader columnHeaderTitleUser;
        private System.Windows.Forms.TextBox textBoxTitleUser;
        private System.Windows.Forms.Label labelTitleUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSortUser;
        private System.Windows.Forms.ComboBox comboBoxSortEmp;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeadertitle;
        private System.Windows.Forms.Label labelNameTitle;
    }
}