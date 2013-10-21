using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryItem
    {
        public int BatteryItemID { get; set; }
        public BatteryModel BatteryModel { get; set; }
       
        public BatteryItem (int batteryItemID, BatteryModel batteryModel)
        {
            BatteryItemID = batteryItemID;
            BatteryModel = batteryModel;
        }

        
    }
}
