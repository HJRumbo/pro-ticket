using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Shared;

namespace Application.UseCase
{
    public class GetClientsUseCase : IGetClientsInputPort
    {
        private readonly IClientRepository _clientRepository;
        private readonly IGetClientsOutputPort _output;

        public GetClientsUseCase(IClientRepository clientRepository, IGetClientsOutputPort output)
        {
            _clientRepository = clientRepository;
            _output = output;
        }

        public async Task GetClientsHandle()
        {
            var clients = MyMapper<Client, ClientDto>.ListMap(await _clientRepository.GetClients());

            await _output.GetClientsHandle(clients);
        }
    }
}
