using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityMappings;

namespace Persistence
{
    public class ParkerDbContext : DbContext
    {
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<Client>? Clients { get; set; }

        public ParkerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new TicketMapping().Configure(modelBuilder.Entity<Ticket>());
            new ClientMapping().Configure(modelBuilder.Entity<Client>());
        }
    }
}
