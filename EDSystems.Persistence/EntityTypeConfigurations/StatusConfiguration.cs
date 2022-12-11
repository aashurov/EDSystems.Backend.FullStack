using EDSystems.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDSystems.Persistence.EntityTypeConfigurations;

public class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.HasKey(status => status.Id);
        builder.HasIndex(status => status.Id).IsUnique();
        builder.Property(status => status.Name).HasMaxLength(255).IsRequired();
        builder.Property(status => status.Description).HasMaxLength(500);
    }
}