using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Car
    {
        private int carID;
        private double range;
        private double capacity;
        private Customer customer;

        public Car (int carID, double range, double capacity, Customer customer)
        {
            this.carID = carID;
            this.range = range;
            this.capacity = capacity;
            this.customer = customer;
        }

        public int CarID { get; set; }

        public double Range { get; set; }

        public double Capacity { get; set; }

        public Customer Customer { get; set; }
    }
}
