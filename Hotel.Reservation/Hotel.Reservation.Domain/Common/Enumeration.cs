using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Domain.Common
{
    public class Enumeration
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        protected Enumeration(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static bool operator == (Enumeration enum1, Enumeration enum2)
        {
            if (enum1 is null) { return enum2 is null; }
            if (enum2 is null) { return enum1 is null; }

            return (enum1.Id == enum2.Id && enum1.Name == enum2.Name);
        }

        public static bool operator != (Enumeration enum1, Enumeration enum2)
        {
            if (enum1 is null) { return !(enum2 is null); }
            if (enum2 is null) { return !(enum1 is null); }

            return (enum1.Id != enum2.Id && enum1.Name != enum2.Name);
        }
    }
}
