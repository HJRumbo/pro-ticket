using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Domain.Common;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.RequestApiGateway;
using Shared;

namespace Application.UseCase
{
    public class OpenTicketUseCase : IOpenTicketInputPort
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IParkerWebApi _parkerWebApi;
        private readonly IOpenTicketOutputPort _output;

        public OpenTicketUseCase(ITicketRepository ticketRepository,
            IClientRepository clientRepository,
            IParkerWebApi parkerWebApi,
            IOpenTicketOutputPort output)
        {
            _ticketRepository = ticketRepository;
            _clientRepository = clientRepository;
            _parkerWebApi = parkerWebApi;
            _output = output;
        }

        public async Task OpenTicketHandle(CreateTicketDto ticket, string token)
        {
            var client = await _clientRepository.GetClientById(ticket.IdClient);

            if (client == null)
                throw new Exception("El cliente no existe");

            var tariff = await _parkerWebApi.GetTariff(ticket.typeBay!, token);

            var newTicket = MyMapper<CreateTicketDto, Ticket>.ObjectMap(ticket);

            newTicket.IdTariff = tariff.IdTariff;
            newTicket.CostHour = tariff.CostHour;

            ResponseModel<CreateTicketDto> response = new()
            {
                IsSuccess = await _ticketRepository.OpenTicket(MyMapper<CreateTicketDto, Ticket>.ObjectMap(ticket))
            };

            if (response.IsSuccess)
            {
                response.Result = ticket;

                await _output.OpenTicketHandle(response);
            }
        }
    }
}
