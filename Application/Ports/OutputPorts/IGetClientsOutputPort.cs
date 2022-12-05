using Application.Dtos;

namespace Application.Ports.OutputPorts
{
    public interface IGetClientsOutputPort
    {
        Task GetClientsHandle(List<ClientDto> clients);
    }
}
