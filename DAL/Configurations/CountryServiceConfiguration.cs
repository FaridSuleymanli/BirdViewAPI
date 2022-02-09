using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations
{
    public class CountryServiceConfiguration : IEntityTypeConfiguration<CountryService>
    {
        public void Configure(EntityTypeBuilder<CountryService> builder)
        {
            builder.ToTable("CountryServices");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseIdentityColumn();

            builder.HasOne(s => s.ConsultationType).WithMany(c => c.CountryServices).HasForeignKey(s => s.ConsultationTypeId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(k => k.Country).WithMany(c => c.CountryServices).HasForeignKey(k => k.CountryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
