using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1;
using FinalProject1.Business;
using FinalProject1.GUI;

using FinalProject1.Validation;

namespace FinalProject1.GUI
{
    public partial class FormChangeLogin : Form
    {
        public FormChangeLogin()
        {
            InitializeComponent();
        }

        private void FormChangeLogin_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            textBoxUserName.Text = f.First_u;

            List<Users> searchId = Users.LoadRecord_changePass(f.First_u);

            foreach (Users use in searchId)
            {
                textBoxFullName.Text = use.FirstName;
                textBoxId.Text = use.Id.ToString();
                textBoxTitle.Text = use.Title;          
                
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if
          (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            textBoxUserName.Focus();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void buttonLogInMain_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users.deletLine_user(textBoxId.Text);

            user.Id = Convert.ToInt32(textBoxId.Text.Trim());
            user.FirstName = textBoxFullName.Text;
            user.Title = textBoxTitle.Text;
            user.UserName = textBoxUserName.Text;
            user.Password = textBoxPassword.Text;
           
            Users.SaveUsers(user);

            textBoxFullName.Text="";
            textBoxTitle.Text="";
            textBoxUserName.Text="";
            textBoxId.Text="";
            textBoxPassword.Text = "";
            textBoxConfPass.Text = "";
            this.Close();

        }
    }
}
