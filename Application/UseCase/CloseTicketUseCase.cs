using Application.Dtos;
using Application.Ports.InputPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class CloseTicketUseCase : ICloseTicketInputPort
    {
        public Task CloseTicketHandle(CloseTicketDto ticket, string token)
        {
            throw new NotImplementedException();
        }
    }
}
