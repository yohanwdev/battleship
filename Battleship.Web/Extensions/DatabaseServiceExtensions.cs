using Battleship.Data;
using Microsoft.EntityFrameworkCore;

namespace Battleship.Web.Extensions
{
    public static class DatabaseServiceExtensions
    {
        public static IServiceCollection AddDBContextServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<BattleshipContext>(option =>
                option.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
