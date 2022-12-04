using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Application.UseCase;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class DependencyContainer
    {
        public static void AddUseCases(this IServiceCollection services)
        {
            #region Inject Presenters
            services.AddScoped<IGetTicketsInputPort, GetTicketsUseCase>();
            #endregion
        }
    }
}
