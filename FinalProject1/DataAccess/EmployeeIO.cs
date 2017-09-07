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
    public static class EmployeeIO
    {
        const string dir = @"";
        const string myPath_employee= dir + "employee.dat";

        
        public static string JOBTITLE_MISMANAGER = "MIS Manager";
        public static string JOBTITLE_SALESMANAGER = "Sales Manager";
        public static string JOBTITLE_INVENTORYCONTROLLER = "Inventory Controller";
        public static string JOBTITLE_ORDERCLERKS = "Order Clerks";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="em"></param>
        public static void saveRecord(Employee em)
        {
            // create the output stream for a text file that exists
            using (StreamWriter textout = new StreamWriter(myPath_employee, true))
            {

                // write the fields into text file
                textout.WriteLine(em.Id + "," + em.FirstName +","+  em.LastName + "," + em.Title+",");
            }
            MessageBox.Show("Data saved successfully!");

        }

        public static List<Employee> ListAllEmployees()
        {
            List<Employee> emps = new List<Employee>();
            try
            {
                if (File.Exists(myPath_employee))
                {
                    FileStream fs = new FileStream(myPath_employee, FileMode.Open, FileAccess.Read);
                    StreamReader sReader = new StreamReader(fs);
                    int recordCount = File.ReadLines(myPath_employee).Count();
                    string currenRow = sReader.ReadLine();
                    while (currenRow != null)
                    {
                        string[] currentLineFields = currenRow.Split(',');
                        Employee us = new Employee();
                        us.Id = Convert.ToInt32(currentLineFields[0]);
                        us.FirstName = currentLineFields[1];
                        us.LastName = currentLineFields[2];
                        us.Title = currentLineFields[3];

                        emps.Add(us);
                        currenRow = sReader.ReadLine();
                    }
                    sReader.Close();
                    fs.Close();
                }

                return emps;
            }
            catch
            {
                return null;
            }
        }


        public static List<Employee> SearchRecord(int id)
        {
            List<Employee> lstEmp = new List<Employee>();
            
            if (File.Exists(myPath_employee))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath_employee);
                string line = sReader.ReadLine();
              //  bool found = false;
                while (line != null)
                {
                    Employee emp = new Employee();
                    string[] currentLine = line.Split(',');
                    if (currentLine[0] == id.ToString())
                    {
                        emp.Id = Convert.ToInt32(currentLine[0]);
                        emp.FirstName = currentLine[1];
                        emp.LastName = currentLine[2];
                        emp.Title = currentLine[3];
                        
                        lstEmp.Add(emp);
                        
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


        public static List<Employee> SearchRecord(string name)
        {
            List<Employee> lstEmp = new List<Employee>();
            if (File.Exists(myPath_employee))
            {                
                StreamReader sReader = new StreamReader(myPath_employee);
                string line = sReader.ReadLine();                
                while (line != null)
                {
                    Employee emp = new Employee();

                    string[] currentLine = line.Split(',');
                    if ((currentLine[1].Equals(name)) || (currentLine[2].Equals(name)))
                    {
                        emp.Id = Convert.ToInt32(currentLine[0]);
                        emp.FirstName = currentLine[1];
                        emp.LastName = currentLine[2];
                        emp.Title = currentLine[3];                     
                        lstEmp.Add(emp);
                        
                    }
                 

                    line = sReader.ReadLine();
                }
                return lstEmp;
                sReader.Close();
           
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }
        /// <summary>
        /// This method delete one line from text file
        /// </summary>
        /// <param name="del"></param>
        public static void deletLine(string del)
        {
            string tempFile = Path.GetTempFileName();    
            using (var sr = new StreamReader(myPath_employee))
            {
                using (var sw = new StreamWriter(tempFile))
                {
                    string line; 
                    while ((line=sr.ReadLine()) != null)
                    {
                        string[] currentLine = line.Split(',');

                        if (currentLine[0] != del)
                       {                       
                            sw.WriteLine(line);
                       }
                    
                    }
                }                
            }


            File.Delete(myPath_employee);
            File.Move(tempFile, myPath_employee);

        }
        //=================================== Delete Last Line
        public static void Delete_lastLine()
        {

            var lines = File.ReadAllLines(myPath_employee);
            File.WriteAllLines(myPath_employee, lines.Take(lines.Length - 1).ToArray());

        }

        //============================= Valid ID=================
        public static bool ID_Validation_Uniq(int id)
        {
            bool idIsValid = false;

            if (File.Exists(myPath_employee))
            {
                StreamReader sr = new StreamReader(myPath_employee);
                string newLine = sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    string[] userline = newLine.Split(',');
                    if (userline[0] == id.ToString() )
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


        //============================================================
    }
}
