using Domain.Common;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            #endregion
        }
    }
}
