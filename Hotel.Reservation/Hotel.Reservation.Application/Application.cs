using Hotel.Reservation.Application.Common;
using Hotel.Reservation.ApplicationService.DTOs;
using Hotel.Reservation.ApplicationService.Interfaces;
using Hotel.Reservation.Domain.HotelAggregate;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Hotel.Reservation.Application
{
    public class Application
    {
        protected readonly IHotelService _hotelService;

        public Application(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        public void Run(string[] args)
        {
            Console.WriteLine("Hotel Reservation Problem");

            string filePath = args.FirstOrDefault();
            if (filePath == null)
            {
                Console.WriteLine("Please, inform the full file path to be read: ");
                Console.WriteLine("(e.g.: C:/path/to/your/file)");
                filePath = Console.ReadLine();
            }

            var guests = ReadGuestsData(filePath);

            foreach (var guest in guests)
            {
                var hotel = _hotelService.FindCheapest(guest);

                Console.WriteLine(hotel.Name);
            }
        }

        private IEnumerable<GuestDto> ReadGuestsData(string filePath)
        {
            var guests = new List<GuestDto>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var splittedLine = reader.ReadLine().Split(":");

                    var guestType = HotelGuestType.FromName(splittedLine[0]);
                    var daysOfStaying = ParseDaysOfStaying(splittedLine[1]);

                    guests.Add(new GuestDto(guestType, daysOfStaying));
                }
            }

            return guests;
        }

        static IEnumerable<DateTimeOffset> ParseDaysOfStaying(string daysInLine)
        {
            var dates = new List<DateTimeOffset>();
            var dateList = daysInLine.Split(",");

            foreach (var dateInString in dateList)
            {
                int day = int.Parse(Regex.Match(dateInString, "[0-9]+").Value);
                var year = int.Parse(Regex.Match(dateInString, "[0-9]{4}").Value);

                var monthString = Regex.Match(dateInString, @"(?<=[0-9][0-9])(.*)(?=[0-9]{4})").Value;
                var monthInt = Util.MapMonthNameToValue(monthString);

                dates.Add(new DateTimeOffset(year, monthInt, day, 0, 0, 0, 0, TimeSpan.Zero));
            }

            return dates
                .OrderBy(c => c);
        }
    }
}
