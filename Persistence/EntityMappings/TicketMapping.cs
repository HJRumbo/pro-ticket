using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder.Property(t => t.EndDate);

            builder.Property(t => t.LicensePlate)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(t => t.TotalPay);

            builder.Property(t => t.IdClient)
            .IsRequired();

            builder.Property(t => t.CostHour);

            builder.Property(t => t.IdTariff)
            .IsRequired();

            builder.HasOne(t => t.Client)
            .WithMany(c => c.Tickets)
            .HasForeignKey(t => t.IdClient);
        }
    }
}
