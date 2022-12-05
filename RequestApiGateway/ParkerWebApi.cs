using Domain.Entities;
using Domain.Interfaces.RequestApiGateway;

namespace RequestApiGateway
{
    public class ParkerWebApi : IParkerWebApi
    {
        public Task<Tariff> GetTariff(string typeBay, string token)
        {
            throw new NotImplementedException();
        }

        public Task<double> OccupyBay(int tariffId, string token)
        {
            throw new NotImplementedException();
        }
    }
}
