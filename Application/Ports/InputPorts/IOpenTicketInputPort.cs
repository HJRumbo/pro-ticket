using Application.Dtos;

namespace Application.Ports.InputPorts
{
    public interface IOpenTicketInputPort
    {
        Task OpenTicketHandle(CreateTicketDto ticket, string token);
    }
}
