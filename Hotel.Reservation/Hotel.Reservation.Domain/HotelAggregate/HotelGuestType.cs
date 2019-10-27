using Hotel.Reservation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Reservation.Domain.HotelAggregate
{
    public class HotelGuestType : Enumeration
    {
        public static HotelGuestType Regular { get; } = new HotelGuestType(1, "Regular");
        public static HotelGuestType Rewards { get; } = new HotelGuestType(2, "Rewards");

        protected HotelGuestType(int id, string name) : base(id, name) { }

        public static IEnumerable<HotelGuestType> List() => new List<HotelGuestType>()
        {
            Regular, Rewards
        };

        public static HotelGuestType From(int id)
        {
            var guestType = List().SingleOrDefault(s => s.Id == id);

            if (guestType == null)
            {
                throw new ArgumentException($"Possible values for Guest Type: {String.Join(",", List().Select(s => s.Name))}");
            }

            return guestType;
        }

        public static HotelGuestType FromName(string nome)
        {
            var guestType = List()
                .SingleOrDefault(s => String.Equals(s.Name, nome, StringComparison.CurrentCultureIgnoreCase));

            if (guestType == null)
            {
                throw new ArgumentException($"Possible values for Guest Type: {String.Join(",", List().Select(s => s.Name))}");
            }

            return guestType;
        }
    }
}
