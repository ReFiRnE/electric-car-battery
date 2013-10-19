using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryManufacturer
    {
        private int id;
        private string name;

        public BatteryManufacturer (int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
