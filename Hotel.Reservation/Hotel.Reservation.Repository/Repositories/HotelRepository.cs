using Hotel.Reservation.Domain.HotelAggregate;
using Hotel.Reservation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Repository.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        public HotelRepository() { }

        public IEnumerable<Domain.HotelAggregate.Hotel> GetAll()
        {
            return new List<Domain.HotelAggregate.Hotel>()
            {
                new Domain.HotelAggregate.Hotel("Lakewood", 3, new List<Domain.HotelAggregate.Reservation>()
                {
                    new Domain.HotelAggregate.Reservation(110m, HotelGuestType.Regular, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(80m, HotelGuestType.Rewards, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(90m, HotelGuestType.Regular, ReservationDayType.Weekend),
                    new Domain.HotelAggregate.Reservation(80m, HotelGuestType.Rewards, ReservationDayType.Weekend)
                }),
                new Domain.HotelAggregate.Hotel("Bridgewood", 4, new List<Domain.HotelAggregate.Reservation>()
                {
                    new Domain.HotelAggregate.Reservation(160m, HotelGuestType.Regular, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(110m, HotelGuestType.Rewards, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(60m, HotelGuestType.Regular, ReservationDayType.Weekend),
                    new Domain.HotelAggregate.Reservation(50m, HotelGuestType.Rewards, ReservationDayType.Weekend)
                }),
                new Domain.HotelAggregate.Hotel("Ridgewood", 5, new List<Domain.HotelAggregate.Reservation>()
                {
                    new Domain.HotelAggregate.Reservation(220m, HotelGuestType.Regular, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(100m, HotelGuestType.Rewards, ReservationDayType.Weekday),
                    new Domain.HotelAggregate.Reservation(150m, HotelGuestType.Regular, ReservationDayType.Weekend),
                    new Domain.HotelAggregate.Reservation(40m, HotelGuestType.Rewards, ReservationDayType.Weekend)
                })
            };
        }
    }
}
