using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ParkerDbContext _context;

        public ClientRepository(ParkerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Client>> GetClients()
        {
            return await _context.Clients!.ToListAsync();
        }

        public async Task<Client> GetClientById(int idClient)
        {
            var client = await _context.Clients!.FindAsync(idClient);

            return client!;
        }

        public async Task<bool> SaveClient(Client client)
        {
            try
            {
                _context.Clients!.Add(client);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error al guardar en base de datos"); ;
            }
        }

        public Task<bool> UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteClient(int idClient)
        {
            throw new NotImplementedException();
        }

    }
}
