using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryManufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public BatteryManufacturer (int id, string name)
        {
            ID = id;
            Name = name;
        }


        
    }
}
