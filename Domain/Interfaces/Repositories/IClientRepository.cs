using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task<List<Client>> GetClients();
        Task<Client> GetClientById(int idClient);
        Task<bool> SaveClient(Client client);
        Task<bool> UpdateClient(Client client);
        Task<bool> DeleteClient(int idClient);
    }
}
