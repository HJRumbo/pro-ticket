using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetTickets();
        Task<Ticket> GetTicketById(int IdTicket);
        Task<bool> SaveTicket(Ticket ticket);
        Task<bool> UpdateTicket(Ticket ticket);
        Task<bool> DeleteTicket(int IdTicket);
    }
}
