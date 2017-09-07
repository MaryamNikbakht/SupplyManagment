using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FinalProject1.Business
{
    [Serializable]
  //  public enum SpecialityType { Database,Java,Csharp,CPlusPlus,Network,AdvanceC,PHP }

    public class Book:Product
    {        
        private Author author;
        private string bookType;
        private string yearOfPublish;
        private string ISBN;

        public Author Author
        {
            get { return author; }
            set { author = value; }
        }

        public string BookType
        {
            get {return bookType; }
            set { bookType = value; }
        }

        public string YearOfPublish
        {
            get { return yearOfPublish; }
            set {yearOfPublish = value; }
        }

        //public override string ProductID()
        //{
        //    return this.ISBN;
        //}

        public Book():base()
        {
            
        }
        public Book(double amountInStock,string productID, string productName,double unitPrice,string publisher, string bookType , string YearOfPublish,Author author) :
            base(amountInStock, productID, productName, unitPrice, publisher)
        {
            this.bookType = bookType;
            this.yearOfPublish = YearOfPublish;
        }

        public static void WriteXML_List_book(Book books)
        {
            InventoryIO.WriteXML_List(books);
           
        }

        public static void serializationObject_book()
        {
            
            InventoryIO.serializationObject();
        }

        public static void saveRecord_text(Book book)
        {
            InventoryIO.saveRecord(book);
           
        }

        public static void deserializationObject_book(List<Book> book)
        {
            InventoryIO.deserializationObject(book);
        }

        public static List<Book> ListAll_Books()
        {
            return InventoryIO.ListBooks();
        }

        public static List<Book> Search_book(string name)
        {
            return InventoryIO.SearchRecord_book(name);
        }

        public static void delete_book(string del)
        {
            InventoryIO.deletLine_book(del);
        }

        public static void Delete_lastLineBook()
        {
            InventoryIO.Delete_lastLine();
        }

        public static bool ID_Validation_Uniq_ISBN(string id)
        {
            return InventoryIO.ID_Validation_Uniq(id);
        }
    }
}
