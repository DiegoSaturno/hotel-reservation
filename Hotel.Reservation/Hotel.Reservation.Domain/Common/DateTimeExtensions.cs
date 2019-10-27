using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Reservation.Domain.Common
{
    public static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTimeOffset date)
        {
            return date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}
