using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Booking
    {
        public int BookingID { get; set; }
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        public BatteryItem BatteryItem { get; set; }
        
        public Booking(int bookingID, DateTime date, Car car, BatteryItem batteryItem)
        {
            BookingID = bookingID;
            Date = date;
            Car = car;
            BatteryItem = batteryItem;
        }

    }
}
