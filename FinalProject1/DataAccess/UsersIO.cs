using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.Business;
using System.IO;
using FinalProject1.DataAccess;
using System.Windows.Forms;

namespace FinalProject1.DataAccess
{
   public class UsersIO
    {
        const string dir = @"";
        const string myPath = dir + "Users.dat";

        const string myPath_PRODUCTFILE = dir + "productfile.dat";
        const string myPath_EMPLOYEEFILE = dir + "employee.dat";
        const string myPath_CLIENTFILE = dir + "clientfile.dat";
        const string myPath_ORDERRECORDER = dir + "order.dat";

        private UserControl user;

        public UserControl User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public static void saveUser(Users usr)
        {
            using (StreamWriter textout =new StreamWriter(myPath,true))
            {
                textout.WriteLine(usr.Id+","+usr.FirstName+ " " +usr.LastName+","+usr.Title+","+usr.UserName+","+usr.Password);
            }
           
        }

        public static List<Users> ListAllUsers()
        {
            List<Users> users = new List<Users>();
            if(File.Exists(myPath))
            {
                FileStream fs = new FileStream(myPath, FileMode.Open, FileAccess.Read);
                StreamReader sReader = new StreamReader(fs);
                string currenRow = sReader.ReadLine();
                while (currenRow!=null)
                {
                    string[] currentLineFields = currenRow.Split(',');
                    Users us = new Users();
                    us.Id = Convert.ToInt32(currentLineFields[0]);
                    us.FirstName  = currentLineFields[1];
                    us.Title = currentLineFields[2];
                    us.UserName = currentLineFields[3];
                    us.Password = currentLineFields[4];
                    users.Add(us);
                    currenRow = sReader.ReadLine();
                }
                sReader.Close();
                fs.Close();
            }

            return users;
        }

        //================================
        



        //================
        public static List<Users> SearchRecord(int id)
        {
            List<Users> lstEmp = new List<Users>();
            
            if (File.Exists(myPath))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath);
                string line = sReader.ReadLine();                
                while (line != null)
                {
                    Users user = new Users();
                    string[] currentLine = line.Split(',');
                    if (currentLine[0] == id.ToString())
                    {
                        user.Id = Convert.ToInt32(currentLine[0]);
                        user.FirstName = currentLine[1];
                        user.Title = currentLine[2];
                        user.UserName = currentLine[3];
                        user.Password = currentLine[4];
                        
                        lstEmp.Add(user);
                       
                    }
                  
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return lstEmp;
            }
            else
            {
                return null;
            }

        }


        public static List<Users> SearchRecord(string name)
        {
            List<Users> lstEmp = new List<Users>();
           
            if (File.Exists(myPath))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath);
                string line = sReader.ReadLine();
                
                while (line != null)
                {
                    Users user = new Users();
                    string[] currentLine = line.Split(',');
                    if ((currentLine[1].Equals(name)) || (currentLine[2].Equals(name)))
                    {
                        user.Id = Convert.ToInt32(currentLine[0]);
                        user.FirstName = currentLine[1];
                        user.Title = currentLine[2];
                        user.UserName = currentLine[3];
                        user.Password = currentLine[4];
                       
                        lstEmp.Add(user);
                        
                    }
                 
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return lstEmp;
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }



        /// <summary>
        /// Read Text file for login
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static string loginUser(string user, string pass)
        {
            bool found = false;

            Users std = new Users();
            if (File.Exists(myPath))
            {
                FileStream fs = new FileStream(myPath, FileMode.Open, FileAccess.Read);

                StreamReader sReader = new StreamReader(fs);
                //  int recordCount = File.ReadLines(myPath).Count();
                string currentRow = sReader.ReadLine();
                while (currentRow != null)
                {
                    string[] currentLineFields = currentRow.Split(',');
                    if (currentLineFields[3] == user && currentLineFields[4] == pass)
                    {
                        std.Title = currentLineFields[2];
                        std.UserName = currentLineFields[3];
                        std.Password = currentLineFields[4];                      

                        found = true;
                    }
                  

                    currentRow = sReader.ReadLine();
                }
                sReader.Close();
                fs.Close();
                return std.Title;
            }
            else
            {
                MessageBox.Show("File not found!");
                return null;
            }

        }



