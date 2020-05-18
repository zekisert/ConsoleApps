using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public string City { get; set; }
        public int Id { get; set; }
        private string _Firstname;
        public string FirstName 
        {
            get { return "Mrs." + _Firstname; }
            set { _Firstname = value; }
        
        }
        public string LastName { get; set; }
    }
}
