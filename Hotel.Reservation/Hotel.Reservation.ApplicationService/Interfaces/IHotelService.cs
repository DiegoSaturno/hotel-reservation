using Hotel.Reservation.ApplicationService.DTOs;
using Hotel.Reservation.Domain.HotelAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.ApplicationService.Interfaces
{
    public interface IHotelService
    {
        public Domain.HotelAggregate.Hotel FindCheapest(GuestDto guest);
    }
}
