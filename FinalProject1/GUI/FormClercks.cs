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
    public partial class FormClercks : Form
    {

        public static List<Client> listClients = new List<Client>();
        public static List<Software> listSofwars = new List<Software>();
        public static List<Book> listBooks = new List<Book>();
          public static List<Order> listOrders = new List<Order>();
        private Product p;

        public void clear_form_Order()
        {
          //  textBoxFnameClient.Text = "";
         //   textBoxPhoneClient.Text = "";
         //   textBoxClientAccount.Text = "";
         //   textBoxClientOrder.Text = "";
            textBoxItemID.Text = "";
            textBoxQuantityOrder.Text = "";
         
            textBoxUnitPrice.Text = "";

            textBoxDescOrder.Text = "";
            textBoxSubTotalOrder.Text = "";
            listViewOrder.Items.Clear();
            listViewSearchBook.Items.Clear();
            listViewSearchSoftware.Items.Clear();
            comboBoxClientOrder.Text = "";
            dateTimePickerOrderBook.Text = "";
            dateTimePickerShippingDate.Text = "";
            dateTimePickerOrderRequieredSoft.Text = "";
            textBoxOrderIdSoftware.Text = "";
            textBoxOrderIDBook.Text = "";
            
            //  textBoxsearcchPro.Text = "";
            textBoxSearchOrder.Text = "";
            //  listViewProduct.Items.Clear();
            //  comboBoxSearchCategory.Text = "";
            comboBoxSearchOrder.Text = "";
            comboBoxStatusBook.Text = "";
            comboBoxStatusSoftware.Text = "";
            


        }

        public bool AddlistViewOrder(List<Order> order)
        {

            try
            {
                foreach (Order ord in order)
                {
                    if(ord.TitleOrder.ToString()=="book")
                    {
                        ListViewItem item = new ListViewItem((ord.OrderId).ToString());

                        item.SubItems.Add(ord.Book.ProductID);
                        item.SubItems.Add(ord.Book.ProductName);
                        item.SubItems.Add(ord.Client.Name);
                        item.SubItems.Add((ord.Book.UnitPrice).ToString());

                        item.SubItems.Add((ord.Amount).ToString());
                        item.SubItems.Add((ord.Total1).ToString());
                        item.SubItems.Add((ord.RequiredDate).ToString());
                        item.SubItems.Add((ord.ShippingDate).ToString());
                        item.SubItems.Add((ord.TitleOrder).ToString());
                        item.SubItems.Add((ord.Status).ToString());
                        listViewOrder.Items.Add(item);
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem((ord.OrderId).ToString());

                        item.SubItems.Add(ord.Software.ProductID);
                        item.SubItems.Add(ord.Software.ProductName);
                        item.SubItems.Add(ord.Client.Name);
                        item.SubItems.Add((ord.Software.UnitPrice).ToString());

                        item.SubItems.Add((ord.Amount).ToString());
                        item.SubItems.Add((ord.Total1).ToString());
                        item.SubItems.Add((ord.RequiredDate).ToString());
                        item.SubItems.Add((ord.ShippingDate).ToString());
                        item.SubItems.Add((ord.TitleOrder).ToString());
                        item.SubItems.Add((ord.Status).ToString());
                        listViewOrder.Items.Add(item);
                    }
                    
                    

                }
                return true;
            }
            catch
            {

                return false;
            }
        }


        public bool AddlistViewSearchBook(List<Book> books)
        {

            try
            {
                foreach (Book book in books)
                {

                    ListViewItem item = new ListViewItem(book.ProductID);

                    item.SubItems.Add(book.ProductName);
                    item.SubItems.Add((book.UnitPrice).ToString());

                    item.SubItems.Add((book.AmountInStock).ToString());
                    item.SubItems.Add(book.BookType);


                    listViewSearchBook.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }


        public bool AddlistViewSearchSoftware(List<Software> softs)
        {

            try
            {
                foreach (Software soft in softs)
                {

                    ListViewItem item = new ListViewItem(soft.ProductID);

                    item.SubItems.Add(soft.ProductName);
                    item.SubItems.Add((soft.UnitPrice).ToString());

                    item.SubItems.Add((soft.AmountInStock).ToString());
                    item.SubItems.Add(soft.SoftwareType);


                    listViewSearchSoftware.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }
        public FormClercks()
        {
            InitializeComponent();
        }

        private void FormClercks_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            textBoxEmpID.Text = f.First_u;

            List<Users> searchId = Users.LoadRecord_changePass(f.First_u);

            foreach (Users use in searchId)
            {
                textBoxEmpName.Text = use.FirstName + use.LastName;


            }
        }

        private void textBoxFnameClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIDClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelIdProduct_Click(object sender, EventArgs e)
        {

        }

        private void listViewClientShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitleProduct_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void labelEnterChoiceOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonListAllOrder_Click(object sender, EventArgs e)
        {
            try
            {
               
                    listOrders = Order.ListAllOrders();
                    listViewOrder.Items.Clear();

                    AddlistViewOrder(listOrders);
                
            }
            catch (Exception)
            {

                throw;
            }
          
         
        }

        private void dateTimePickerClientDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetInoClient_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxClientOrder.Text == "Order By FaxnNmber")
                {

                    List<Client> client = Client.SearchClient(textBoxClientOrder.Text);
                    foreach (Client c1 in client)
                    {
                        textBoxFnameClient.Text = c1.Name;
                        textBoxPhoneClient.Text = c1.PhonNum;
                        textBoxClientAccount.Text = c1.Account;

                    }

                }

                else if (comboBoxClientOrder.Text == "Order By PhonNumber")
                {
                    List<Client> client = Client.SearchClient(textBoxClientOrder.Text);
                    foreach (Client c1 in client)
                    {
                        textBoxFnameClient.Text = c1.Name;
                        textBoxPhoneClient.Text = c1.PhonNum;
                        textBoxClientAccount.Text = c1.Account;

                    }

                }


                else if (comboBoxClientOrder.Text == "Order By E-mail")
                {
                    List<Client> client = Client.SearchClient(textBoxClientOrder.Text);
                    foreach (Client c1 in client)
                    {
                        textBoxFnameClient.Text = c1.Name;
                        textBoxPhoneClient.Text = c1.PhonNum;
                        textBoxClientAccount.Text = c1.Account;

                    }

                }


            }
            catch
            {
                //  MessageBox.Show("Somthing wrong");
                throw;
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            Order ord = new Order();
            try
            {
                
                    if (tabControlOrderDetails.SelectedIndex == 0)
                    {
                        textBoxSubTotalOrder.Text = (Convert.ToDouble(textBoxUnitPrice.Text) * Convert.ToDouble(textBoxQuantityOrder.Text)).ToString();


                        if (MessageBox.Show("Do you want to cancel this order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                                                     
                            Order.deletOrder_line(textBoxOrderIDBook.Text);

                            Book book = new Book();
                            Client c = new Client();

                            book.ProductID = textBoxItemID.Text;
                            book.ProductName = textBoxDescOrder.Text;
                            c.Name = textBoxFnameClient.Text;
                            ord.Client = c;
                            book.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
                            ord.Book = book;

                            ord.Amount = Convert.ToDouble(textBoxQuantityOrder.Text);
                            ord.Total1 = Convert.ToDouble(textBoxSubTotalOrder.Text);

                            ord.RequiredDate = Convert.ToDateTime(dateTimePickerOrderBook.Value.Date);
                            dateTimePickerShippingDate.Value = dateTimePickerOrderBook.Value.Date.AddDays(-1);
                            ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Value);

                            //  ord.Status = comboBoxStatusBook.Text;
                            ord.Status = "Cancel Order";

                            listOrders.Add(ord);

                            Order.saveRecordBook(ord);
                            clear_form_Order();

                            //Order.deletOrder_line(textBoxRowCancel.Text);
                            //MessageBox.Show("order canceled!", "Cancel");
                            //clear_form_Order();

                        }
                    }
                    else if(tabControlOrderDetails.SelectedIndex == 1)
                    {
                        textBoxSubTotalOrderSoft.Text = (Convert.ToDouble(textBoxUnitPriceSoft.Text) * Convert.ToDouble(textBoxQOHOrderSoft.Text)).ToString();

                        if (MessageBox.Show("Do you want to cancel this order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Order.deletOrder_line(textBoxOrderIdSoftware.Text);
                            Software soft = new Software();
                            Client c = new Client();

                            soft.ProductID = textBoxItemOrderSoft.Text;
                            soft.ProductName = textBoxDescOrderSoft.Text;
                            soft.UnitPrice = Convert.ToDouble(textBoxUnitPriceSoft.Text);
                            ord.Software = soft;
                            c.Name = textBoxFnameClient.Text;
                            ord.Client = c;
                            ord.Amount = Convert.ToDouble(textBoxQOHOrderSoft.Text);
                            ord.Total1 = Convert.ToDouble(textBoxSubTotalOrderSoft.Text);


                            ord.RequiredDate = Convert.ToDateTime(dateTimePickerOrderRequieredSoft.Value.Date);
                            dateTimePickerShippingDate.Value = dateTimePickerOrderRequieredSoft.Value.Date.AddDays(-1);
                            ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Value);
                            // ord.Status = comboBoxStatusBook.Text;
                            ord.Status = "Cancel Order";

                            listOrders.Add(ord);

                            Order.saveRecordSoftware(ord);
                            clear_form_Order();

                        }                



                }
              
            }
            catch
            {

                throw;
            }

           
        }

        private void buttonClearOrderDetails_Click(object sender, EventArgs e)
        {
            clear_form_Order();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {



        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {

            bool found = false;
            if (comboBoxSearchBook.Text == "Search By Name")
            {
                if (!Validators.IsString(textBoxSearchBook.Text))
                {
                    MessageBox.Show("Please enter correct value!");

                }
                else
                {
                    List<Book> searchId = Order.Search_orderbook(textBoxSearchBook.Text);

                    listViewSearchBook.Items.Clear();
                    AddlistViewSearchBook(searchId);
                    found = true;
                }

            }

            else if (comboBoxSearchBook.Text == "Search By ID")
            {
                
                    List<Book> searchId = Order.Search_orderbook(textBoxSearchBook.Text);

                    listViewSearchBook.Items.Clear();
                    AddlistViewSearchBook(searchId);
                    found = true;
                
            }

           
            else if(comboBoxSearchBook.Text == "All Books")
            {
               
                   List<Book> searchId = Order.ListBooks_order();

                    listViewSearchBook.Items.Clear();
                    AddlistViewSearchBook(searchId);
                    found = true;
                
                
            }

            else 
            {
                MessageBox.Show("Data Not Found!");
            }

        }

        private void listViewSearchSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxItemOrderSoft.Text = listViewSearchSoftware.SelectedItems[0].SubItems[0].Text;
            textBoxDescOrderSoft.Text = listViewSearchSoftware.SelectedItems[0].SubItems[1].Text;
            textBoxUnitPriceSoft.Text = listViewSearchSoftware.SelectedItems[0].SubItems[2].Text;
        }

        private void buttonSearchSoftware_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (comboBoxSearchSoftware.Text == "Search By Name")
            {
                if (!Validators.IsString(textBoxSearchSoftware.Text))
                {
                    MessageBox.Show("Please enter correct value!");

                }
                else
                {
                    List<Software> searchId = Order.Search_OrderSoftware(textBoxSearchSoftware.Text);

                    listViewSearchSoftware.Items.Clear();
                    AddlistViewSearchSoftware(searchId);
                    found = true;
                }

            }

            else if (comboBoxSearchSoftware.Text == "Search By ID")
            {
              
                    List<Software> searchId = Order.Search_OrderSoftware(textBoxSearchSoftware.Text);

                    listViewSearchSoftware.Items.Clear();
                    AddlistViewSearchSoftware(searchId);
                    found = true;
                
            }

            else if (comboBoxSearchSoftware.Text == "All Softwares")
            {

                List<Software> searchId = Order.ListSoftware_order();

                listViewSearchSoftware.Items.Clear();
                AddlistViewSearchSoftware(searchId);
                found = true;


            }

            else if (found)
            {
                MessageBox.Show("Data Not Found!");
            }
        }

        private void listViewSearchBook_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBoxItemID.Text = listViewSearchBook.SelectedItems[0].SubItems[0].Text;
            textBoxDescOrder.Text = listViewSearchBook.SelectedItems[0].SubItems[1].Text;
            textBoxUnitPrice.Text = listViewSearchBook.SelectedItems[0].SubItems[2].Text;
           

        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            
            textBoxSubTotalOrder.Text = (Convert.ToDouble(textBoxUnitPrice.Text) * Convert.ToDouble(textBoxQuantityOrder.Text)).ToString();
            

            try
            {
                if (textBoxUnitPrice.Text == "" || textBoxQuantityOrder.Text == "" || textBoxDescOrder.Text == "" || textBoxItemID.Text == "")
                {
                    MessageBox.Show("Please enter all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxClientOrder.Text=="")
                {
                    MessageBox.Show("Please enter identification of client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

                else if ((Order.processQohBook(Convert.ToDouble(textBoxQuantityOrder.Text), textBoxItemID.Text)) ==false)
                {
                    MessageBox.Show("There is not enough amount in inventory!");
                }
          

                else
                { 
                    Order ord = new Order();
                    //   Product p= new Product();
                    Book book = new Book();
                    Client c = new Client();
                    ord.OrderId = Convert.ToDouble(textBoxOrderIDBook.Text);
                    book.ProductID = textBoxItemID.Text;
                    book.ProductName = textBoxDescOrder.Text;
                    c.Name = textBoxFnameClient.Text;
                    ord.Client = c;
                    book.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
                    ord.Book = book;
           
                    ord.Amount = Convert.ToDouble(textBoxQuantityOrder.Text);
                    ord.Total1 = Convert.ToDouble(textBoxSubTotalOrder.Text);

                    ord.RequiredDate =Convert.ToDateTime(dateTimePickerOrderBook.Value.Date);
                    dateTimePickerShippingDate.Value = dateTimePickerOrderBook.Value.Date.AddDays(-1);
                    ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Value);
                    ord.Status = comboBoxStatusBook.Text;

                    listOrders.Add(ord);
                   
                    Order.saveRecordBook(ord);
                    clear_form_Order();
                }
            }
            catch
            {
                throw;
            }


        }
        
        private void textBoxSubTotalOrder_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonSaveOrderSoft_Click(object sender, EventArgs e)
        {
            textBoxSubTotalOrderSoft.Text = (Convert.ToDouble(textBoxUnitPriceSoft.Text) * Convert.ToDouble(textBoxQOHOrderSoft.Text)).ToString();

            try
            {
                if (textBoxItemOrderSoft.Text == "" || textBoxDescOrderSoft.Text == "" || textBoxUnitPriceSoft.Text == "" || textBoxQOHOrderSoft.Text == "")
                {
                    MessageBox.Show("Please enter all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if(textBoxClientOrder.Text=="")
                {
                    MessageBox.Show("Please enter identification of client!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Checking valid number for id with validator
                else if (!(Validators.IsNumber(textBoxQOHOrderSoft.Text.Trim())))
                {
                    MessageBox.Show("Please enter number for QOH!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {

                    Order ord = new Order();
                    Software soft = new Software();
                    Client c = new Client();
                    ord.OrderId = Convert.ToDouble(textBoxOrderIdSoftware.Text);
                    soft.ProductID = textBoxItemOrderSoft.Text;
                    soft.ProductName = textBoxDescOrderSoft.Text;
                    soft.UnitPrice = Convert.ToDouble(textBoxUnitPriceSoft.Text);
                    ord.Software = soft;
                    c.Name = textBoxFnameClient.Text;
                    ord.Client = c;
                    ord.Amount = Convert.ToDouble(textBoxQOHOrderSoft.Text);
                    ord.Total1 = Convert.ToDouble(textBoxSubTotalOrderSoft.Text);


                    ord.RequiredDate = Convert.ToDateTime(dateTimePickerOrderRequieredSoft.Value.Date);
                    dateTimePickerShippingDate.Value = dateTimePickerOrderRequieredSoft.Value.Date.AddDays(-1);
                    ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Value);
                    ord.Status = comboBoxStatusBook.Text;

                    listOrders.Add(ord);

                    Order.saveRecordSoftware(ord);
                    clear_form_Order();

                }
            }
            catch
            {
                throw;
            }
        }

        private void comboBoxSearchSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (comboBoxSearchOrder.Text == "Search By ISBN/ID")
            {
               
                    List<Order> searchId = Order.Search_orders(textBoxSearchOrder.Text);
                    listViewOrder.Items.Clear();
                    AddlistViewOrder(searchId);
                    found = true;
               

            }

            else if (comboBoxSearchOrder.Text == "Search By Title")
            {

                List<Order> searchId = Order.Search_orders(textBoxSearchOrder.Text);
                listViewOrder.Items.Clear();
                AddlistViewOrder(searchId);
                found = true;
               
            }
            else if (comboBoxSearchOrder.Text == "Search By Client")
            {

                List<Order> searchId = Order.Search_orders(textBoxSearchOrder.Text);
                listViewOrder.Items.Clear();
                AddlistViewOrder(searchId);
                found = true;

            }
            else if (found)
            {
                MessageBox.Show("Data Not Found!");
            }
        }

        private void buttonExitOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           //bool found = false;
           // if (listViewOrder.SelectedItems[0].SubItems[8].Text=="book")
           // {
                            
                
           //     textBoxSearchOrder.Text = listViewOrder.SelectedItems[0].SubItems[0].Text;
           //     textBoxItemID.Text = listViewOrder.SelectedItems[0].SubItems[0].Text;
           //     textBoxDescOrder.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
           //     textBoxFnameClient.Text = listViewOrder.SelectedItems[0].SubItems[2].Text;
           //     textBoxUnitPrice.Text = listViewOrder.SelectedItems[0].SubItems[3].Text;
           //     textBoxQuantityOrder.Text = listViewOrder.SelectedItems[0].SubItems[4].Text;
           //   //  textBoxSubTotalOrder.Text = listViewOrder.SelectedItems[0].SubItems[5].Text;
           //     dateTimePickerOrderBook.Value= Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[6].Text);
           //     dateTimePickerShippingDate.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[7].Text);
           //     found = true;
           // }

           
           // else if (listViewOrder.SelectedItems[0].SubItems[8].Text == "software")
           // {


           //     textBoxSearchOrder.Text = listViewOrder.SelectedItems[0].SubItems[0].Text;
           //     textBoxItemOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[0].Text;
           //     textBoxDescOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
           //     textBoxFnameClient.Text = listViewOrder.SelectedItems[0].SubItems[2].Text;
           //     textBoxUnitPriceSoft.Text = listViewOrder.SelectedItems[0].SubItems[3].Text;
           //     textBoxQOHOrderSoft.Text= listViewOrder.SelectedItems[0].SubItems[4].Text;
           //  //   textBoxSubTotalOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[5].Text;               
           //     dateTimePickerOrderRequieredSoft.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[6].Text);
           //     dateTimePickerShippingDate.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[7].Text);
           //     found = true;
           // }
        }

        private void buttonDeleteOrderSoft_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this order?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Order.deletOrder_line(textBoxOrderIdSoftware.Text);
                MessageBox.Show("Item deleted!", "Delete");
                clear_form_Order();

            }
        }

        private void buttonUpdate1_Click(object sender, EventArgs e)
        {
            textBoxSubTotalOrder.Text = (Convert.ToDouble(textBoxUnitPrice.Text) * Convert.ToDouble(textBoxQuantityOrder.Text)).ToString();

            Order ord = new Order();
            Order.deletOrder_line(textBoxOrderIDBook.Text);

            Book book = new Book();
            Client c = new Client();
            ord.OrderId = Convert.ToDouble(textBoxOrderIDBook.Text);
            book.ProductID = textBoxItemID.Text;
            book.ProductName = textBoxDescOrder.Text;
            c.Name = textBoxFnameClient.Text;
            ord.Client = c;
            book.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
            ord.Book = book;

            ord.Amount = Convert.ToDouble(textBoxQuantityOrder.Text);
            ord.Total1 = Convert.ToDouble(textBoxSubTotalOrder.Text);

            ord.RequiredDate = Convert.ToDateTime(dateTimePickerOrderBook.Value.Date);
            dateTimePickerShippingDate.Value = dateTimePickerOrderBook.Value.Date.AddDays(-1);
            ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Value);
            ord.Status = comboBoxStatusBook.Text;

            listOrders.Add(ord);

            Order.saveRecordBook(ord);
            clear_form_Order();
        }

        private void buttonUpdateOrderSoft_Click(object sender, EventArgs e)
        {
            textBoxSubTotalOrderSoft.Text = (Convert.ToDouble(textBoxUnitPriceSoft.Text) * Convert.ToDouble(textBoxQOHOrderSoft.Text)).ToString();


            Order.deletOrder_line(textBoxOrderIdSoftware.Text);

            Order ord = new Order();
            Software soft = new Software();
            Client c = new Client();
            ord.OrderId = Convert.ToDouble(textBoxOrderIdSoftware.Text);
            soft.ProductID = textBoxItemOrderSoft.Text;
            soft.ProductName = textBoxDescOrderSoft.Text;
            soft.UnitPrice = Convert.ToDouble(textBoxUnitPriceSoft.Text);
            ord.Software = soft;
            c.Name = textBoxFnameClient.Text;
            ord.Client = c;
            ord.Amount = Convert.ToDouble(textBoxQOHOrderSoft.Text);
            ord.Total1 = Convert.ToDouble(textBoxSubTotalOrderSoft.Text);


            ord.RequiredDate = Convert.ToDateTime(dateTimePickerOrderRequieredSoft.Value.Date);
            dateTimePickerShippingDate.Value = dateTimePickerOrderRequieredSoft.Value.Date.AddDays(-1);
            ord.ShippingDate = Convert.ToDateTime(dateTimePickerShippingDate.Value);
            ord.Status = comboBoxStatusBook.Text;

            listOrders.Add(ord);

            Order.saveRecordSoftware(ord);
            clear_form_Order();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void columnClickListView(object sender, ColumnClickEventArgs e)
        {
        
        }

        private void clickListView(object sender, EventArgs e)
        {
            bool found = false;
            if (listViewOrder.SelectedItems[0].SubItems[9].Text == "book")
            {
                tabControlOrderDetails.SelectedIndex = 0;

                textBoxSearchOrder.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
                textBoxItemID.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
                textBoxDescOrder.Text = listViewOrder.SelectedItems[0].SubItems[2].Text;
                textBoxFnameClient.Text = listViewOrder.SelectedItems[0].SubItems[3].Text;
                textBoxUnitPrice.Text = listViewOrder.SelectedItems[0].SubItems[4].Text;
                textBoxQuantityOrder.Text = listViewOrder.SelectedItems[0].SubItems[5].Text;
                  textBoxSubTotalOrder.Text = listViewOrder.SelectedItems[0].SubItems[6].Text;
                dateTimePickerOrderBook.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[7].Text);
                dateTimePickerShippingDate.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[8].Text);
                textBoxOrderIDBook.Text = listViewOrder.SelectedItems[0].SubItems[0].Text;
            
                found = true;
            }


            else if (listViewOrder.SelectedItems[0].SubItems[9].Text == "software")
            {
                tabControlOrderDetails.SelectedIndex = 1;

                textBoxSearchOrder.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
                textBoxItemOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
                textBoxDescOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[2].Text;
                textBoxFnameClient.Text = listViewOrder.SelectedItems[0].SubItems[3].Text;
                textBoxUnitPriceSoft.Text = listViewOrder.SelectedItems[0].SubItems[4].Text;
                textBoxQOHOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[5].Text;
                textBoxSubTotalOrderSoft.Text = listViewOrder.SelectedItems[0].SubItems[6].Text;
                dateTimePickerOrderRequieredSoft.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[7].Text);
                dateTimePickerShippingDate.Value = Convert.ToDateTime(listViewOrder.SelectedItems[0].SubItems[8].Text);

                textBoxOrderIdSoftware.Text= listViewOrder.SelectedItems[0].SubItems[0].Text;
         
                found = true;
            }
        }

        private void buttonClearOrderSoft_Click(object sender, EventArgs e)
        {
            clear_form_Order();
        }
    }
}
