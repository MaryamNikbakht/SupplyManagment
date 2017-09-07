using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;

namespace FinalProject1.Business
{
    public class Order
    {
        private double orderId;
        private Book book;
        private Software software;
        private Client client;
        private double amount;
        private double Total;
        private string titleOrder;
       // private int orderRow;
        private string status;   
        private  DateTime requiredDate;
        private DateTime shippingDate;

        public DateTime RequiredDate
        {
            get {return requiredDate; }
            set { requiredDate = value; }
        }

        public DateTime ShippingDate
        {
            get { return shippingDate; }
            set { shippingDate = value; }
        }

        public Software Software
        {
            get { return software; }
            set {software = value;}
        }

        public Client Client
        {
            get {return client; }
            set { client = value; }
        }

        public Book Book
        {
            get { return book; }
            set {book = value; }
        }

        public double Amount
        {
            get { return amount; }
            set {amount = value;}
        }

     

        public double Total1
        {
            get{ return Total; }
            set { Total = value;}
        }

        public string TitleOrder
        {
            get { return titleOrder;}
            set { titleOrder = value; }
        }

        //public int OrderRow
        //{
        //    get { return orderRow; }
        //    set { orderRow = value; }
        //}

        public string Status
        {
            get { return status; }
            set { status = value;}
        }

        public double OrderId
        {
            get
            {
                return orderId;
            }

            set
            {
                orderId = value;
            }
        }

        public Order()
        {

        }

        //public static void WriteXML_List_book(Book books, string xmlmyPath_client)
        //{
        //    InventoryIO.WriteXML_List(books);
        //}
        public static List<Book> Search_orderbook(string name)
        {
           return OrderIO.SearchRecord_book(name);
        }

        public static List<Software> Search_OrderSoftware(string name)
        {
            return OrderIO.SearchRecord_Software(name);
        }

      

        public static void saveRecordBook(Order ord)
        {
            OrderIO.saveRecord_book(ord);
        }
        public static void saveRecordSoftware(Order ord)
        {
            OrderIO.saveRecord_software(ord);
        }

        public static List<Book> ListBooks_order()
        {
            return OrderIO.ListBooks();
        }
        public static List<Software> ListSoftware_order()
        {
            return OrderIO.ListSoftware();
        }

        public static bool processQohBook(double amount, string id)
        {
            return OrderIO.processQoh_book(amount,id);
        }

        public static List<Order> ListAllOrders()
        {
            return OrderIO.ListOrders();
        }

       

        public static List<Order> Search_orders(string name)
        {
            return OrderIO.SearchRecord_orders(name);
        }

        //======== delete one line book
        public static void deletOrder_line(string del)
        {
            OrderIO.deletLine_order(del);
        }
    }
}
