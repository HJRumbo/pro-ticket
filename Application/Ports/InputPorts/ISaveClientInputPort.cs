using Application.Dtos;

namespace Application.Ports.InputPorts
{
    public interface ISaveClientInputPort
    {
        Task SaveClientHandle(ClientDto client);
    }
}
