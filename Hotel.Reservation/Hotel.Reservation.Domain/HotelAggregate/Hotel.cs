using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Domain.HotelAggregate
{
    public class Hotel
    {
        public string Name { get; private set; }
        public int Rating { get; private set; }
        public IEnumerable<Reservation> ReservationValues;

        public Hotel() { }

        public Hotel(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }
    }
}
