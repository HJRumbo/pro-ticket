using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityMappings
{
    internal class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients");

            builder.HasKey(c => c.IdClient);

            builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(c => c.LastName)
            .IsRequired()
            .HasMaxLength(20);

            builder.Property(c => c.Address)
            .IsRequired()
            .HasMaxLength(35);

            builder.Property(c => c.Phone)
            .IsRequired()
            .HasMaxLength(10);
        }
    }
}
