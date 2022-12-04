using Application.Dtos;
using Application.Ports.OutputPorts;
using Domain.Entities;
using Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenters.Presenters
{
    public class GetTicketsPresenter : IGetTicketsOutputPort, IPresenter<List<TicketDto>>
    {
        public List<TicketDto>? Content { get; set; }

        public Task GetTicketsHandle(List<TicketDto> tickets)
        {
            Content = tickets;
            return Task.CompletedTask;
        }
    }
}
