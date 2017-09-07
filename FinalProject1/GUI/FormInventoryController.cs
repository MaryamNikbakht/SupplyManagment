using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject1.Business;
using FinalProject1.Validation;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FinalProject1;

namespace FinalProject1.GUI
{
    public partial class FormInventoryController : Form
    {
       public static List<Book> listbooks = new List<Book>();
        public static List<Software> listSofwars = new List<Software>();

        public void clear_form_book()
        {
            textBoxIDBook.Text="";
            textBoxTitleBook.Text="";
            textBoxPriceBook.Text="";
            textBoxYearPubProduct.Text="";
            textBoxQohBook.Text="";
            comboBoxCategoryBook.Text="";
            textBoxAuthoeID.Text="";
            textBoxAuthorFname.Text="";
            textBoxAuthorLname.Text="";            
            comboBoxPublisherBook.Text="";
            listViewProductBook.Items.Clear();
            textBoxSearchProduct.Text = "";
            textBoxIDBook.Focus();

        }

        public void clear_form_Software()
        {
            textBoxIDSoftware.Text = "";
            textBoxQOHSoft.Text = "";
            textBoxSearchSoft.Text = "";
            textBoxTitleSoftware.Text = "";
            textBoxUnitPriceSoft.Text = "";
            comboBoxCategorySoft.Text = "";
            comboBoxPublisherSoft.Text = "";
            comboBoxSearchSoft.Text = "";
         
            listViewSoftware.Items.Clear();

            textBoxIDSoftware.Focus();

        }
        public bool AddlistViewBook(List<Book> listbook)
        {
            try
            {
                foreach (Book book in listbook)
                {
                  //  Author a = new Author();
                    ListViewItem item = new ListViewItem(book.ProductID); 
                
                    item.SubItems.Add(book.ProductName);
                    item.SubItems.Add((book.UnitPrice).ToString());
                    item.SubItems.Add(book.YearOfPublish);
                    item.SubItems.Add((book.AmountInStock).ToString());
                    item.SubItems.Add(book.BookType);
                    item.SubItems.Add((book.Author.Id).ToString());
                    item.SubItems.Add(book.Author.FirstName);
                    item.SubItems.Add(book.Author.LastName);
                  //  book.Author = a;
                    item.SubItems.Add(book.Publisher);
                    listViewProductBook.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool AddlistViewSoftware(List<Software> listSoftware)
        {
            try
            {
                foreach (Software soft in listSoftware)
                {
                   
                    ListViewItem item = new ListViewItem(soft.ProductID);

                    item.SubItems.Add(soft.ProductName);
                    item.SubItems.Add((soft.UnitPrice).ToString());                 
                    item.SubItems.Add((soft.AmountInStock).ToString());
                    item.SubItems.Add(soft.SoftwareType);
                    item.SubItems.Add(soft.Publisher);                    
        
                    listViewSoftware.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }

        public FormInventoryController()
        {
            InitializeComponent();
        }

        private void labelIdProduct_Click(object sender, EventArgs e)
        {

        }

        private void labelTitleProduct_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAuthoeID.Text == "" || textBoxIDBook.Text == "" || textBoxPriceBook.Text == "" || textBoxTitleBook.Text == "" || textBoxPriceBook.Text == "")
                {
                    MessageBox.Show("Please enter all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Checking valid number for id with validator
                else if (!(Validators.IsValidSize(textBoxIDBook.Text.Trim(), 4)))
                {
                    MessageBox.Show("Please enter valid size for ISBN number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!(Validators.IsNumber(textBoxAuthoeID.Text.Trim())))
                {
                    MessageBox.Show("Please enter just number for AuthorID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             

                else
                {
                   
                 
                    Book book = new Book();
                    Author a = new Author();
              
                    book.ProductID = textBoxIDBook.Text;
                    book.ProductName = textBoxTitleBook.Text;
                    book.UnitPrice = Convert.ToDouble(textBoxPriceBook.Text);
                    book.YearOfPublish = textBoxYearPubProduct.Text;
                    book.AmountInStock = Convert.ToDouble(textBoxQohBook.Text);
                    book.BookType = comboBoxCategoryBook.Text;
                    a.Id = Convert.ToInt32(textBoxAuthoeID.Text);
                    a.FirstName = textBoxAuthorFname.Text;
                    a.LastName = textBoxAuthorLname.Text;
               
                    book.Publisher = comboBoxPublisherBook.Text;
                    
                    book.Author = a;
                    listbooks.Add(book);
                  
                     Book.saveRecord_text(book);

                    if (Book.ID_Validation_Uniq_ISBN(textBoxIDBook.Text.Trim()) == true)
                    {
                        MessageBox.Show("This ID already exist! Please enter enother ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Book.Delete_lastLineBook();
                    }
                    else
                    {

                        MessageBox.Show("Data saved successfully!");
                    }
                    clear_form_book();
                }
            }
            catch
            {
                throw;
            }
        }

        private void serializationObjects(Book book)
        {
            throw new NotImplementedException();
        }

        private void buttonSaveSoft_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDSoftware.Text == "" || textBoxQOHSoft.Text == "" || textBoxTitleSoftware.Text == "" || textBoxUnitPriceSoft.Text == "" || comboBoxCategorySoft.Text == ""||comboBoxPublisherSoft.Text=="")
                {
                    MessageBox.Show("Please enter all information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Checking valid number for id with validator
                else if (!(Validators.IsValidSize(textBoxIDSoftware.Text.Trim(), 4)))
                {
                    MessageBox.Show("Please enter valid size for ID number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               


                else
                {


                    Software soft = new Software();

                    soft.ProductID = textBoxIDSoftware.Text;
                    soft.ProductName = textBoxTitleSoftware.Text;
                    soft.UnitPrice = Convert.ToDouble(textBoxUnitPriceSoft.Text);
                    soft.AmountInStock = Convert.ToDouble(textBoxQOHSoft.Text);
                    soft.SoftwareType = comboBoxCategorySoft.Text;

                    soft.Publisher = comboBoxPublisherSoft.Text;
                   
                    listSofwars.Add(soft);
                 
                    Software.saveRecord_text(soft);

                    if (Software.ID_Uniq_soft(textBoxIDSoftware.Text.Trim()) == true)
                    {
                        MessageBox.Show("This ID already exist! Please enter enother ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Software.Delete_lastLineSoft();
                    }
                    else
                    {

                        MessageBox.Show("Data saved successfully!");
                    }
                    clear_form_Software();
                }
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonListProduct_Click(object sender, EventArgs e)
        {
            Comparison<Book> comparison = (x, y) => x.ProductID.CompareTo(y.ProductID);

            List<Book> sorted_list = Book.ListAll_Books();
             sorted_list.Sort(comparison);
            listViewProductBook.Items.Clear();
            AddlistViewBook(sorted_list);       
         
        }

        private void buttonClearProduct_Click(object sender, EventArgs e)
        {
            clear_form_book();
        }

        private void buttonExitProduct_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonExitSoft_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Book.delete_book(textBoxIDBook.Text);
                MessageBox.Show("product deleted!", "Delete Product");
                clear_form_book();
            }
        }

        private void listViewProductBook_SelectedIndexChanged(object sender, EventArgs e)
        {

            //textBoxSearchProduct.Text = listViewProductBook.SelectedItems[0].SubItems[0].Text;
            //textBoxIDBook.Text = listViewProductBook.SelectedItems[0].SubItems[0].Text;
            //textBoxTitleBook.Text = listViewProductBook.SelectedItems[0].SubItems[1].Text;
            //textBoxPriceBook.Text = listViewProductBook.SelectedItems[0].SubItems[2].Text;
            //textBoxYearPubProduct.Text = listViewProductBook.SelectedItems[0].SubItems[3].Text;
            //textBoxQohBook.Text = listViewProductBook.SelectedItems[0].SubItems[4].Text;
            //comboBoxCategoryBook.Text = listViewProductBook.SelectedItems[0].SubItems[5].Text;
            //textBoxAuthoeID.Text = listViewProductBook.SelectedItems[0].SubItems[6].Text;
            //textBoxAuthorFname.Text = listViewProductBook.SelectedItems[0].SubItems[7].Text;
            //textBoxAuthorLname.Text = listViewProductBook.SelectedItems[0].SubItems[8].Text;
            //comboBoxPublisherBook.Text = listViewProductBook.SelectedItems[0].SubItems[9].Text;
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            Author a = new Author();
            Book.delete_book(textBoxSearchProduct.Text);         
           
            book.ProductID = textBoxIDBook.Text;
            book.ProductName = textBoxTitleBook.Text;
            book.UnitPrice = Convert.ToDouble(textBoxPriceBook.Text);
            book.YearOfPublish = textBoxYearPubProduct.Text;
            book.AmountInStock = Convert.ToDouble(textBoxQohBook.Text);
            book.BookType = comboBoxCategoryBook.Text;
            a.Id = Convert.ToInt32(textBoxAuthoeID.Text);
            a.FirstName = textBoxAuthorFname.Text;
            a.LastName = textBoxAuthorLname.Text;           
            book.Publisher = comboBoxPublisherBook.Text;
            book.Author = a;
            listbooks.Add(book);
       
            Book.saveRecord_text(book);
            clear_form_book();
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (comboBoxSearchProduct.Text == "Search By ISBN")
            {
                if (!Validators.IsNumber(textBoxSearchProduct.Text) )
                {
                    MessageBox.Show("Please enter correct value!");

                }
                else
                {
                    List<Book> searchId = Book.Search_book(textBoxSearchProduct.Text);
                    listViewProductBook.Items.Clear();
                    AddlistViewBook(searchId);
                    found = true;
                }

            }

            else if (comboBoxSearchProduct.Text == "Search By Title")
            {
                if (!Validators.IsString(textBoxSearchProduct.Text))
                {
                    MessageBox.Show("Please enter correct value!");

                }
                else
                {
                    List<Book> searchId = Book.Search_book(textBoxSearchProduct.Text);
                    listViewProductBook.Items.Clear();
                    AddlistViewBook(searchId);
                    found = true;
                }
            }

            else if (found)
            {
                MessageBox.Show("Data Not Found!");
            }
        }

        private void buttonListAllSoft_Click(object sender, EventArgs e)
        {
            Comparison<Software> comparison = (x, y) => x.ProductID.CompareTo(y.ProductID);

            List<Software> sorted_list = Software.ListSoftware();
            sorted_list.Sort(comparison);
            listViewSoftware.Items.Clear();
            AddlistViewSoftware(sorted_list);

        }

        private void buttonClearSoft_Click(object sender, EventArgs e)
        {
            clear_form_Software();
        }

        private void listViewSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////textBoxSearchSoft.Text = listViewSoftware.SelectedItems[0].SubItems[0].Text;
            ////textBoxIDSoftware.Text = listViewSoftware.SelectedItems[0].SubItems[0].Text;
            ////textBoxTitleSoftware.Text = listViewSoftware.SelectedItems[0].SubItems[1].Text;
            ////textBoxUnitPriceSoft.Text = listViewSoftware.SelectedItems[0].SubItems[2].Text;
            ////textBoxQOHSoft.Text = listViewSoftware.SelectedItems[0].SubItems[3].Text;
            ////comboBoxCategorySoft.Text = listViewSoftware.SelectedItems[0].SubItems[4].Text;
            ////comboBoxPublisherSoft.Text = listViewSoftware.SelectedItems[0].SubItems[5].Text;
           
        }

        private void buttonDeleteSoft_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this product ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Software.delet_software(textBoxIDSoftware.Text);
                MessageBox.Show("product deleted!", "Delete Product");
                clear_form_Software();
            }
        }

        private void buttonUpdateSoft_Click(object sender, EventArgs e)
        {
            Software soft = new Software();
            
            Software.delet_software(textBoxSearchSoft.Text);

            soft.ProductID = textBoxIDSoftware.Text;
            soft.ProductName = textBoxTitleSoftware.Text;
            soft.UnitPrice = Convert.ToDouble(textBoxUnitPriceSoft.Text);            
            soft.AmountInStock = Convert.ToDouble(textBoxQOHSoft.Text);
            soft.SoftwareType = comboBoxCategorySoft.Text;         
            soft.Publisher = comboBoxPublisherSoft.Text;
            
            listSofwars.Add(soft);

            Software.saveRecord_text(soft);
            clear_form_Software();
        }

        private void FormInventoryController_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            List<Users> searchId = Users.LoadRecord_changePass(f.First_u);

            foreach (Users use in searchId)
            {
                labelTitleName.Text = "Hello " + use.FirstName + use.LastName;


            }
        }

        private void labelTitleName_Click(object sender, EventArgs e)
        {
           
        }

        private void listviewDoubleClickBook(object sender, EventArgs e)
        {
            textBoxSearchProduct.Text = listViewProductBook.SelectedItems[0].SubItems[0].Text;
            textBoxIDBook.Text = listViewProductBook.SelectedItems[0].SubItems[0].Text;
            textBoxTitleBook.Text = listViewProductBook.SelectedItems[0].SubItems[1].Text;
            textBoxPriceBook.Text = listViewProductBook.SelectedItems[0].SubItems[2].Text;
            textBoxYearPubProduct.Text = listViewProductBook.SelectedItems[0].SubItems[3].Text;
            textBoxQohBook.Text = listViewProductBook.SelectedItems[0].SubItems[4].Text;
            comboBoxCategoryBook.Text = listViewProductBook.SelectedItems[0].SubItems[5].Text;
            textBoxAuthoeID.Text = listViewProductBook.SelectedItems[0].SubItems[6].Text;
            textBoxAuthorFname.Text = listViewProductBook.SelectedItems[0].SubItems[7].Text;
            textBoxAuthorLname.Text = listViewProductBook.SelectedItems[0].SubItems[8].Text;
            comboBoxPublisherBook.Text = listViewProductBook.SelectedItems[0].SubItems[9].Text;
        }

        private void listViewDoubleClickSoftware(object sender, EventArgs e)
        {
            textBoxSearchSoft.Text = listViewSoftware.SelectedItems[0].SubItems[0].Text;
            textBoxIDSoftware.Text = listViewSoftware.SelectedItems[0].SubItems[0].Text;
            textBoxTitleSoftware.Text = listViewSoftware.SelectedItems[0].SubItems[1].Text;
            textBoxUnitPriceSoft.Text = listViewSoftware.SelectedItems[0].SubItems[2].Text;
            textBoxQOHSoft.Text = listViewSoftware.SelectedItems[0].SubItems[3].Text;
            comboBoxCategorySoft.Text = listViewSoftware.SelectedItems[0].SubItems[4].Text;
            comboBoxPublisherSoft.Text = listViewSoftware.SelectedItems[0].SubItems[5].Text;
        }

        private void buttonSearchSoft_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (comboBoxSearchSoft.Text == "Search By ID")
            {
            
                    List<Software> searchId = Software.Search_soft(textBoxSearchSoft.Text);
                    listViewSoftware.Items.Clear();
                    AddlistViewSoftware(searchId);
                    found = true;
          

            }

            else if (comboBoxSearchSoft.Text == "Search By Title")
            {
              
                    List<Software> searchId = Software.Search_soft(textBoxSearchSoft.Text);
                    listViewSoftware.Items.Clear();
                    AddlistViewSoftware(searchId);
                    found = true;
            
            }

            else if (found)
            {
                MessageBox.Show("Data Not Found!");
            }
        }
    }
}
