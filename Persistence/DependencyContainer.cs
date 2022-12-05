using Domain.Common;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;

namespace Persistence
{
    public static class DependencyContainer
    {
        public static void AddPersistences(this IServiceCollection services, ConnectionDB connection)
        {
            services.AddDbContext<ParkerDbContext>(options =>
                options.UseNpgsql(connection.ConnectionString!));

            #region Inject Repositories
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            #endregion
        }
    }
}
