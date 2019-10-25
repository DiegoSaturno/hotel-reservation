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
    }
}
