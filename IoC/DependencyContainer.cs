using Application;
using Domain.Common;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Presenters;
using RequestApiGateway;

namespace IoC
{
    public static class DependencyContainer
    {
        public static void AddDependecies(this IServiceCollection services, ConnectionDB connection)
        {
            services.AddPersistences(connection);
            services.AddUseCases();
            services.AddPresenters();
            services.AddRequestWebApi();
        }
    }
}