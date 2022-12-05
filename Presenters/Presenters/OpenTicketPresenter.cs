using Application.Dtos;
using Application.Ports.OutputPorts;
using Domain.Common;
using Presenters.Interfaces;

namespace Presenters.Presenters
{
    public class OpenTicketPresenter : IOpenTicketOutputPort, IPresenter<ResponseModel<OpenTicketDto>>
    {
        public ResponseModel<OpenTicketDto>? Content { get; set; }

        public Task OpenTicketHandle(ResponseModel<OpenTicketDto> response)
        {
            Content = response;
            return Task.CompletedTask;
        }
    }
}
