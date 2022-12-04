using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<Ticket> GetTicketById(int IdTicket)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteTicket(int IdTicket)
        {
            throw new NotImplementedException();
        }
    }
}
