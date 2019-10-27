using Hotel.Reservation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Reservation.Domain.HotelAggregate
{
    public class ReservationDayType : Enumeration
    {
        public static ReservationDayType Weekday => new ReservationDayType(1, "Weekday");
        public static ReservationDayType Weekend => new ReservationDayType(2, "Weekend");

        protected ReservationDayType(int id, string name) : base(id, name) { }

        public static IEnumerable<ReservationDayType> List() => new List<ReservationDayType>()
        {
            Weekday, Weekend
        };

        public static ReservationDayType From(int id)
        {
            var dayType = List().SingleOrDefault(s => s.Id == id);

            if (dayType == null)
            {
                throw new ArgumentException($"Possible values for Reservation Day Type: {String.Join(",", List().Select(s => s.Name))}");
            }

            return dayType;
        }
    }
}
