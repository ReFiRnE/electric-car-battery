using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Customer
    {
        private int customerID;
        private string name;

        public Customer (int customerID, string name)
        {
            this.customerID = customerID;
            this.name = name;
        }

        public int CustomerID { get; set; }

        public string Name { get; set; }
    }
}
