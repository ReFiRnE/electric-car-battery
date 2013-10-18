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

        public int HistoryID 
        {
            get 
            {
                return historyID;
            }
            set 
            {
                historyID = value;
            }
        }
        public DateTime DateTaken 
        { 
            get
            {
                return dateTaken;
            }
            set
            {
                dateTaken = value;
            }
        }
        public DateTime DateReturned 
        { 
            get
            {
                return dateReturned;
            }
            set
            {
                dateReturned = value;
            }
        }
        public Car Car 
        { 
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        
        }
        public BatteryItem BatteryItem 
        { 
            get
            {
                return batteryItem;
            }
            set
            {
                batteryItem = value;
            }
        }
    }
}
