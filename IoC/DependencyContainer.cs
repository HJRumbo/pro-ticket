using Application;
using Domain.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Presenters;

namespace IoC
{
    public static class DependencyContainer
    {
        public static void AddDependecies(this IServiceCollection services, ConnectionDB connection)
        {
            services.AddPersistences(connection);
            services.AddUseCases();
            services.AddPresenters();
        }
    }
}