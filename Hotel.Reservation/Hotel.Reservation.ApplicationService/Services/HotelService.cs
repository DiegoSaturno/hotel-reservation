using Hotel.Reservation.ApplicationService.DTOs;
using Hotel.Reservation.ApplicationService.Interfaces;
using Hotel.Reservation.Domain.HotelAggregate;
using Hotel.Reservation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Reservation.ApplicationLayer.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public Domain.HotelAggregate.Hotel FindCheapest(GuestDto guest)
        {
            var hotels = _hotelRepository.GetAll();

            return hotels.FirstOrDefault();
        }
    }
}
