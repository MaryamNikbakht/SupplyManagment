using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.GUI;

namespace FinalProject1.Business
{
    [Serializable]
    public class Publisher
    {
        private string publisherName;

        public string PublisherName
        {
            get { return publisherName; }
            set { publisherName = value; }
        }
        public Publisher()
        {
            this.publisherName = "";
        }
        public Publisher(string name)
        {
            this.publisherName = name;
        }
    }
}
