using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;

namespace FinalProject1.Business
{
    public class Users:Employee
    {
        /// <summary>
        /// Variables
        /// </summary>
        string userName;
        string password;
        private UsersIO userIO;
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value;}
        }

        public string Password
        {
            get { return password; }
            set{ password = value; }
        }

        public UsersIO UserIO
        {
            get
            {
                return userIO;
            }

            set
            {
                userIO = value;
            }
        }

        public Users() { }

        public Users(int id,string fname,string lname,string title,string user,string pass):base(id,fname,lname,title)
        {
            userName = user;
            password = pass;

        }

        public static void SaveUsers(Users user)
        {
            UsersIO.saveUser(user);
        }

        public static List<Users> AllUsers()
        {
            return UsersIO.ListAllUsers();
        }

        public static List<Users> searchUser(int userid)
        {
            return UsersIO.SearchRecord(userid);
        }

        public static List<Users> searchUser(string name)
        {
            return UsersIO.SearchRecord(name);
        }


        public static string loginSearch(string user, string pass)
        {
            return UsersIO.loginUser(user, pass);
        }

        public static void deletLine_user(string del)
        {
            UsersIO.deletLine(del);
        }

        public static bool changePass_user(string user, string pass)
        {
            return UsersIO.changePass(user, pass);
        }

        public static List<Users> LoadRecord_changePass(string name)
        {
            return UsersIO.LoadRecord(name);
        }

        public static void Delete_lastLineUser()
        {
            UsersIO.Delete_lastLine();
        }

        public static bool ID_Uniq_user(int id)
        {
            return UsersIO.ID_Validation_Uniq(id);
        }

        public static bool Exist_Id(int id)
        {
            return UsersIO.searchExist_Id(id);
        }

    }
}
