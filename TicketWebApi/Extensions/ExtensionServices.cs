using Domain.Common;
using Domain.Interfaces.RequestApiGateway;
using IoC;
using RequestApiGateway;
using System.Net.Http.Headers;

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

        public static void AddHttpClient(this WebApplicationBuilder builder)
        {
            builder.Services.AddHttpClient<IParkerWebApi, ParkerWebApi>(
                client =>
                {
                    client.BaseAddress = new Uri("http://api-gateway:3000");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                });
        }
    }
}
