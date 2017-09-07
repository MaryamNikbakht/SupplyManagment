using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject1.DataAccess;

namespace FinalProject1.Business
{
   public class Author:Person
    {
        private int id;

        public int Id
        {
            get {return id;}
            set { id = value;}
        }

        public Author():base()
        {

        }

        public Author(int id,string fname,string lname): base(fname, lname)
        {
            this.id = id;
            base.FirstName = fname;
            base.LastName = lname;
        }
    }
}
