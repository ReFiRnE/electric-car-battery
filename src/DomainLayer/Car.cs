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

        public Car (int carID, double range, double capacity)
        {
            this.carID = carID;
            this.range = range;
            this.capacity = capacity;
        }

        public int CarID { get; set; }

        public double Range { get; set; }

        public double Capacity { get; set; }
    }
}
