using Hotel.Reservation.Domain.HotelAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.ApplicationService.DTOs
{
    public class GuestDto
    {
        public HotelGuestType GuestType { get; private set; }
        public IEnumerable<DateTimeOffset> DaysOfStaying { get; private set; }

        public GuestDto() { }

        public GuestDto(HotelGuestType guestType, IEnumerable<DateTimeOffset> daysOfStaying)
        {
            GuestType = guestType;
            DaysOfStaying = daysOfStaying;
        }
    }
}
