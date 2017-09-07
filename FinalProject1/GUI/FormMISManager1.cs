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

namespace FinalProject1.GUI
{
    public partial class FormMISManager1 : Form
    {
        //const string dir = @"";
        //const string myPath_employee = dir + "employee.dat";

        List<Employee> listEmployee = new List<Employee>();
        List<Users> listUser = new List<Users>();

        /// <summary>
        /// This method Clear employee form totally
        /// </summary>
        public void clearForm_emp()
        {
            listViewEmployee.Items.Clear();
            textBoxIDEmp.Text = "";
            textBoxFnameEmp.Text = "";
            textBoxLNameEmp.Text = "";
            textBoxTitleEmp.Text = "";
            textBoxSearchEmp.Text = "";
        }
        
        public FormMISManager1()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// SAVING(ADDING) new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveUser_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (textBoxPass.Text == "" || textBoxIdUser.Text == "")
                {
                    MessageBox.Show("Please enter the requered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!(Validators.IsValidSize(textBoxIdUser.Text.Trim(), 4)))
                {
                    MessageBox.Show("Please enter valid size for id number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!(Validators.IsNumber(textBoxIdUser.Text.Trim())))
                {
                    MessageBox.Show("Please enter just number for Id number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Users.Exist_Id(Convert.ToInt32(textBoxIdUser.Text)))
                {

                    //if (Users.Exist_Id(Convert.ToInt32(textBoxIdUser.Text)))
                    //{
                    Users us = new Users();
                    us.Id = Convert.ToInt32(textBoxIdUser.Text.Trim());
                    us.FirstName = textBoxFullNameUser.Text;

                    us.Title = textBoxTitleUser.Text;
                    us.UserName = textBoxUsername.Text;
                    us.Password = textBoxPass.Text;
                    listEmployee.Add(us);
                    Users.SaveUsers(us);
                    if (Users.ID_Uniq_user(Convert.ToInt32(textBoxIdUser.Text.Trim())) == true)
                    {
                        MessageBox.Show("This ID already exist! Please enter enother ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Users.Delete_lastLineUser();
                    }

                    else
                    {
                        MessageBox.Show("Data saved successfully!");
                        clearForm_user();
                    }

                  

                }
                else
                {
                    MessageBox.Show("This employee does not exist! Please enter valid user name! ");
                }



            }
            catch (Exception)
            {

                throw ;
            }

        }
        /// <summary>
        /// SAVING(ADDING) new employee (button -> Add)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveEmp_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (textBoxIDEmp.Text == "" || textBoxFnameEmp.Text == "" || textBoxLNameEmp.Text == "")
                {
                    MessageBox.Show("Please enter the requered information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Checking valid number for id with validator
                else if (!(Validators.IsValidSize(textBoxIDEmp.Text.Trim(), 4)))
                {
                    MessageBox.Show("Please enter valid size for id number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (!(Validators.IsNumber(textBoxIDEmp.Text.Trim())))
                {
                    MessageBox.Show("Please enter just number for Id number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!(Validators.IsString(textBoxFnameEmp.Text)) || !(Validators.IsString(textBoxLNameEmp.Text)))
                {
                    MessageBox.Show("Please enter just word for first name and last name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                           

                else
                {
                    Employee emp = new Employee();
                    emp.Id = Convert.ToInt32(textBoxIDEmp.Text.Trim());
                    emp.FirstName = textBoxFnameEmp.Text;
                    emp.LastName = textBoxLNameEmp.Text;
                    emp.Title = textBoxTitleEmp.Text;
                    listEmployee.Add(emp);
                    Employee.SaveEmployee(emp);
                    if (Employee.ID_Uniq(Convert.ToInt32(textBoxIDEmp.Text.Trim())) == true)
                    {
                        MessageBox.Show("This ID already exist! Please enter enother ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Employee.Delete_lastLineEmp();
                    }
                    
                    clearForm_emp();
                }







            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// EXITING ( button Exit in employee form)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Cleaning employee form (button -> Clear)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearEmp_Click(object sender, EventArgs e)
        {
            clearForm_emp();
      
        }
        /// <summary>
        /// Method for adding to list view in employee form
        /// </summary>
        /// <param name="listEmp"></param>
        /// <returns></returns>
        public bool AddListView(List<Employee> listEmp)
        {
            try
            {
                foreach (Employee emp in listEmp)
                {

                    ListViewItem item = new ListViewItem((emp.Id).ToString());
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.Title);
                    listViewEmployee.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }
        /// <summary>
        /// List all employee (button -> list All)( using combo box for sorting list)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListEmp_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (comboBoxSortEmp.Text == "Sort By ID")
                {
                    Comparison<Employee> comparison = (x, y) => x.Id.CompareTo(y.Id);
                    List<Employee> sorted_list = Employee.AllEmps();
                    sorted_list.Sort(comparison);
                    listViewEmployee.Items.Clear();
                    AddListView(sorted_list);
                }

                else if(comboBoxSortEmp.Text == "Sort By First Name")
                {
                    Comparison<Employee> comparison = (x, y) => x.FirstName.CompareTo(y.FirstName);
                    List<Employee> sorted_list = Employee.AllEmps();
                    sorted_list.Sort(comparison);
                    listViewEmployee.Items.Clear();
                    AddListView(sorted_list);

                }
                else if(comboBoxSortEmp.Text == "Sort By Last Name")
                {
                    Comparison<Employee> comparison = (x, y) => x.LastName.CompareTo(y.LastName);
                    List<Employee> sorted_list = Employee.AllEmps();
                    sorted_list.Sort(comparison);
                    listViewEmployee.Items.Clear();
                    AddListView(sorted_list);
                }
                else if (comboBoxSortEmp.Text == "Sort By Title")
                {
                    Comparison<Employee> comparison = (x, y) => x.Title.CompareTo(y.Title);
                    List<Employee> sorted_list = Employee.AllEmps();
                    sorted_list.Sort(comparison);
                    listViewEmployee.Items.Clear();
                    AddListView(sorted_list);
                }
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// function for clearing user form
        /// </summary>
        public void clearForm_user()
        {
            textBoxFullNameUser.Text = "";
            textBoxIdUser.Text = "";
            textBoxPass.Text = "";
            textBoxSearchUser.Text = "";
            textBoxUsername.Text = "";
            textBoxTitleUser.Text = "";
            listViewUser.Items.Clear();
        }
        /// <summary>
        /// Clear user form(button -> Clear)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearUser_Click(object sender, EventArgs e)
        {
            clearForm_user();
            
        }

        private void textBoxIdUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Exit from user form (Button -> exit)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Searching user (Button -> Search)(Use comboBox to choose searching type)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchUser.Text == "Search By ID")
            {
                if (!Validators.IsNumber(textBoxSearchUser.Text) || !Validators.IsValidSize(textBoxSearchUser.Text, 4))
                {
                    MessageBox.Show("Please enter 4 digit number!");

                }
                else
                {
                    List<Users> searchId = Users.searchUser(Convert.ToInt32(textBoxSearchUser.Text));
                    listViewUser.Items.Clear();
                    listViewAddUser(searchId);
                 
                }

            }

            else if (comboBoxSearchUser.Text == "Search By Fullname")
            {
                if (!Validators.IsString(textBoxSearchUser.Text))
                {
                    MessageBox.Show("Please enter letters only!");

                }
                else
                {
                    List<Users> searchName = Users.searchUser(textBoxSearchUser.Text);
                    listViewUser.Items.Clear();
                    listViewAddUser(searchName);

                }
            }           

            
            else 
            {
                MessageBox.Show("Data Not Found!");
            }
        }
        /// <summary>
        /// Function for add to listview in user form
        /// </summary>
        /// <param name="listUser"></param>
        /// <returns></returns>
        public bool listViewAddUser(List<Users> listUser)
        {
            try
            {
                foreach (Users use in listUser)
                {

                    ListViewItem item = new ListViewItem((use.Id).ToString());
                    item.SubItems.Add(use.FirstName+use.LastName);
                    item.SubItems.Add(use.Title);
                    item.SubItems.Add(use.UserName);
                    item.SubItems.Add(use.Password);
                    listViewUser.Items.Add(item);

                }
                return true;
            }
            catch
            {

                return false;
            }
        }
        /// <summary>
        /// List all user in user form(button -> List All) (Use combobox to choose sorting list type)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListUser_Click(object sender, EventArgs e)
        {
            if(comboBoxSortUser.Text=="Sort By ID")
            {
                Comparison<Users> comparison = (x, y) => x.Id.CompareTo(y.Id);
                List<Users> sorted_list = Users.AllUsers();
                sorted_list.Sort(comparison);
                listViewUser.Items.Clear();
                listViewAddUser(sorted_list);

            }

            else if (comboBoxSortUser.Text == "Sort By FullName")
            {
                Comparison<Users> comparison = (x, y) => x.FirstName.CompareTo(y.FirstName);
                List<Users> sorted_list = Users.AllUsers();
                sorted_list.Sort(comparison);
                listViewUser.Items.Clear();
                listViewAddUser(sorted_list);

            }
     
            else if (comboBoxSortUser.Text == "Sort By Title")
            {
                Comparison<Users> comparison = (x, y) => x.Title.CompareTo(y.Title);
                List<Users> sorted_list = Users.AllUsers();
                sorted_list.Sort(comparison);
                listViewUser.Items.Clear();
                listViewAddUser(sorted_list);
            }
        }
        /// <summary>
        /// Searching employee  in employee form(Button -> Search) (Use combobox to sorting Searching type)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchEmp_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (comboBoxSearchEmp.Text == "Search By ID")
            {
                if (!Validators.IsNumber(textBoxSearchEmp.Text)|| !Validators.IsValidSize(textBoxSearchEmp.Text,4))
                {
                    MessageBox.Show("Please enter 4 digit number!");
                  
                }
                else
                {
                    List<Employee> searchId = Employee.searchEmp(Convert.ToInt32(textBoxSearchEmp.Text));
                    listViewEmployee.Items.Clear();
                    AddListView(searchId);
                    found = true;
                }

            }

            else if (comboBoxSearchEmp.Text == "Search By First Name")
            {
                if (!Validators.IsString(textBoxSearchEmp.Text))
                {
                    MessageBox.Show("Please enter letters only!");

                }
                else
                {
                    List<Employee> searchFName = Employee.searchEmp(textBoxSearchEmp.Text);
                    listViewEmployee.Items.Clear();
                    AddListView(searchFName);
                    found = true;
                }
            }

            else if (comboBoxSearchEmp.Text == "Search By Last Name")
            {
                if (!Validators.IsString(textBoxSearchEmp.Text))
                {
                    MessageBox.Show("Please enter letters only!");

                }
                else
                {
                    List<Employee> searchLName = Employee.searchEmp(textBoxSearchEmp.Text);
                    listViewEmployee.Items.Clear();
                    AddListView(searchLName);
                    clearForm_emp();
                    found = true;
                }

            }
            else if(found)
            {
                MessageBox.Show("Data Not Found!");
            }

        }
        /// <summary>
        /// Deleting employee after search it by id (Button -> Delete )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this employee ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Employee.deletLine_Emp(textBoxIDEmp.Text);
                MessageBox.Show("Employee deleted!", "Delete");
                clearForm_emp();
            }
        }

        private void comboBoxSearchEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Showing the specific employee in text files and listview after clicking on list view 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  while(listViewEmployee.Click())
            //bool found = false;
            //if (found == false)
            //{
            //    textBoxSearchEmp.Text = listViewEmployee.SelectedItems[0].SubItems[0].Text;
            //    textBoxIDEmp.Text = listViewEmployee.SelectedItems[0].SubItems[0].Text;
            //    textBoxFnameEmp.Text = listViewEmployee.SelectedItems[0].SubItems[1].Text;
            //    textBoxLNameEmp.Text = listViewEmployee.SelectedItems[0].SubItems[2].Text;
            //    textBoxTitleEmp.Text = listViewEmployee.SelectedItems[0].SubItems[3].Text;
            //    found = true;
            //}


        }
        /// <summary>
        /// Updating information of employee (Button -> update)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateEmp_Click(object sender, EventArgs e)
        {           
            Employee emp = new Employee();
            Employee.deletLine_Emp(textBoxSearchEmp.Text);
            
            emp.Id = Convert.ToInt32(textBoxIDEmp.Text.Trim());
            emp.FirstName = textBoxFnameEmp.Text;
            emp.LastName = textBoxLNameEmp.Text;
            emp.Title = textBoxTitleEmp.Text;
         //   listEmployee.Add(emp);
            Employee.SaveEmployee(emp);


            clearForm_emp();           
        }
        /// <summary>
        /// Deleting user after search it by id (Button -> Delete )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this user ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Users.deletLine_user(textBoxSearchUser.Text);
                MessageBox.Show("User deleted!", "Delet User");
                clearForm_user();
            }
        }
        /// <summary>
        /// Showing the specific user in text files and listview after clicking on list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxIdUser.Text = listViewUser.SelectedItems[0].SubItems[0].Text;
            //textBoxFullNameUser.Text = listViewUser.SelectedItems[0].SubItems[1].Text;
            //textBoxTitleUser.Text = listViewUser.SelectedItems[0].SubItems[2].Text;
            //textBoxUsername.Text = listViewUser.SelectedItems[0].SubItems[3].Text;
            //textBoxPass.Text = listViewUser.SelectedItems[0].SubItems[4].Text;

            //textBoxSearchUser.Text = listViewUser.SelectedItems[0].SubItems[0].Text;
        }
        /// <summary>
        /// Updating information of user (Button->Update)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
          
            if (Users.Exist_Id(Convert.ToInt32(textBoxIdUser.Text)))
            {

                Users user = new Users();
                Users.deletLine_user(textBoxSearchUser.Text);

                user.Id = Convert.ToInt32(textBoxIdUser.Text.Trim());
                user.FirstName = textBoxFullNameUser.Text;
                user.Title = textBoxTitleUser.Text;
                user.UserName = textBoxUsername.Text;
                user.Password = textBoxPass.Text;

                Users.SaveUsers(user);
              
                if (Users.ID_Uniq_user(Convert.ToInt32(textBoxIdUser.Text.Trim())) == true)
                {
                    MessageBox.Show("This ID already exist! Please enter enother ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Users.Delete_lastLineUser();
                }

                else
                {
                    MessageBox.Show("Data saved successfully!");
                    clearForm_user();
                }



            }
            else
            {
                MessageBox.Show("This employee does not exist! Please enter valid user name! ");
            }           
          
        }

        private void FormMISManager1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();    
            List<Users> searchId = Users.LoadRecord_changePass(f.First_u);

            foreach (Users use in searchId)
            {
                labelNameTitle.Text ="Hello " +use.FirstName + use.LastName;


            }

      
        }

        private void listViewEmployeeDoubleClich(object sender, EventArgs e)
        {
            textBoxSearchEmp.Text = listViewEmployee.SelectedItems[0].SubItems[0].Text;
            textBoxIDEmp.Text = listViewEmployee.SelectedItems[0].SubItems[0].Text;
            textBoxFnameEmp.Text = listViewEmployee.SelectedItems[0].SubItems[1].Text;
            textBoxLNameEmp.Text = listViewEmployee.SelectedItems[0].SubItems[2].Text;
            textBoxTitleEmp.Text = listViewEmployee.SelectedItems[0].SubItems[3].Text;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void listViewDoubleClickUser(object sender, EventArgs e)
        {
            textBoxIdUser.Text = listViewUser.SelectedItems[0].SubItems[0].Text;
            textBoxFullNameUser.Text = listViewUser.SelectedItems[0].SubItems[1].Text;
            textBoxTitleUser.Text = listViewUser.SelectedItems[0].SubItems[2].Text;
            textBoxUsername.Text = listViewUser.SelectedItems[0].SubItems[3].Text;
            textBoxPass.Text = listViewUser.SelectedItems[0].SubItems[4].Text;

            textBoxSearchUser.Text = listViewUser.SelectedItems[0].SubItems[0].Text;
            textBoxIDEmp.ReadOnly = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
