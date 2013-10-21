using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryCarHistory
    {
        public int HistoryID { get; set; }
        public DateTime DateTaken { get; set; }
        public DateTime DateReturned { get; set; }
        public Car Car { get; set; }
        public BatteryItem BatteryItem { get; set; }

        public BatteryCarHistory (int historyID, DateTime dateTaken, DateTime dateReturned, Car car, BatteryItem batteryItem)
	    {
            HistoryID = historyID;
            DateTaken = dateTaken;
            DateReturned = dateReturned;
            Car = car;
            BatteryItem = batteryItem;
	    }     
    }
}
