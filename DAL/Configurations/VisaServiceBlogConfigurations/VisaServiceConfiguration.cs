using BirdViewAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL.Configurations.VisaServiceBlogConfigurations
{
    public class VisaServiceConfiguration : IEntityTypeConfiguration<VisaServBlog>
    {
        public void Configure(EntityTypeBuilder<VisaServBlog> builder)
        {
            builder.ToTable("VisaServiceBlogs");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id).UseIdentityColumn();

            builder.HasOne(vs => vs.VisaType).WithMany(v => v.VisaServiceBlogs).HasForeignKey(vs => vs.VisaTypeId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vs => vs.Country).WithMany(v => v.VisaServiceBlogs).HasForeignKey(vs => vs.CountryId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(vs => vs.ConsultationType).WithMany(v => v.VisaServiceBlogs).HasForeignKey(vs => vs.ConsultationTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
