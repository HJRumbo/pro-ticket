using Application.Dtos;
using Application.Ports.OutputPorts;
using Presenters.Interfaces;

namespace Presenters.Presenters
{
    public class GetTicketsPresenter : IGetTicketsOutputPort, IPresenter<List<CreateTicketDto>>
    {
        public List<CreateTicketDto>? Content { get; set; }

        public Task GetTicketsHandle(List<CreateTicketDto> tickets)
        {
            Content = tickets;
            return Task.CompletedTask;
        }
    }
}
