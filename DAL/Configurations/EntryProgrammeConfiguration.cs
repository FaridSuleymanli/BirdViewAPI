using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations
{
    public class EntryProgrammeConfiguration : IEntityTypeConfiguration<EntryProgramme>
    {
        public void Configure(EntityTypeBuilder<EntryProgramme> builder)
        {
            builder.ToTable("EntryProgrammes");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.HasOne(c => c.Country).WithOne(e => e.EntryProgramme).HasForeignKey<EntryProgramme>(c => c.CountryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
