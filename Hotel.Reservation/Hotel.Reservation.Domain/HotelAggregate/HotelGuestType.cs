using Hotel.Reservation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Domain.HotelAggregate
{
    public class HotelGuestType : Enumeration
    {
        public static HotelGuestType Regular { get; } = new HotelGuestType(1, "Regular");
        public static HotelGuestType Reward { get; } = new HotelGuestType(2, "Reward");

        protected HotelGuestType(int id, string name) : base(id, name) { }
    }
}
