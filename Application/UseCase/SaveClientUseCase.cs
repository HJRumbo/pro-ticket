using Application.Dtos;
using Application.Ports.InputPorts;
using Application.Ports.OutputPorts;
using Domain.Common;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Shared;

namespace Application.UseCase
{
    public class SaveClientUseCase : ISaveClientInputPort
    {
        private readonly IClientRepository _clientRepository;
        private readonly ISaveClientOutputPort _output;

        public SaveClientUseCase(IClientRepository clientRepository, ISaveClientOutputPort output)
        {
            _clientRepository = clientRepository;
            _output = output;
        }

        public async Task SaveClientHandle(ClientDto client)
        {
            ResponseModel<ClientDto> response = new()
            {
                IsSuccess = await _clientRepository.SaveClient(MyMapper<ClientDto, Client>.ObjectMap(client))
            };

            if (response.IsSuccess)
            {
                response.Result = client;

                await _output.SaveClientHandle(response);
            }
        }
    }
}
