using Application.Ports.OutputPorts;
using Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Presenters.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters
{
    public static class DependencyContainers
    {
        public static void AddPresenters(this IServiceCollection services)
        {
            #region Inject Presenters
            services.AddScoped<IGetTicketsOutputPort, GetTicketsPresenter>();
            #endregion
        }
    }
}
