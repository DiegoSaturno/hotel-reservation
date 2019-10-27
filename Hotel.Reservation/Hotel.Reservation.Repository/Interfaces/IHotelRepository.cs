using Hotel.Reservation.Domain.HotelAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Repository.Interfaces
{
    public interface IHotelRepository
    {
        public IEnumerable<Domain.HotelAggregate.Hotel> GetAll();
    }
}
