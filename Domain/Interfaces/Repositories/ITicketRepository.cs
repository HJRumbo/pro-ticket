using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetTickets();
        Task<Ticket> GetTicketById(int idTicket);
        Task<bool> OpenTicket(Ticket ticket);
        Task<bool> UpdateTicket(Ticket ticket);
        Task<bool> DeleteTicket(int idTicket);
    }
}
