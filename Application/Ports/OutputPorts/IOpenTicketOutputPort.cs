using Application.Dtos;
using Domain.Common;

namespace Application.Ports.OutputPorts
{
    public interface IOpenTicketOutputPort
    {
        Task OpenTicketHandle(ResponseModel<OpenTicketDto> response);
    }
}
