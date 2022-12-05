using Application.Dtos;

namespace Application.Ports.InputPorts
{
    public interface IOpenTicketInputPort
    {
        Task OpenTicketHandle(OpenTicketDto ticket, string token);
    }
}
