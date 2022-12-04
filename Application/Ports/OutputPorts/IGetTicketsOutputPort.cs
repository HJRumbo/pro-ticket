using Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ports.OutputPorts
{
    public interface IGetTicketsOutputPort
    {
        Task GetTicketsHandle(List<TicketDto> tickets);
    }
}
