using Application.Dtos;
using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Ports.OutputPorts
{
    public interface ICloseTicketOutputPort
    {
        Task CloseTicketHandle(ResponseModel<OpenTicketDto> response);
    }
}
