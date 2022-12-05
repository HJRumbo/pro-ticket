using Application.Dtos;
using Application.Ports.OutputPorts;
using Presenters.Interfaces;

namespace Presenters.Presenters
{
    public class GetClientsPresenter : IGetClientsOutputPort, IPresenter<List<ClientDto>>
    {
        public List<ClientDto>? Content { get; set; }

        public Task GetClientsHandle(List<ClientDto> clients)
        {
            Content = clients;
            return Task.CompletedTask;
        }
    }
}
