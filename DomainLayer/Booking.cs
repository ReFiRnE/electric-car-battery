using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Booking
    {
        private int bookingID;
        private DateTime date;
        private Car car;
        private BatteryItem batteryItem;

        public Booking(int bookingID, DateTime date, Car car, BatteryItem batteryItem)
        {
            this.bookingID = bookingID;
            this.date = date;
            this.car = car;
            this.batteryItem = batteryItem;
        }

        public int BookingID 
        { 
            get
            {
                return bookingID;
            }
            set
            {
                bookingID = value;
            }
        }

        public DateTime Date 
        { 
            get
            {
                return date;
            }
            set
            {
                date = value;
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
