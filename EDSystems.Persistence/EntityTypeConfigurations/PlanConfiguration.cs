using EDSystems.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDSystems.Persistence.EntityTypeConfigurations;

public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.HasKey(plan => plan.Id);
        builder.HasIndex(plan => plan.Id).IsUnique();
        builder.Property(plan => plan.Name).HasMaxLength(255);
        builder.Property(plan => plan.Cost).HasColumnType("decimal(18,3)").IsRequired();
    }
}