        public static bool changePass(string user, string pass)
        {
            bool found = false;

            Users std = new Users();
            if (File.Exists(myPath))
            {
                FileStream fs = new FileStream(myPath, FileMode.Open, FileAccess.Read);

                StreamReader sReader = new StreamReader(fs);
                //  int recordCount = File.ReadLines(myPath).Count();
                string currentRow = sReader.ReadLine();
                while (currentRow != null)
                {
                    string[] currentLineFields = currentRow.Split(',');
                    if (currentLineFields[3] == user && currentLineFields[4] == pass)
                    {
                       // std.Title = currentLineFields[2];
                        std.UserName = currentLineFields[3];
                        std.Password = currentLineFields[4];

                        found = true;
                    }

                    currentRow = sReader.ReadLine();
                }
                sReader.Close();
                fs.Close();
                return found;
            }
            else
            {
                MessageBox.Show("File not found!");
                return found;
            }

        }


        public static List<Users> LoadRecord(string name)
        {
            List<Users> lstEmp = new List<Users>();
            Users user = new Users();
            if (File.Exists(myPath))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath);
                string line = sReader.ReadLine();
                //  bool found = false;
                while (line != null)
                {
                    string[] currentLine = line.Split(',');
                    if ((currentLine[3].Equals(name)) )
                    {
                        user.Id = Convert.ToInt32(currentLine[0]);
                        user.FirstName = currentLine[1];
                        user.Title = currentLine[2];
                        user.UserName = currentLine[3];
                        user.Password = currentLine[4];
                        sReader.Close();
                        lstEmp.Add(user);
                        return lstEmp;
                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return null;
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }



        public static void deletLine(string del)
        {
            string tempFile = Path.GetTempFileName();

            //StringBuilder sb = new StringBuilder();

            using (var sr = new StreamReader(myPath))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] currentLine = line.Split(',');

                        if (currentLine[0] != del)
                        {
                            sw.WriteLine(line);

                        }
                    
                    }
                }

            }


            File.Delete(myPath);
            File.Move(tempFile, myPath);

        }

        //========================== Delete Last Line
        public static void Delete_lastLine()
        {

            var lines = File.ReadAllLines(myPath);
            File.WriteAllLines(myPath, lines.Take(lines.Length - 1).ToArray());

        }
        //================================== Searching for ID_Unique
        public static bool ID_Validation_Uniq(int id)
        {
            bool idIsValid = false;

            if (File.Exists(myPath))
            {
                StreamReader sr = new StreamReader(myPath);
                string newLine = sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    string[] userline = newLine.Split(',');
                    if (userline[0] == id.ToString())
                    {
                        idIsValid = true;
                        break;
                    }
                    newLine = sr.ReadLine();
                }
                sr.Close();
            }

            return idIsValid;
        }
        //======================= serach for existing this user id

        public static bool searchExist_Id(int  id)
        {
            bool found = false;

            Employee std = new Employee();
            if (File.Exists(myPath_EMPLOYEEFILE))
            {
                FileStream fs = new FileStream(myPath_EMPLOYEEFILE, FileMode.Open, FileAccess.Read);

                StreamReader sReader = new StreamReader(fs);
                //  int recordCount = File.ReadLines(myPath).Count();
                string currentRow = sReader.ReadLine();
                while (currentRow != null)
                {
                    string[] currentLineFields = currentRow.Split(',');
                    if (currentLineFields[0] == id.ToString())
                    {
                       
                        std.Id = Convert.ToInt32(currentLineFields[0]);                     

                        found = true;
                    }

                    currentRow = sReader.ReadLine();
                }
                sReader.Close();
                fs.Close();
                return found;
            }
            else
            {
               
                return found;
            }

        }

        //******************************** End *************
    }
}
