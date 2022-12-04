using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Carter;
using Presenters.Interfaces;

namespace TicketWebApi.Endpoints
{
    public class TicketEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/Ticket", GetTickets)
            .WithName("GetTickets");
        }

        private static async Task<IResult> GetTickets(IGetTicketsInputPort inputPort, IGetTicketsOutputPort outputPort)
        {
            await inputPort.GetTicketsHandle();
            var tickets = ((IPresenter<List<TicketDto>>)outputPort).Content;

            return Results.Ok(tickets);
        }
    }
}
