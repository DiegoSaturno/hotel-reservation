using Hotel.Reservation.ApplicationService.Common;
using Hotel.Reservation.ApplicationService.DTOs;
using Hotel.Reservation.ApplicationService.Interfaces;
using Hotel.Reservation.Domain.HotelAggregate;
using Hotel.Reservation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var _valuesPerHotel = new List<Tuple<Domain.HotelAggregate.Hotel, decimal>>();
            var hotels = _hotelRepository.GetAll();

            foreach (var hotel in hotels)
            {
                var reservationSum = 0m;
                foreach (var day in guest.DaysOfStaying)
                {
                    var dayType = day.IsWeekend()
                        ? ReservationDayType.Weekend
                        : ReservationDayType.Weekday;

                    var reservationTypeByDayAndGuestType = hotel.ReservationValues
                        .FirstOrDefault(r => r.GuestType == guest.GuestType && r.DayType == dayType);

                    if (reservationTypeByDayAndGuestType != null)
                        reservationSum += reservationTypeByDayAndGuestType.Value;
                }

                _valuesPerHotel.Add(new Tuple<Domain.HotelAggregate.Hotel, decimal>(hotel, reservationSum));
            }

            var cheapestHotelInTuple = _valuesPerHotel
                .OrderBy(t => t.Item2)
                .ThenByDescending(t => t.Item1.Rating)
                .FirstOrDefault();

            return cheapestHotelInTuple.Item1;
        }
    }
}
