using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using FinalProject1.Business;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalProject1.DataAccess
{
    
   public static class InventoryIO
    {
        //static string dir = Environment.CurrentDirectory;
        //static string myPath_inventory_Book = dir + "Inventorybook.dat";

        const string dir = @"";
        const string myPath_inventory_Book = dir + "Inventorybook.dat";
        const string myPath_inventory_Book_xml = dir + "Inventorybookxml.xml";
        const string myPath_inventory_Software = dir + "InventorySoftware.dat";

        // List<Book> books = new List<Book>();
        public static List<Book> books = new List<Book>();
        //===================Write XM
        public static void WriteXML_List(Book book)
        {
            XmlWriterSettings settings = new XmlWriterSettings();

            XmlWriter xmlWriter = XmlWriter.Create(myPath_inventory_Book_xml, settings);
            settings.Indent = true;
            settings.IndentChars = (" ");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("ArrayOfProduct");//Begin of all Product

        
              
                xmlWriter.WriteStartElement("Book");

                xmlWriter.WriteStartElement("ISBN");//Begin of ISBN
                xmlWriter.WriteString(book.ProductID);
                xmlWriter.WriteEndElement();//End of ISBN

                xmlWriter.WriteStartElement("Title");//Begin of Title
                xmlWriter.WriteString(book.ProductName);
                xmlWriter.WriteEndElement();//End of Title

                xmlWriter.WriteStartElement("UnitPrice");//Begin of UnitPrice
                xmlWriter.WriteString(book.UnitPrice.ToString());
                xmlWriter.WriteEndElement();//End of UnitPrice

                xmlWriter.WriteStartElement("YearPublished");//Begin of YearPublished
                xmlWriter.WriteString(book.YearOfPublish.ToString());
                xmlWriter.WriteEndElement();//End of YearPublished

                xmlWriter.WriteStartElement("QOH");//Begin of QOH
                xmlWriter.WriteString(book.AmountInStock.ToString());
                xmlWriter.WriteEndElement();//End of QOH

                xmlWriter.WriteStartElement("Category");//Begin of Category
                xmlWriter.WriteString(book.BookType.ToString());
                xmlWriter.WriteEndElement();//End of Category

                xmlWriter.WriteStartElement("AuthorID");//Begin of AuthorID
                xmlWriter.WriteString(book.Author.Id.ToString());
                xmlWriter.WriteEndElement();//End of AuthorID

                xmlWriter.WriteStartElement("AuthorFNAme");//Begin of AuthorFNAme
                xmlWriter.WriteString(book.Author.FirstName);
                xmlWriter.WriteEndElement();//End of AuthorFNAme

                xmlWriter.WriteStartElement("AuthorLNAme");//Begin of AuthorLNAme
                xmlWriter.WriteString(book.Author.LastName);
                xmlWriter.WriteEndElement();//End of AuthorLNAme

                xmlWriter.WriteStartElement("Publisher");//Begin of Publisher
             //   xmlWriter.WriteString(book.Publisher.PublisherName);
                xmlWriter.WriteString(book.Publisher);
                xmlWriter.WriteEndElement();//End of Publisher

                xmlWriter.WriteEndElement();//End of Book
         //   }

            xmlWriter.WriteEndDocument();//End of all Product
            xmlWriter.Close();
            MessageBox.Show("Saved");
        }
        //===================== save text file
        public static void saveRecord(Book book)
        {
            // create the output stream for a text file that exists
            using (StreamWriter textout = new StreamWriter(myPath_inventory_Book, true))
            {

                // write the fields into text file
                textout.WriteLine(book.ProductID + "," + book.ProductName + "," + book.UnitPrice+ "," + book.YearOfPublish + "," + book.AmountInStock+ "," + book.BookType + "," + book.Author.Id + "," + book.Author.FirstName + "," + book.Author.LastName + "," + book.Publisher);
            }

        }
        //================================== serialization 

        public static void serializationObject()
        {


          //  MessageBox.Show("Testinv");

            string f = "";
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            f = myPath_inventory_Book;
            sw = File.Open(f, FileMode.Create);
            bf.Serialize(sw, books);
            sw.Close();
        }




        //============ deserialization

        public static void deserializationObject(List<Book> book)
        {

            
                Stream sr;
                BinaryFormatter bf = new BinaryFormatter();
                sr = File.OpenRead(myPath_inventory_Book);

                  book = (List<Book>)bf.Deserialize(sr);
                sr.Close();
            
        }

        //=========== read text file

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
                        Author a = new Author();
                        book.ProductID = currentLineFields[0];
                        book.ProductName = currentLineFields[1];
                        book.UnitPrice = Convert.ToDouble(currentLineFields[2]);
                        book.YearOfPublish = currentLineFields[3];
                        book.AmountInStock = Convert.ToDouble(currentLineFields[4]);
                        book.BookType = currentLineFields[5];
                        
                        a.Id = Convert.ToInt32(currentLineFields[6]);
                        a.FirstName = currentLineFields[7];                       
                        a.LastName = currentLineFields[8];

                        book.Publisher = currentLineFields[9];

                        book.Author = a;

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
        //============================== serach 
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
                        Author a = new Author();
                        book.ProductID = currentLine[0];
                        book.ProductName = currentLine[1];
                        book.UnitPrice = Convert.ToDouble(currentLine[2]);
                        book.YearOfPublish = currentLine[3];
                        book.AmountInStock = Convert.ToDouble(currentLine[4]);
                        book.BookType = currentLine[5];

                        a.Id = Convert.ToInt32(currentLine[6]);
                        a.FirstName = currentLine[7];
                        a.LastName = currentLine[8];

                        book.Publisher = currentLine[9];

                        book.Author = a;
                                               
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

//===================================== delete one line
        public static void deletLine_book(string del)
        {
            string tempFile = Path.GetTempFileName();
            // StringBuilder sb = new StringBuilder();
            using (var sr = new StreamReader(myPath_inventory_Book))
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

            File.Delete(myPath_inventory_Book);
            File.Move(tempFile, myPath_inventory_Book);
        }

        //=================================== delete Last Line
        public static void Delete_lastLine()
        {

            var lines = File.ReadAllLines(myPath_inventory_Book);
            File.WriteAllLines(myPath_inventory_Book, lines.Take(lines.Length - 1).ToArray());

        }

        //=========================== ID uniq

        public static bool ID_Validation_Uniq(string id)
        {
            bool idIsValid = false;

            if (File.Exists(myPath_inventory_Book))
            {
                StreamReader sr = new StreamReader(myPath_inventory_Book);
                string newLine = sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    string[] userline = newLine.Split(',');
                    if (userline[0] == id)
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
        //========================== write text file software
        public static void saveRecord(Software soft)
        {
            // create the output stream for a text file that exists
            using (StreamWriter textout = new StreamWriter(myPath_inventory_Software, true))
            {            
                                
                // write the fields into text file
                textout.WriteLine(soft.ProductID + "," + soft.ProductName + "," + soft.UnitPrice + "," + soft.AmountInStock + "," + soft.SoftwareType + "," + soft.Publisher);
            }

        }
        //====================================== Read text file software

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
                        Software soft= new Software();

                        soft.ProductID = currentLineFields[0];
                        soft.ProductName = currentLineFields[1];
                        soft.UnitPrice = Convert.ToDouble(currentLineFields[2]);                        
                        soft.AmountInStock = Convert.ToDouble(currentLineFields[3]);
                        soft.SoftwareType = currentLineFields[4];
                        soft.Publisher = currentLineFields[5];

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

        //============================== search software 

        public static List<Software> SearchRecord_soft(string name)
        {
            List<Software> listsoft = new List<Software>();

            if (File.Exists(myPath_inventory_Software))
            {
                //Creation of the object of StreamReader
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
                        soft.Publisher = currentLine[5];

                        listsoft.Add(soft);

                    }

                   
                    line = sReader.ReadLine();
                }

                sReader.Close();
                return listsoft;
            }
            else
            {
                MessageBox.Show("Data Not Found!");
                return null;
            }

        }

        //===================================== delete one line software
        public static void deletLine_software(string del)
        {
            string tempFile = Path.GetTempFileName();
            // StringBuilder sb = new StringBuilder();
            using (var sr = new StreamReader(myPath_inventory_Software))
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

            File.Delete(myPath_inventory_Software);
            File.Move(tempFile, myPath_inventory_Software);
        }

        //=================================== delete Last Line software
        public static void Delete_lastLine_soft()
        {

            var lines = File.ReadAllLines(myPath_inventory_Software);
            File.WriteAllLines(myPath_inventory_Software, lines.Take(lines.Length - 1).ToArray());

        }

        //=========================== ID uniq software

        public static bool ID_Validation_Uniq_soft(string id)
        {
            bool idIsValid = false;

            if (File.Exists(myPath_inventory_Software))
            {
                StreamReader sr = new StreamReader(myPath_inventory_Software);
                string newLine = sr.ReadLine();
                while (sr.Peek() != -1)
                {
                    string[] userline = newLine.Split(',');
                    if (userline[0] == id)
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

        //=================== End
    }
}
