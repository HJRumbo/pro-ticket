using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Carter;
using Domain.Common;
using Microsoft.AspNetCore.Mvc;
using Presenters.Interfaces;

namespace TicketWebApi.Endpoints
{
    public class ClientEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/Client/GetClients", GetClients)
            .WithName("GetClients");

            app.MapPost("/api/Client/SaveClient", SaveClient)
            .WithName("SaveClient");
        }

        private static async Task<IResult> GetClients(IGetClientsInputPort inputPort, IGetClientsOutputPort outputPort)
        {
            await inputPort.GetClientsHandle();
            var clients = ((IPresenter<List<ClientDto>>)outputPort).Content;

            return Results.Ok(clients);
        }

        private static async Task<IResult> SaveClient(ISaveClientInputPort inputPort, ISaveClientOutputPort outputPort,
            [FromBody] ClientDto client)
        {
            await inputPort.SaveClientHandle(client);
            var response = ((IPresenter<ResponseModel<ClientDto>>)outputPort).Content;

            return Results.Ok(response);
        }
    }
}
