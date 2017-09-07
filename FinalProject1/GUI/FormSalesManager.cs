using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1.Validation;
using FinalProject1.Business;
using System.Collections.Generic;

namespace FinalProject1.GUI
{
    public partial class FormSalesManager : Form
    {
        List<Client> listClient = new List<Client>();
        public bool AddlistViewClient(List<Client> listClient)
        {
            try
            {
                foreach (Client client in listClient)
                {

                    ListViewItem item = new ListViewItem((client.Id).ToString());
                    item.SubItems.Add(client.Name);
                    item.SubItems.Add(client.FaxNum);
                    item.SubItems.Add(client.Address);
                    item.SubItems.Add(client.City);
                    item.SubItems.Add(client.PostalCod);
                    item.SubItems.Add(client.PhonNum);
                    item.SubItems.Add(client.Email);
                    item.SubItems.Add(client.account);
                    item.SubItems.Add((client.creditLimit).ToString());
                    listViewClientShow.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }

        public FormSalesManager()
        {
            InitializeComponent();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ////textBoxSearchClient.Text = listViewClientShow.SelectedItems[0].SubItems[0].Text;
            ////textBoxIDClient.Text = listViewClientShow.SelectedItems[0].SubItems[0].Text;
            ////textBoxNameClient.Text = listViewClientShow.SelectedItems[0].SubItems[1].Text;
            ////textBoxFaxNumClient.Text = listViewClientShow.SelectedItems[0].SubItems[2].Text;
            ////textBoxStreetClient.Text = listViewClientShow.SelectedItems[0].SubItems[3].Text;
            ////textBoxCityClient.Text = listViewClientShow.SelectedItems[0].SubItems[4].Text;
            ////textBoxPostalCodeClient.Text = listViewClientShow.SelectedItems[0].SubItems[5].Text;
            ////textBoxPhoneClient.Text = listViewClientShow.SelectedItems[0].SubItems[6].Text;
            ////textBoxEmailClient.Text = listViewClientShow.SelectedItems[0].SubItems[7].Text;
            ////textBoxAccount.Text = listViewClientShow.SelectedItems[0].SubItems[8].Text;
            ////textBoxCreditClient.Text = listViewClientShow.SelectedItems[0].SubItems[9].Text;
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
           
            
            
            try
            {
                if (textBoxIDClient.Text == "" || textBoxNameClient.Text == "" || textBoxPhoneClient.Text == ""||textBoxCityClient.Text==""||textBoxEmailClient.Text==""||textBoxFaxNumClient.Text==""||textBoxPostalCodeClient.Text==""||textBoxStreetClient.Text==""||textBoxAccount.Text=="")
                {
                    MessageBox.Show("Please enter all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Checking valid number for id with validator
                else if (!(Validators.IsValidSize(textBoxIDClient.Text.Trim(), 4)))
                {
                    MessageBox.Show("Please enter valid size for id number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!(Validators.IsNumber(textBoxIDClient.Text.Trim())))
                {
                    MessageBox.Show("Please enter just number for Id number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(Validators.IsString(textBoxNameClient.Text)) || !(Validators.IsString(textBoxCityClient.Text)))
                {
                    MessageBox.Show("Please enter just word for name and city!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Client client = new Client();
                    client.Id = Convert.ToInt32(textBoxIDClient.Text);
                    client.Name = textBoxNameClient.Text;
                    client.FaxNum = textBoxFaxNumClient.Text;
                    client.Address = textBoxStreetClient.Text;
                    client.City = textBoxCityClient.Text;
                    client.PhonNum = textBoxPhoneClient.Text;
                    client.PostalCod = textBoxPostalCodeClient.Text;
                    client.Email = textBoxEmailClient.Text;
                    client.account = textBoxAccount.Text;
                    client.creditLimit = Convert.ToInt32(textBoxCreditClient.Text);
                    listClient.Add(client);
                    Client.saveClient(client);
                    Client.writeClient_binary(client);
                    if (Client.ID_Uniq(Convert.ToInt32(textBoxIDClient.Text.Trim())) == true)
                    {
                        MessageBox.Show("This ID already exist! Please enter enother ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Client.Delete_lastLineClient();
                    }
                    else
                    {
                        MessageBox.Show("Data saved successfully!");
                    }
                    clearForm();

                   

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void groupBoxInfoClient_Enter(object sender, EventArgs e)
        {

        }


        public void clearForm()
        {
            textBoxIDClient.Text = "";
            textBoxNameClient.Text = "";
            textBoxFaxNumClient.Text = "";
            textBoxStreetClient.Text = "";
            textBoxCityClient.Text = "";
            textBoxPhoneClient.Text = "";
            textBoxEmailClient.Text = "";
            textBoxPostalCodeClient.Text = "";
            textBoxSearchClient.Text = "";
            textBoxAccount.Text = "";
            textBoxCreditClient.Text="";
            listViewClientShow.Items.Clear();
        }
        private void buttonClearClient_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void buttonExitClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBoxButtonsClient_Enter(object sender, EventArgs e)
        {

        }

        private void FormSalesManager_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            List<Users> searchId = Users.LoadRecord_changePass(f.First_u);

            foreach (Users use in searchId)
            {
                labelTitleName.Text = "Hello " + use.FirstName + use.LastName;


            }
        }

        private void buttonListClient_Click(object sender, EventArgs e)
        {
         
            try
            {

                if (comboBoxSortEmp.Text == "Sort By ID")
                {
                    Comparison<Client> comparison = (x, y) => x.Id.CompareTo(y.Id);
                
                   List<Client> sorted_list = Client.ListAllClients();
                    sorted_list.Sort(comparison);
                    listViewClientShow.Items.Clear();
                    AddlistViewClient(sorted_list);
                }

                else if (comboBoxSortEmp.Text == "Sort By Name")
                {
                    Comparison<Client> comparison = (x, y) => x.Name.CompareTo(y.Name);
                 
                 List<Client> sorted_list = Client.ListAllClients();
                    sorted_list.Sort(comparison);
                    listViewClientShow.Items.Clear();
                    AddlistViewClient(sorted_list);

                }      
            }
            catch
            {
              //  MessageBox.Show("Somthing wrong");
                throw ;
            }
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (comboBoxSearchClient.Text == "Search By Id")
            {
                if (!Validators.IsNumber(textBoxSearchClient.Text) || !Validators.IsValidSize(textBoxSearchClient.Text, 4))
                {
                    MessageBox.Show("Please enter 4 digit number!");

                }
                else
                {
                    List<Client> searchId = Client.SearchClient(Convert.ToInt32(textBoxSearchClient.Text));
                    listViewClientShow.Items.Clear();
                    AddlistViewClient(searchId);
                    found = true;
                }

            }

            else if (comboBoxSearchClient.Text == "Search By Name")
            {
                if (!Validators.IsString(textBoxSearchClient.Text))
                {
                    MessageBox.Show("Please enter letters only!");

                }
                else
                {
                    List<Client> searchId = Client.SearchClient(textBoxSearchClient.Text);
                    listViewClientShow.Items.Clear();
                    AddlistViewClient(searchId);
                    found = true;
                }
            }

            else if (found)
            {
                MessageBox.Show("Data Not Found!");
            }
        }

        private void comboBoxSearchClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this client ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Client.deletLineClient(textBoxSearchClient.Text);
                MessageBox.Show("Client deleted!", "Delet Client");
                clearForm();
            }
         
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            Client.deletLineClient(textBoxSearchClient.Text);

            client.Id = Convert.ToInt32(textBoxIDClient.Text.Trim());
            client.Name = textBoxNameClient.Text;
            client.FaxNum = textBoxFaxNumClient.Text;
            client.Address = textBoxStreetClient.Text;
            client.City = textBoxCityClient.Text;
            client.PhonNum = textBoxPhoneClient.Text;
            client.PostalCod = textBoxPostalCodeClient.Text;
            client.Email = textBoxEmailClient.Text;
            client.account = textBoxAccount.Text;
            client.creditLimit = Convert.ToInt32(textBoxCreditClient.Text);
            listClient.Add(client);
            Client.saveClient(client);
            clearForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (comboBoxSortEmp.Text == "Sort By ID")
                {
                    Comparison<Client> comparison = (x, y) => x.Id.CompareTo(y.Id);

                    List<Client> sorted_list = Client.GetClient_binary();
                    sorted_list.Sort(comparison);
                    listViewClientShow.Items.Clear();
                    AddlistViewClient(sorted_list);
                }

                else if (comboBoxSortEmp.Text == "Sort By Name")
                {
                    Comparison<Client> comparison = (x, y) => x.Name.CompareTo(y.Name);

                    List<Client> sorted_list = Client.GetClient_binary();
                    sorted_list.Sort(comparison);
                    listViewClientShow.Items.Clear();
                    AddlistViewClient(sorted_list);

                }
            }
            catch
            {
                MessageBox.Show("Somethig wrongs!!");
                //throw;
            }
        }

        private void listViewDoubleClickSales(object sender, EventArgs e)
        {
            textBoxSearchClient.Text = listViewClientShow.SelectedItems[0].SubItems[0].Text;
            textBoxIDClient.Text = listViewClientShow.SelectedItems[0].SubItems[0].Text;
            textBoxNameClient.Text = listViewClientShow.SelectedItems[0].SubItems[1].Text;
            textBoxFaxNumClient.Text = listViewClientShow.SelectedItems[0].SubItems[2].Text;
            textBoxStreetClient.Text = listViewClientShow.SelectedItems[0].SubItems[3].Text;
            textBoxCityClient.Text = listViewClientShow.SelectedItems[0].SubItems[4].Text;
            textBoxPostalCodeClient.Text = listViewClientShow.SelectedItems[0].SubItems[5].Text;
            textBoxPhoneClient.Text = listViewClientShow.SelectedItems[0].SubItems[6].Text;
            textBoxEmailClient.Text = listViewClientShow.SelectedItems[0].SubItems[7].Text;
            textBoxAccount.Text = listViewClientShow.SelectedItems[0].SubItems[8].Text;
            textBoxCreditClient.Text = listViewClientShow.SelectedItems[0].SubItems[9].Text;
        }
    }
}
