using Application.Ports.InputPorts;
using Application.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyContainer
    {
        public static void AddUseCases(this IServiceCollection services)
        {
            #region Inject Presenters
            services.AddScoped<IGetTicketsInputPort, GetTicketsUseCase>();
            services.AddScoped<IGetClientsInputPort, GetClientsUseCase>();
            services.AddScoped<IOpenTicketInputPort, OpenTicketUseCase>();
            services.AddScoped<ISaveClientInputPort, SaveClientUseCase>();
            #endregion
        }
    }
}
