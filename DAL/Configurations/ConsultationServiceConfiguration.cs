using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations
{
    public class ConsultationServiceConfiguration : IEntityTypeConfiguration<ConsultationType>
    {
        public void Configure(EntityTypeBuilder<ConsultationType> builder)
        {
            builder.ToTable("ConfigurationServices");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).UseIdentityColumn();

            builder.HasOne(v => v.VisaType).WithMany(c => c.ConsultationTypes).HasForeignKey(v => v.VisatypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
