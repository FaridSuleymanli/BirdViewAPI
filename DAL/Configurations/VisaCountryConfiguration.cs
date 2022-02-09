using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations
{
    public class VisaCountryConfiguration : IEntityTypeConfiguration<VisaCountry>
    {
        public void Configure(EntityTypeBuilder<VisaCountry> builder)
        {
            builder.ToTable("VisaCountries");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id).UseIdentityColumn();

            builder.HasOne(t => t.VisaType).WithMany(v => v.VisaCountries).HasForeignKey(t => t.VisaTypeId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Country).WithMany(v => v.VisaCountries).HasForeignKey(t => t.CountryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
