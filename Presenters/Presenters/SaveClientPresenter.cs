using Application.Dtos;
using Application.Ports.OutputPorts;
using Domain.Common;
using Presenters.Interfaces;

namespace Presenters.Presenters
{
    public class SaveClientPresenter : ISaveClientOutputPort, IPresenter<ResponseModel<ClientDto>>
    {
        public ResponseModel<ClientDto>? Content { get; set; }

        public Task SaveClientHandle(ResponseModel<ClientDto> response)
        {
            Content = response;
            return Task.CompletedTask;
        }
    }
}
