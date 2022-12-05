using Application.Dtos;
using Application.Ports.OutputPorts;
using Application.UseCase;
using Domain.Common;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.RequestApiGateway;
using GenFu;
using Moq;
using Presenters.Interfaces;
using Presenters.Presenters;

namespace UseCasesTests
{
    public class OpenTicketUseCaseTests
    {
        [Fact]
        public async Task OpenTicket_InformationIsCorrect_OpenTicketSuccessful()
        {
            var mockTicketRepository = new Mock<ITicketRepository>();
            var mockClientRepository = new Mock<IClientRepository>();
            var mockParkerWebApi = new Mock<IParkerWebApi>();

            IOpenTicketOutputPort output = new OpenTicketPresenter();

            var ticketDto = A.New<OpenTicketDto>();

            //Setups mockTicketRepository
            mockTicketRepository.Setup(t => t.OpenTicket(It.IsAny<Ticket>())).ReturnsAsync(true);

            //Setups mockClientRepository
            var client = A.New<Client>();
            mockClientRepository.Setup(c => c.GetClientById(It.IsAny<int>())).ReturnsAsync(client);

            //Setups mockParkerWebApi
            var tariff = A.New<Tariff>();
            mockParkerWebApi.Setup(w => w.GetTariff(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(tariff);

            // Act
            var useCase = new OpenTicketUseCase(mockTicketRepository.Object, 
                mockClientRepository.Object, 
                mockParkerWebApi.Object,
                output);

            await useCase.OpenTicketHandle(ticketDto, It.IsAny<string>());
            var response = ((IPresenter<ResponseModel<OpenTicketDto>>)output).Content;

            // Assert
            Assert.True(response!.IsSuccess);
            Assert.Equal(ticketDto, response!.Result);
        }
    }
}
