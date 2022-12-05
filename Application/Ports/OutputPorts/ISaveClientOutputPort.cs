using Application.Dtos;
using Domain.Common;

namespace Application.Ports.OutputPorts
{
    public interface ISaveClientOutputPort
    {
        Task SaveClientHandle(ResponseModel<ClientDto> response);
    }
}
