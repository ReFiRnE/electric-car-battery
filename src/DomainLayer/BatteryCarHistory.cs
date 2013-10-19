using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class BatteryCarHistory
    {
        private int historyID;
        private DateTime dateTaken;
        private DateTime dateReturned;
        private Car car;
        private BatteryItem batteryItem;

        public BatteryCarHistory (int historyID, DateTime dateTaken, DateTime dateReturned, Car car, BatteryItem batteryItem)
	    {
            this.historyID = historyID;
            this.dateTaken = dateTaken;
            this.dateReturned = dateReturned;
            this.car = car;
            this.batteryItem = batteryItem;
	    }

        public int HistoryID { get; set; }
        
        public DateTime DateTaken { get; set; }
        
        public DateTime DateReturned { get; set; }

        public Car Car { get; set; }

        public BatteryItem BatteryItem { get; set; }
        
    }
}
