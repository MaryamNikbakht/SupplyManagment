using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;
using FinalProject1.GUI;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject1.Business
{
    [Serializable]
    public class Client 
    {
        private int id;
        private string name;
        private string faxNum;
        private string phonNum;
        private string email;
        private string address;
        private string city;
        private string postalCod;
        public string account;
        public double creditLimit;

        public int Id
        {
            get { return id; }
            set {id = value; }
        }

        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public string FaxNum
        {
            get {return faxNum;}
            set {faxNum = value; }
        }

        public string PhonNum
        {
            get { return phonNum; }
            set{ phonNum = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address;}
            set{ address = value; }
        }

        public string City
        {
            get { return city;}
            set { city = value;}
        }

        public string PostalCod
        {
            get{ return postalCod; }
            set { postalCod = value;}
        }

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public double CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }
        public Client(int id,string name, string faxNum,string phonNum,string email,string address, string city,string postalCod,string account,double creditLimit)
        {
            this.id = id;
            this.name = name;
            this.faxNum = faxNum;
            this.phonNum = phonNum;
            this.email = email;
            this.address = address;
            this.city = city;
            this.postalCod = postalCod;
            this.account = account;
            this.creditLimit = creditLimit;

        }
        public Client() { }


        public static void serializationClient(Client client)
        {
            ClientIO.serializationObject(client);
        }



        //public static List<Client> deserializationClient()
        //{
        //    return ClientIO.deserializationObject();
        //}

        public static void writeClient_binary(Client c)
        {
            ClientIO.writeBinaryClient(c);
        }

        public static List<Client> GetClient_binary()
        {
            return ClientIO.GetClients_binary();
        }

        //public static List<Client> searchBinaryClient(int id)
        //{
        //    return ClientIO.searchBinary(id);
        //}

        public static void saveClient(Client client)
        {
            ClientIO.saveRecord(client);
        }

        public static List<Client> ListAllClients()
        {
            return ClientIO.ListClient();
        }

        public static List<Client> SearchClient(int id)
        {
            return ClientIO.SearchRecord(id);
        }

        public static List<Client> SearchClient(string name)
        {
            return ClientIO.SearchRecord(name);
        }

        public static void deletLineClient(string del)
        {
            ClientIO.deletLine(del);
        }

        public static void Delete_lastLineClient()
        {
            ClientIO.Delete_lastLine();
        }
        public static bool ID_Uniq(int id)
        {
            return ClientIO.ID_Validation_Uniq(id);
        }

    }
}
