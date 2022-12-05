using Application.Dtos;

namespace Application.Ports.OutputPorts
{
    public interface IGetTicketsOutputPort
    {
        Task GetTicketsHandle(List<OpenTicketDto> tickets);
    }
}
