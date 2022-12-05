using Application.Ports.OutputPorts;
using Microsoft.Extensions.DependencyInjection;
using Presenters.Presenters;

namespace Presenters
{
    public static class DependencyContainers
    {
        public static void AddPresenters(this IServiceCollection services)
        {
            #region Inject Presenters
            services.AddScoped<IGetTicketsOutputPort, GetTicketsPresenter>();
            services.AddScoped<IGetClientsOutputPort, GetClientsPresenter>();
            services.AddScoped<IOpenTicketOutputPort, OpenTicketPresenter>();
            services.AddScoped<ISaveClientOutputPort, SaveClientPresenter>();
            #endregion
        }
    }
}
