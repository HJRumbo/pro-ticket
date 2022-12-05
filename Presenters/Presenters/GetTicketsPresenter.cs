using Application.Dtos;
using Application.Ports.OutputPorts;
using Presenters.Interfaces;

namespace Presenters.Presenters
{
    public class GetTicketsPresenter : IGetTicketsOutputPort, IPresenter<List<OpenTicketDto>>
    {
        public List<OpenTicketDto>? Content { get; set; }

        public Task GetTicketsHandle(List<OpenTicketDto> tickets)
        {
            Content = tickets;
            return Task.CompletedTask;
        }
    }
}
