using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryItem
    {
        private int batteryItemID;
        private BatteryModel batteryModel;

        public BatteryItem (int batteryItemID, BatteryModel batteryModel)
        {
            this.batteryItemID = batteryItemID;
            this.batteryModel = batteryModel;
        }

        public int BatteryItemID { get; set; }

        public BatteryModel BatteryModel { get; set; }
    }
}
