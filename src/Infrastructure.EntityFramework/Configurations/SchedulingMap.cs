using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityFramework.Configurations
{
    internal class SchedulingMap : IEntityTypeConfiguration<Scheduling>
    {
        public void Configure(EntityTypeBuilder<Scheduling> builder)
        {
            builder.ToTable(nameof(Scheduling));

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.StartDateTime)
                .IsRequired();

            builder
                .Property(x => x.EndDateTime)
                .IsRequired();

            builder
                .HasOne(x => x.Customer)
                .WithMany()
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.CustomerId);

            builder
                .HasOne(x => x.Service)
                .WithMany()
                .HasPrincipalKey(x => x.Id)
                .HasForeignKey(x => x.ServiceId);

            builder
                .HasIndex(x => new { x.StartDateTime, x.EndDateTime });
        }
    }
}
