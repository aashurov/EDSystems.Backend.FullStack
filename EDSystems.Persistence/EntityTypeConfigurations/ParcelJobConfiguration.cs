﻿using EDSystems.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EDSystems.Persistence.EntityTypeConfigurations;

public class ParcelJobConfiguration : IEntityTypeConfiguration<ParcelJob>
{
    public void Configure(EntityTypeBuilder<ParcelJob> builder)
    {
        builder.HasKey(parcelJob => parcelJob.Id);
        builder.HasIndex(parcelJob => parcelJob.Id).IsUnique();
        builder.HasOne(parcelJob => parcelJob.Parcel);
        builder.HasMany(parcelJob => parcelJob.Courier);
    }
}