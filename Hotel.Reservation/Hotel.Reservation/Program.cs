
using Autofac;
using Hotel.Reservation.ApplicationLayer.Services;
using Hotel.Reservation.ApplicationService.Interfaces;
using Hotel.Reservation.Repository.Interfaces;
using Hotel.Reservation.Repository.Repositories;

namespace Hotel.Reservation
{
    public class Program
    {
        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();
            builder
                .RegisterType<Application.Application>();

            builder
                .RegisterType<HotelService>()
                .As<IHotelService>()
                .InstancePerLifetimeScope();

            builder
                .RegisterType<HotelRepository>()
                .As<IHotelRepository>()
                .InstancePerLifetimeScope();

            return builder.Build();
        }

        public static void Main(string[] args)
        {
            CompositionRoot()
                .Resolve<Application.Application>()
                .Run(args);
        }
    }
}
