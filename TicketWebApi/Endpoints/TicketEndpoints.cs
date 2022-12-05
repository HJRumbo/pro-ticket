using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Carter;
using Domain.Common;
using Microsoft.AspNetCore.Mvc;
using Presenters.Interfaces;

namespace TicketWebApi.Endpoints
{
    public class TicketEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/Ticket/GetTickets", GetTickets)
            .WithName("GetTickets");

            app.MapPost("/api/Ticket/OpenTicket", OpenTicket)
            .WithName("OpenTicket");
        }

        private static async Task<IResult> GetTickets(IGetTicketsInputPort inputPort, IGetTicketsOutputPort outputPort)
        {
            await inputPort.GetTicketsHandle();
            var tickets = ((IPresenter<List<CreateTicketDto>>)outputPort).Content;

            return Results.Ok(tickets);
        }

        private static async Task<IResult> OpenTicket(IOpenTicketInputPort inputPort, IOpenTicketOutputPort outputPort,
            [FromBody] CreateTicketDto ticket,
            [FromHeader] string Authorization)
        {
            await inputPort.OpenTicketHandle(ticket, Authorization);
            var response = ((IPresenter<ResponseModel<CreateTicketDto>>)outputPort).Content;

            return Results.Ok(response);
        }
    }
}
