using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryModel
    {
        public int ModelID { get; set; }
        public string Model { get; set; }
        public double Capacity { get; set; }
        public string Type { get; set; }
        private BatteryManufacturer BatteryManufacturer { get; set; }

        public BatteryModel (int modelID, string model, double capacity, string type, BatteryManufacturer batteryManufacturer)
        {
            ModelID = modelID;
            Model = model;
            Capacity = capacity;
            Type = type;
            BatteryManufacturer = batteryManufacturer;
        }

        
    }
}
