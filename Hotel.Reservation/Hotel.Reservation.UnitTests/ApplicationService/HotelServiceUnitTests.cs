using Hotel.Reservation.ApplicationLayer.Services;
using Hotel.Reservation.ApplicationService.DTOs;
using Hotel.Reservation.Domain.HotelAggregate;
using Hotel.Reservation.UnitTests.ApplicationService.Doubles;
using System;
using System.Collections.Generic;
using Xunit;

namespace Hotel.Reservation.UnitTests.ApplicationService
{
    public class HotelServiceUnitTests
    {
        private readonly HotelService _hotelService;        

        public HotelServiceUnitTests() {
            _hotelService = new HotelService(new HotelRepositoryTestDouble());
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void ShouldReturnCheapestHotel(GuestDto guest, string hotelName)
        {
            var result = _hotelService.FindCheapest(guest);
            Assert.Equal(hotelName, result.Name);
        }

        public static GuestDto rewardGuest { get; } = new GuestDto(HotelGuestType.Rewards, new List<DateTimeOffset>()
        {
            new DateTimeOffset(2018, 7, 1, 0, 0, 0, 0, TimeSpan.Zero),
            new DateTimeOffset(2018, 7, 2, 0, 0, 0, 0, TimeSpan.Zero),
            new DateTimeOffset(2018, 7, 3, 0, 0, 0, 0, TimeSpan.Zero),
        });

        private static GuestDto regularGuest = new GuestDto(HotelGuestType.Regular, new List<DateTimeOffset>()
        {
            new DateTimeOffset(2018, 7, 1, 0, 0, 0, 0, TimeSpan.Zero),
            new DateTimeOffset(2018, 7, 2, 0, 0, 0, 0, TimeSpan.Zero),
            new DateTimeOffset(2018, 7, 3, 0, 0, 0, 0, TimeSpan.Zero),
        });

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] { rewardGuest, "Hotel Number 2" },
                new object[] { regularGuest, "Hotel Number 3" },
            };
    }
}
