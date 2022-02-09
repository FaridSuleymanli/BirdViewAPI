using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations
{
    public class VisaTypeConfiguration : IEntityTypeConfiguration<VisaType>
    {
        public void Configure(EntityTypeBuilder<VisaType> builder)
        {
            builder.ToTable("VisaTypes");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id).UseIdentityColumn();

            builder.Property(v => v.Title).IsRequired();

            //builder.Property(v => v.Countries).IsRequired();
        }
    }
}
