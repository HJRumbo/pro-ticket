using Application.Dtos;
using Application.Ports.OutputPorts;
using Domain.Common;
using Presenters.Interfaces;

namespace Presenters.Presenters
{
    internal class OpenTicketPresenter : IOpenTicketOutputPort, IPresenter<ResponseModel<CreateTicketDto>>
    {
        public ResponseModel<CreateTicketDto>? Content { get; set; }

        public Task OpenTicketHandle(ResponseModel<CreateTicketDto> response)
        {
            Content = response;
            return Task.CompletedTask;
        }
    }
}
