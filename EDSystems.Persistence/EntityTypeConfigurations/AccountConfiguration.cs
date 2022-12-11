using EDSystems.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDSystems.Persistence.EntityTypeConfigurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasKey(account => account.Id);
        builder.HasIndex(account => account.Id).IsUnique();
        builder.Property(account => account.Name).HasMaxLength(20);
        builder.Property(account => account.Number).HasMaxLength(20);
        builder.Property(account => account.Balance).HasMaxLength(20);
        builder.HasOne(account => account.Currency);
        builder.HasOne(account => account.Branch);
    }
}