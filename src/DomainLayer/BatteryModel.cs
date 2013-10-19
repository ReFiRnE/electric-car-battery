using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryModel
    {
        private int modelID;
        private string model;
        private double capacity;
        private string type;
        private BatteryManufacturer batteryManufacturer;

        public BatteryModel (int modelID, string model, double capacity, string type, BatteryManufacturer batteryManufacturer)
        {
            this.modelID = modelID;
            this.model = model;
            this.capacity = capacity;
            this.type = type;
            this.batteryManufacturer = batteryManufacturer;
        }

        public int ModelID { get; set; }

        public string Model { get; set; }

        public double Capacity { get; set; }

        public string Type { get; set; }

        private BatteryManufacturer BatteryManufacturer { get; set; }
    }
}
