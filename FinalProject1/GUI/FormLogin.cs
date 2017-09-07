using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1.GUI;
using FinalProject1.Business;
using FinalProject1.Validation;

namespace FinalProject1
{
    public partial class FormLogin : Form
    {
        List<Users> logUser = new List<Users>();

        private static string first_u;
        public static string JOBTITLE_MISMANAGER = "MIS Manager";
        public static string JOBTITLE_SALESMANAGER = "Sales Manager";
        public static string JOBTITLE_INVENTORYCONTROLLER = "Inventory Controller";
        public static string JOBTITLE_ORDERCLERKS = "Order Clerks";

        public  string First_u
        {
            get
            {
                return first_u;
            }

        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
        private void linkLabelChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool res = Users.changePass_user(textBoxUserName.Text, textBoxPassword.Text);
            
            if ( res== true)
            {
               first_u = textBoxUserName.Text;
                FormChangeLogin change = new FormChangeLogin();               
                change.ShowDialog();
                textBoxPassword.Clear();
                textBoxUserName.Clear();

            }
            else
            {               
                MessageBox.Show("Please enter Correct username and password!");
            }

        }
        /// <summary>
        /// Login(Button -> Login)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogInMain_Click(object sender, EventArgs e)
        {
            first_u = textBoxUserName.Text;
            string res = Users.loginSearch(textBoxUserName.Text, textBoxPassword.Text);

            if (textBoxPassword.Text == "" || textBoxUserName.Text == "")
            {
                MessageBox.Show("Enter username and password!", "NOT VALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (res == JOBTITLE_MISMANAGER)
            {
                FormMISManager1 misMgr = new FormMISManager1();
                this.Hide();
                misMgr.ShowDialog();
                textBoxPassword.Clear();
                textBoxUserName.Clear();
                
            }
            else if (res == JOBTITLE_SALESMANAGER)
            {
                FormSalesManager saleMgr = new FormSalesManager();
                this.Hide();
                saleMgr.ShowDialog();
                textBoxPassword.Clear();
                textBoxUserName.Clear();
            }

            else if (res == JOBTITLE_INVENTORYCONTROLLER)
            {
                FormInventoryController invMgr = new FormInventoryController();
                this.Hide();
                invMgr.ShowDialog();
                textBoxPassword.Clear();
                textBoxUserName.Clear();
            }

            else if (res == JOBTITLE_ORDERCLERKS)
            {
                first_u = textBoxUserName.Text;             
              

                FormClercks clerck = new FormClercks();
                this.Hide();
                clerck.ShowDialog();
                textBoxPassword.Clear();
                textBoxUserName.Clear();
            }

           
            else 
            {
                MessageBox.Show("Enter valid username and password!", "NOT VALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Clear();
                textBoxUserName.Clear();
                textBoxUserName.Focus();
            }


}

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            textBoxUserName.Focus();
          
        }
        /// <summary>
        /// Exit from App
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if
           (MessageBox.Show("Are you sure you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
