using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1.Business
{
    public class Person
    {
        private string firstName;
        private string lastName;
        /// <summary>
        /// Property of firstName
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        /// <summary>
        /// Property of lastName
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Person(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person()
        {

        }

    }
}
