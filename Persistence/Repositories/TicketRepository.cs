using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ParkerDbContext _context;

        public TicketRepository(ParkerDbContext context)
        {
            _context = context;
        }

        public async Task<List<Ticket>> GetTickets()
        {
            return await _context.Tickets!.ToListAsync();
        }

        public Task<Ticket> GetTicketById(int idTicket)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> OpenTicket(Ticket ticket)
        {
            try
            {
                _context.Tickets!.Add(ticket);

                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error al guardar en base de datos"); ;
            }
        }

        public Task<bool> UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteTicket(int idTicket)
        {
            throw new NotImplementedException();
        }
    }
}
