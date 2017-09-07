using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;

namespace FinalProject1.Business
{
    [Serializable]
    public abstract class Product
    {
        protected double amountInStock;
        protected string productID;
        protected string productName;
        protected double unitPrice;
        private string publisher;

    //    private Publisher publisher;
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public double AmountInStock
        {
            get { return amountInStock; }
            set { amountInStock = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        //public Publisher Publisher
        //{
        //    get { return publisher; }
        //    set { publisher = value; }
        //}

        public Product()
        {
        
        }
        public Product(double amountInStock, string productID,string productName,double unitPrice,string publisher)
        {
            this.amountInStock = amountInStock;
            this.productID = productID;
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.publisher = publisher;
       //     this.publisher = new Publisher();

        }


      

    }
}
