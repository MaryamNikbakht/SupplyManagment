namespace FinalProject1.GUI
{
    partial class FormChangeLogin
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
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogInMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfPass = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitleUser = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullNameUser = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelIdUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxUserName.Location = new System.Drawing.Point(147, 103);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(107, 20);
            this.textBoxUserName.TabIndex = 3;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(12, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 15);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(13, 104);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 15);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "User Name:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.Location = new System.Drawing.Point(147, 133);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(107, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(147, 233);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 26);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogInMain
            // 
            this.buttonLogInMain.AutoSize = true;
            this.buttonLogInMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogInMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogInMain.Location = new System.Drawing.Point(12, 233);
            this.buttonLogInMain.Name = "buttonLogInMain";
            this.buttonLogInMain.Size = new System.Drawing.Size(101, 26);
            this.buttonLogInMain.TabIndex = 6;
            this.buttonLogInMain.Text = "&Submit";
            this.buttonLogInMain.UseVisualStyleBackColor = true;
            this.buttonLogInMain.Click += new System.EventHandler(this.buttonLogInMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirm Password:";
            // 
            // textBoxConfPass
            // 
            this.textBoxConfPass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxConfPass.Location = new System.Drawing.Point(147, 159);
            this.textBoxConfPass.Name = "textBoxConfPass";
            this.textBoxConfPass.PasswordChar = '*';
            this.textBoxConfPass.Size = new System.Drawing.Size(107, 20);
            this.textBoxConfPass.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(147, 71);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(107, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // labelTitleUser
            // 
            this.labelTitleUser.AutoSize = true;
            this.labelTitleUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleUser.Location = new System.Drawing.Point(13, 71);
            this.labelTitleUser.Name = "labelTitleUser";
            this.labelTitleUser.Size = new System.Drawing.Size(43, 15);
            this.labelTitleUser.TabIndex = 24;
            this.labelTitleUser.Text = "Title :";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(147, 44);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.ReadOnly = true;
            this.textBoxFullName.Size = new System.Drawing.Size(107, 20);
            this.textBoxFullName.TabIndex = 1;
            // 
            // labelFullNameUser
            // 
            this.labelFullNameUser.AutoSize = true;
            this.labelFullNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullNameUser.Location = new System.Drawing.Point(12, 44);
            this.labelFullNameUser.Name = "labelFullNameUser";
            this.labelFullNameUser.Size = new System.Drawing.Size(77, 15);
            this.labelFullNameUser.TabIndex = 22;
            this.labelFullNameUser.Text = "Full Name:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(147, 20);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(107, 20);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelIdUser
            // 
            this.labelIdUser.AutoSize = true;
            this.labelIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdUser.Location = new System.Drawing.Point(12, 20);
            this.labelIdUser.Name = "labelIdUser";
            this.labelIdUser.Size = new System.Drawing.Size(86, 15);
            this.labelIdUser.TabIndex = 20;
            this.labelIdUser.Text = "ID Number*:";
            // 
            // FormChangeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 292);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitleUser);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullNameUser);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelIdUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConfPass);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogInMain);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "FormChangeLogin";
            this.Text = "FormChangeLogin";
            this.Load += new System.EventHandler(this.FormChangeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogInMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfPass;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitleUser;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullNameUser;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelIdUser;
    }
}