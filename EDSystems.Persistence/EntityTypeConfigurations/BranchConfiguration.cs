using EDSystems.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDSystems.Persistence.EntityTypeConfigurations;

public class BranchConfiguration : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.HasKey(branch => branch.Id);
        builder.HasIndex(branch => branch.Id).IsUnique();
        builder.Property(branch => branch.Address).HasMaxLength(500).IsRequired();
        builder.Property(branch => branch.City).HasMaxLength(255).IsRequired();
        builder.Property(branch => branch.Country).HasMaxLength(255).IsRequired();
        builder.Property(branch => branch.Email).HasMaxLength(500).IsRequired();
        builder.Property(branch => branch.Name).HasMaxLength(255).IsRequired();
        builder.Property(branch => branch.Phone).HasColumnType("string");
    }
}