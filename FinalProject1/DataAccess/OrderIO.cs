using FinalProject1.Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject1.DataAccess
{
    

    public class OrderIO
    {
        //static int count = 0;
        //static int count2 = 0;

        const string dir = @"";
        const string myPath_Order = dir + "Order.dat";
        const string myPath_inventory_Book = dir + "Inventorybook.dat";    
        const string myPath_inventory_Software = dir + "InventorySoftware.dat";

        public static List<Book> books = new List<Book>();
        public static List<Client> listClients = new List<Client>();
        public static List<Software> listSofwars = new List<Software>();
        public static List<Order> listOrder = new List<Order>();

      
        
        //================================ Search Product

        public static List<Product> SearchRecord_Product(string name)
        {
           
            List<Product> listProduct = new List<Product>();           
           
            if (File.Exists(myPath_inventory_Book))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath_inventory_Book);
                string line = sReader.ReadLine();

                while (line != null)
                {
                 // Product pro = new Book();
                    Book book = new Book();
                    string[] currentLine = line.Split(',');
                    if ((currentLine[0].Equals(name)) || (currentLine[1].Equals(name)))
                    {
                      
                        book.ProductID = currentLine[0];
                        book.ProductName = currentLine[1];
                        book.UnitPrice = Convert.ToDouble(currentLine[2]);

                        book.AmountInStock = Convert.ToDouble(currentLine[4]);
                        book.BookType = currentLine[5];



                        listProduct.Add(book);

                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return listProduct;
            }

            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }


        //============================= search Book

        public static List<Book> SearchRecord_book(string name)
        {
            
            List<Book> listbook = new List<Book>();
      

            if (File.Exists(myPath_inventory_Book))
            {
                //Creation of the object of StreamReader
                StreamReader sReader = new StreamReader(myPath_inventory_Book);
                string line = sReader.ReadLine();

                while (line != null)
                {
                    Book book = new Book();
                    string[] currentLine = line.Split(',');
                    if ((currentLine[0].Equals(name)) || (currentLine[1].Equals(name)))
                    {
                       // Author a = new Author();
                        book.ProductID = currentLine[0];
                        book.ProductName = currentLine[1];
                        book.UnitPrice = Convert.ToDouble(currentLine[2]);
                    
                        book.AmountInStock = Convert.ToDouble(currentLine[4]);
                        book.BookType = currentLine[5];

                

                        listbook.Add(book);

                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
               return listbook;
            }
           
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }
        //================================== Search Software
        public static List<Software> SearchRecord_Software(string name)
        {
           
          
              List<Software> listsofts = new List<Software>();

             if (File.Exists(myPath_inventory_Software))
            {
                StreamReader sReader = new StreamReader(myPath_inventory_Software);
                string line = sReader.ReadLine();

                while (line != null)
                {
                    Software soft = new Software();
                    string[] currentLine = line.Split(',');
                    if ((currentLine[0].Equals(name)) || (currentLine[1].Equals(name)))
                    {

                        soft.ProductID = currentLine[0];
                        soft.ProductName = currentLine[1];
                        soft.UnitPrice = Convert.ToDouble(currentLine[2]);

                        soft.AmountInStock = Convert.ToDouble(currentLine[3]);
                        soft.SoftwareType = currentLine[4];


                        listsofts.Add(soft);

                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return listsofts;
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }
        //================================== processing for QOH
        public static bool processQoh_book(double amount, string id)
        {
            bool found = false;


            if (File.Exists(myPath_inventory_Book))
            {
                Book quhBook = new Book();
                FileStream fs = new FileStream(myPath_inventory_Book, FileMode.Open, FileAccess.Read);

                StreamReader sReader = new StreamReader(fs);
                //  int recordCount = File.ReadLines(myPath).Count();
                string currentRow = sReader.ReadLine();
                while (currentRow != null)
                {
                    string[] currentLineFields = currentRow.Split(',');
                    if (currentLineFields[0]== id )
                    {

                        if (amount <= Convert.ToDouble(currentLineFields[3]))
                        {
                            quhBook.AmountInStock = Convert.ToDouble(currentLineFields[3]);
                            found = true;
                        }

                        else
                        {
                            found = false;
                        }

                    }

                    currentRow = sReader.ReadLine();
                }
                sReader.Close();
                fs.Close();
                return found;
            }
            else
            {
                MessageBox.Show("Not found!");
                return found;
            }
        }

        //===================== save text file for books order
        public static void saveRecord_book(Order ordBook)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(myPath_Order))
            {
                while (sr.ReadLine() != null)
                {
                    count++;
                }
            }
         
            using (StreamWriter textout = new StreamWriter(myPath_Order, true))
            {


                textout.WriteLine(ordBook.OrderId+","+ordBook.Book.ProductID + "," + ordBook.Book.ProductName + "," + ordBook.Client.Name + "," +
                    ordBook.Book.UnitPrice + "," + ordBook.Amount + "," + ordBook.RequiredDate + "," + ordBook.ShippingDate + "," + ordBook.Total1 + "," + "book" + "," +ordBook.Status );
            
            }
            MessageBox.Show("Data saved!");
        }
        //============================== Read all books

        public static List<Book> ListBooks()
        {
            List<Book> books = new List<Book>();
            try
            {
                if (File.Exists(myPath_inventory_Book))
                {
                    FileStream fs = new FileStream(myPath_inventory_Book, FileMode.Open, FileAccess.Read);
                    StreamReader sReader = new StreamReader(fs);
                    int recordCount = File.ReadLines(myPath_inventory_Book).Count();
                    string currenRow = sReader.ReadLine();
                    while (currenRow != null)
                    {
                        string[] currentLineFields = currenRow.Split(',');
                        Book book = new Book();
                        book.ProductID = currentLineFields[0];
                        book.ProductName = currentLineFields[1];
                        book.UnitPrice = Convert.ToDouble(currentLineFields[2]);

                        book.AmountInStock = Convert.ToDouble(currentLineFields[4]);
                        book.BookType = currentLineFields[5];



                        books.Add(book);
                      
                        currenRow = sReader.ReadLine();
                    }
                    sReader.Close();
                    fs.Close();
                }

                return books;
            }
            catch
            {
                return null;
            }
        }

        //=========================  Read all softwars

        public static List<Software> ListSoftware()
        {
            List<Software> softs = new List<Software>();
            try
            {
                if (File.Exists(myPath_inventory_Software))
                {
                    FileStream fs = new FileStream(myPath_inventory_Software, FileMode.Open, FileAccess.Read);
                    StreamReader sReader = new StreamReader(fs);
                    int recordCount = File.ReadLines(myPath_inventory_Software).Count();
                    string currenRow = sReader.ReadLine();
                    while (currenRow != null)
                    {
                        string[] currentLineFields = currenRow.Split(',');
                        Software soft = new Software();

                        soft.ProductID = currentLineFields[0];
                        soft.ProductName = currentLineFields[1];
                        soft.UnitPrice = Convert.ToDouble(currentLineFields[2]);

                        soft.AmountInStock = Convert.ToDouble(currentLineFields[3]);
                        soft.SoftwareType = currentLineFields[4];
                       

                        softs.Add(soft);
                        currenRow = sReader.ReadLine();
                    }
                    sReader.Close();
                    fs.Close();
                }

                return softs;
            }
            catch
            {
                return null;
            }
        }
        //===================== save text file for software order
        public static void saveRecord_software(Order ordSoft)
        {
            int count = 0;
            using (StreamReader sr = new StreamReader(myPath_Order))
            {
                while (sr.ReadLine() != null)
                {
                    count++;
                }
            }

            // create the output stream for a text file that exists
            using (StreamWriter textout = new StreamWriter(myPath_Order, true))
            {
              //  Client c = new Client();
                textout.WriteLine(ordSoft.OrderId+","+ordSoft.Software.ProductID + "," + ordSoft.Software.ProductName + "," +ordSoft.Client.Name+","+
                    ordSoft.Software.UnitPrice + "," + ordSoft.Amount + "," + ordSoft.RequiredDate+","+ordSoft.ShippingDate+"," + ordSoft.Total1 + "," + "software"+","+ordSoft.Status );
        
            }
            MessageBox.Show("Data saved!");

        }

     

   
        //================================= read all orders
        public static List<Order> ListOrders()
        {
           List<Order> orders = new List<Order>();
            try
            {
                if (File.Exists(myPath_Order))
                {
                    FileStream fs = new FileStream(myPath_Order, FileMode.Open, FileAccess.Read);
                    StreamReader sReader = new StreamReader(fs);
                    int recordCount = File.ReadLines(myPath_Order).Count();
                    string currenRow = sReader.ReadLine();
                    while (currenRow != null)
                    {
                        string[] currentLineFields = currenRow.Split(',');

                      
                        if (currentLineFields[9] == "software")
                        {
                            Order o = new Order();
                            Software soft = new Software();
                            Client c = new Client();

                            o.OrderId = Convert.ToDouble(currentLineFields[0]);
                            soft.ProductID = currentLineFields[1];
                            soft.ProductName = currentLineFields[2];
                            soft.UnitPrice = Convert.ToDouble(currentLineFields[4]);
                        
                             c.Name= currentLineFields[3];                           
                        
                            o.Amount = Convert.ToDouble(currentLineFields[5]);
                            
                            o.RequiredDate = Convert.ToDateTime(currentLineFields[6]);
                            o.ShippingDate = Convert.ToDateTime(currentLineFields[7]);
                            o.Total1 = Convert.ToDouble(currentLineFields[8]);
                            o.TitleOrder = currentLineFields[9];
                            o.Status = currentLineFields[10];

                            o.Software = soft;
                            o.Client = c;
                            orders.Add(o);

                        }
                        else if (currentLineFields[9] == "book")
                        {
                            Order o = new Order();
                            Book book = new Book();
                            Client c = new Client();

                            o.OrderId = Convert.ToDouble(currentLineFields[0]);
                            book.ProductID = currentLineFields[1];
                            book.ProductName = currentLineFields[2];
                            book.UnitPrice = Convert.ToDouble(currentLineFields[4]);

                            c.Name= currentLineFields[3];
                           
                            o.Amount = Convert.ToDouble(currentLineFields[5]);
                            
                            o.RequiredDate = Convert.ToDateTime(currentLineFields[6]);
                            o.ShippingDate = Convert.ToDateTime(currentLineFields[7]);
                            o.Total1 = Convert.ToDouble(currentLineFields[8]);
                            o.TitleOrder = currentLineFields[9];
                            
                            o.Status = currentLineFields[10];
                            o.Book = book;
                            o.Client = c;
                            orders.Add(o);
                        }
                        currenRow = sReader.ReadLine();
                    }
                    sReader.Close();
                    fs.Close();
                }

                return orders;
            }
            catch
            {
                return null;
            }
        }



        //==================== search orders

        public static List<Order> SearchRecord_orders(string name)
        {


            List<Order> orders = new List<Order>();

            if (File.Exists(myPath_Order))
            {
                StreamReader sReader = new StreamReader(myPath_Order);
                string line = sReader.ReadLine();

                while (line != null)
                {
                    Order order = new Order();
                    string[] currentLineFields = line.Split(',');
                    if ((currentLineFields[0].Equals(name)) || (currentLineFields[1].Equals(name)) || (currentLineFields[2].Equals(name))||
                        (currentLineFields[3].Equals(name)))
                    {


                        if (currentLineFields[9] == "software")
                        {
                            Order o = new Order();
                            Software soft = new Software();
                            Client c = new Client();

                            o.OrderId = Convert.ToDouble(currentLineFields[0]);
                            soft.ProductID = currentLineFields[1];
                            soft.ProductName = currentLineFields[2];
                            soft.UnitPrice = Convert.ToDouble(currentLineFields[4]);

                            c.Name = currentLineFields[3];

                            o.Amount = Convert.ToDouble(currentLineFields[5]);

                            o.RequiredDate = Convert.ToDateTime(currentLineFields[6]);
                            o.ShippingDate = Convert.ToDateTime(currentLineFields[7]);
                            o.Total1 = Convert.ToDouble(currentLineFields[8]);
                            o.TitleOrder = currentLineFields[9];
                            o.Status = currentLineFields[10];
                            o.Software = soft;
                            o.Client = c;
                            orders.Add(o);

                        }
                        else if (currentLineFields[9] == "book")
                        {
                            Order o = new Order();
                            Book book = new Book();
                            Client c = new Client();
                            o.OrderId = Convert.ToDouble(currentLineFields[0]);
                            book.ProductID = currentLineFields[1];
                            book.ProductName = currentLineFields[2];
                            book.UnitPrice = Convert.ToDouble(currentLineFields[4]);

                            c.Name = currentLineFields[3];

                            o.Amount = Convert.ToDouble(currentLineFields[5]);

                            o.RequiredDate = Convert.ToDateTime(currentLineFields[6]);
                            o.ShippingDate = Convert.ToDateTime(currentLineFields[7]);
                            o.Total1 = Convert.ToDouble(currentLineFields[8]);
                            o.TitleOrder = currentLineFields[9];

                            o.Status = currentLineFields[10];
                            o.Book = book;
                            o.Client = c;
                            orders.Add(o);
                        }


                    }
                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return orders;
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }
        //================ delete one line ==========
        public static void deletLine_order(string del)
        {
            string tempFile = Path.GetTempFileName();
            // StringBuilder sb = new StringBuilder();
            using (var sr = new StreamReader(myPath_Order))
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

            File.Delete(myPath_Order);
            File.Move(tempFile, myPath_Order);
        }

        //============================= End 
    }
}
