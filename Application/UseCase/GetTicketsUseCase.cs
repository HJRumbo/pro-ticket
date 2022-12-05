using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Shared;

namespace Application.UseCase
{
    public class GetTicketsUseCase : IGetTicketsInputPort
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IGetTicketsOutputPort _output;

        public GetTicketsUseCase(ITicketRepository ticketRepository, IGetTicketsOutputPort output)
        {
            _ticketRepository = ticketRepository;
            _output = output;
        }

        public async Task GetTicketsHandle()
        {

            var tickets = MyMapper<Ticket, OpenTicketDto>.ListMap(await _ticketRepository.GetTickets());

            await _output.GetTicketsHandle(tickets);
        }
    }
}
