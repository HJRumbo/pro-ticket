using Domain.Entities;

namespace Domain.Interfaces.RequestApiGateway
{
    public interface IParkerWebApi
    {
        Task<Tariff> GetTariff(string typeBay, string token);
        Task<double> OccupyBay(int tariffId, string token);
    }
}
