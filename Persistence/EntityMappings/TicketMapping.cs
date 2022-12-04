using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence.EntityMappings
{
    public class TicketMapping : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");

            builder.HasKey(t => t.IdTicket);

            builder.Property(t => t.StartDate)
            .IsRequired();

            builder.Property(t => t.EndDate)
            .IsRequired();

            builder.Property(t => t.LicensePlate)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(t => t.TotalPay)
            .IsRequired();

            builder.Property(t => t.IdClient)
            .IsRequired();
        }
    }
}
