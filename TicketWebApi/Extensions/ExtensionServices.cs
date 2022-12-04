using Domain.Common;
using IoC;

namespace TicketWebApi.Extensions
{
    public static class ExtensionServices
    {
        public static void DependencyInjections(this WebApplicationBuilder builder)
        {
            var connection = new ConnectionDB();

            connection.ConnectionString = builder.Configuration.GetConnectionString("ConnectionString");

            builder.Services.AddSingleton(connection);

            builder.Services.AddDependecies(connection);
        }
    }
}
