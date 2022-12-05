using Domain.Interfaces.RequestApiGateway;
using Microsoft.Extensions.DependencyInjection;

namespace RequestApiGateway
{
    public static class DependencyContainer
    {
        public static void AddRequestWebApi(this IServiceCollection services)
        {
            #region Inject RequestWebApi
            services.AddScoped<IParkerWebApi, ParkerWebApi>();
            #endregion
        }
    }
}
