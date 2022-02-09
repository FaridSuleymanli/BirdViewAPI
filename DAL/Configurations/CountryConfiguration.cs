using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseIdentityColumn();

            //builder.HasOne(v => v.VisaType).WithMany(c => c.Countries).HasForeignKey(v => v.VisaTypeId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.Name).IsRequired().HasMaxLength(200);
        }
    }
}
