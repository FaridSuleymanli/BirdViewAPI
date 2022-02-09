using BirdViewAPI.Entities.Models;
using BirdViewAPI.Entities.Models.VisaServiceBlogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.DAL
{
    public class BVContext : DbContext
    {
        public BVContext(DbContextOptions<BVContext> options) : base(options) { }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<VisaType> VisaTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<VisaCountry> VisaCountries { get; set; }
        public virtual DbSet<EntryProgramme> EntryProgrammes { get; set; }
        public virtual DbSet<BookAppointment> BookAppointments { get; set; }
        public virtual DbSet<ConsultationType> ConsultationTypes { get; set; }
        public virtual DbSet<CountryService> CountryServices { get; set; }
        public virtual DbSet<VisaServBlog> VisaServiceBlogs { get; set; }
        public virtual DbSet<IntroBanner> IntroBanners { get; set; }
        public virtual DbSet<HoverImage> HoverImages { get; set; }
        public virtual DbSet<AdditionalInfo> AdditionalInfos { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<CountAndTitle> CountAndTitles { get; set; }
        public virtual DbSet<WalkInProcess> WalkInProcesses { get; set; }

    }
}
