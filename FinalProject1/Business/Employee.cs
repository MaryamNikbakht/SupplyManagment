using FinalProject1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1.Business
{
    public class Employee : Person
    {
        /// <summary>
        /// Atributes
        /// </summary>
        private int id;  
        private string title;
      //  public EmployeeIO EmployeeIO;

        /// <summary>
        /// Property of id
        /// </summary>
        public int Id
        {
            get { return id; }
            set {id = value;}
        }
       
      
        /// <summary>
        /// Property of title
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Employee(): base()
        {

        }

        public Employee(int idEmp,string firstName,string lastName,string tit): base(firstName, lastName)
        {
            id = idEmp;
          base.FirstName = firstName;
         base.LastName = lastName;
            title = tit;
        }

        public static bool ID_Uniq(int id)
        {
            return EmployeeIO.ID_Validation_Uniq(id);
        }

        public static void SaveEmployee(Employee em)
        {
            EmployeeIO.saveRecord(em);
        }

        public static List<Employee> AllEmps()
        {
            return EmployeeIO.ListAllEmployees();
        }

        public static List<Employee> searchEmp(int empid)
        {
          return  EmployeeIO.SearchRecord(empid);
        }

        public static List<Employee> searchEmp(string name)
        {
            return EmployeeIO.SearchRecord(name);
        }

        public static void deletLine_Emp(string del)
        {
          EmployeeIO.deletLine(del);
        }
        public static void Delete_lastLineEmp()
        {
            EmployeeIO.Delete_lastLine();
        }

    }
}
