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

        public int BookingID { get; set; }


        public DateTime Date { get; set; }


        public Car Car { get; set; }


        public BatteryItem BatteryItem { get; set; }
        
    }
}
