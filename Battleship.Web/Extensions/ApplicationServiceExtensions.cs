using Battleship.Application.Interfaces;
using Battleship.Application.Services.ShipServices;

namespace Battleship.Web.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IShipFactoryService, ShipFactoryService>();
            return services;
        }
    }
}
