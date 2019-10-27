using Hotel.Reservation.ApplicationLayer.Services;
using Hotel.Reservation.ApplicationService.Interfaces;
using Hotel.Reservation.Domain.HotelAggregate;
using Hotel.Reservation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.UnitTests.ApplicationService.Doubles
{
    public class HotelRepositoryTestDouble : IHotelRepository
    {
        public IEnumerable<Domain.HotelAggregate.Hotel> GetAll()
        {
            return new List<Domain.HotelAggregate.Hotel>()
            {
                new Domain.HotelAggregate.Hotel("Hotel Number 1", 3, new List<Domain.HotelAggregate.Reservation>()
                {
                    new Domain.HotelAggregate.Reservation(105m, HotelGuestType.Regular, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(98m, HotelGuestType.Rewards, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(30m, HotelGuestType.Regular, ReservationDayType.Weekend),
                    new Domain.HotelAggregate.Reservation(50m, HotelGuestType.Rewards, ReservationDayType.Weekend)
                }),
                new Domain.HotelAggregate.Hotel("Hotel Number 2", 4, new List<Domain.HotelAggregate.Reservation>()
                {
                    new Domain.HotelAggregate.Reservation(100m, HotelGuestType.Regular, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(100m, HotelGuestType.Rewards, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(50m, HotelGuestType.Regular, ReservationDayType.Weekend),
                    new Domain.HotelAggregate.Reservation(10m, HotelGuestType.Rewards, ReservationDayType.Weekend)
                }),
                new Domain.HotelAggregate.Hotel("Hotel Number 3", 4, new List<Domain.HotelAggregate.Reservation>()
                {
                    new Domain.HotelAggregate.Reservation(105m, HotelGuestType.Regular, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(98m, HotelGuestType.Rewards, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(30m, HotelGuestType.Regular, ReservationDayType.Weekend),
                    new Domain.HotelAggregate.Reservation(50m, HotelGuestType.Rewards, ReservationDayType.Weekend)
                }),
            };
        }
    }
}
