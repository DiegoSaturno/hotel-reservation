using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Domain.HotelAggregate
{
    public class Reservation
    {
        public decimal Value { get; private set; }
        public HotelGuestType GuestType { get; private set; }
        public ReservationDayType DayType { get; private set; }

        public Reservation(decimal value, HotelGuestType guestType, ReservationDayType dayType)
        {
            Value = value;
            GuestType = guestType;
            DayType = dayType;
        }
    }
}
