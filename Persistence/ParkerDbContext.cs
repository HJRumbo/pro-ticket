using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.EntityMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ParkerDbContext : DbContext
    {
        public DbSet<Ticket>? Tickets { get; set; }

        public ParkerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new TicketMapping().Configure(modelBuilder.Entity<Ticket>());
        }
    }
}
