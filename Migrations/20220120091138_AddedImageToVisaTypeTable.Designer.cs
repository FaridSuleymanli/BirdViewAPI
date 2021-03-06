// <auto-generated />
using System;
using BirdViewAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BirdViewAPI.Migrations
{
    [DbContext(typeof(BVContext))]
    [Migration("20220120091138_AddedImageToVisaTypeTable")]
    partial class AddedImageToVisaTypeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BirdViewAPI.Entities.Models.BookAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppointmentDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookAppointments");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.ConsultationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BannerSubtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BannerTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconBgColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisatypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisatypeId");

                    b.ToTable("ConsultationTypes");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISO2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISO3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.CountryService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConsultationTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationTypeId");

                    b.HasIndex("CountryId");

                    b.ToTable("CountryServices");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.EntryProgramme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId")
                        .IsUnique();

                    b.ToTable("EntryProgrammes");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.HoverImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoverImagesUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisaServiceBlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisaServiceBlogId");

                    b.ToTable("HoverImages");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.IntroBanner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BannerImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VisaServiceBlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisaServiceBlogId")
                        .IsUnique()
                        .HasFilter("[VisaServiceBlogId] IS NOT NULL");

                    b.ToTable("IntroBanners");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("VisaTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("VisaTypeId");

                    b.ToTable("VisaCountries");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServBlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConsultationTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("EligibilityButton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EligibilityLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EligibilityTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntroductionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SearchTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VisaTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationTypeId");

                    b.HasIndex("CountryId");

                    b.HasIndex("VisaTypeId");

                    b.ToTable("VisaServiceBlogs");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.AdditionalInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfoImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VisaServBlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisaServBlogId");

                    b.ToTable("AdditionalInfos");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.CountAndTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<bool>("RemoveImage")
                        .HasColumnType("bit");

                    b.Property<int>("VisaServiceBlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisaServiceBlogId");

                    b.ToTable("CountAndTitles");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisaServiceBlogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VisaServiceBlogId");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.WalkInProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisaServiceBlogId")
                        .HasColumnType("int");

                    b.Property<string>("WalkInProcessImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VisaServiceBlogId");

                    b.ToTable("WalkInProcesses");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("VisaTypeImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VisaTypes");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.ConsultationType", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaType", "VisaType")
                        .WithMany("ConsultationTypes")
                        .HasForeignKey("VisatypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisaType");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.CountryService", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.ConsultationType", "ConsultationType")
                        .WithMany("CountryServices")
                        .HasForeignKey("ConsultationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BirdViewAPI.Entities.Models.Country", "Country")
                        .WithMany("CountryServices")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConsultationType");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.EntryProgramme", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.Country", "Country")
                        .WithOne("EntryProgramme")
                        .HasForeignKey("BirdViewAPI.Entities.Models.EntryProgramme", "CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.HoverImage", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaServBlog", "VisaServiceBlog")
                        .WithMany("HoverImages")
                        .HasForeignKey("VisaServiceBlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisaServiceBlog");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.IntroBanner", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaServBlog", "VisaServiceBlog")
                        .WithOne("IntroBanner")
                        .HasForeignKey("BirdViewAPI.Entities.Models.IntroBanner", "VisaServiceBlogId");

                    b.Navigation("VisaServiceBlog");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaCountry", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.Country", "Country")
                        .WithMany("VisaCountries")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BirdViewAPI.Entities.Models.VisaType", "VisaType")
                        .WithMany("VisaCountries")
                        .HasForeignKey("VisaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("VisaType");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServBlog", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.ConsultationType", "ConsultationType")
                        .WithMany("VisaServiceBlogs")
                        .HasForeignKey("ConsultationTypeId");

                    b.HasOne("BirdViewAPI.Entities.Models.Country", "Country")
                        .WithMany("VisaServiceBlogs")
                        .HasForeignKey("CountryId");

                    b.HasOne("BirdViewAPI.Entities.Models.VisaType", "VisaType")
                        .WithMany("VisaServiceBlogs")
                        .HasForeignKey("VisaTypeId");

                    b.Navigation("ConsultationType");

                    b.Navigation("Country");

                    b.Navigation("VisaType");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.AdditionalInfo", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaServBlog", null)
                        .WithMany("AdditionalInfos")
                        .HasForeignKey("VisaServBlogId");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.CountAndTitle", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaServBlog", "VisaServiceBlog")
                        .WithMany("CountAndTitles")
                        .HasForeignKey("VisaServiceBlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisaServiceBlog");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.Slider", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaServBlog", "VisaServiceBlog")
                        .WithMany("Sliders")
                        .HasForeignKey("VisaServiceBlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisaServiceBlog");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServiceBlogs.WalkInProcess", b =>
                {
                    b.HasOne("BirdViewAPI.Entities.Models.VisaServBlog", "VisaServiceBlog")
                        .WithMany("WalkInProcesses")
                        .HasForeignKey("VisaServiceBlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VisaServiceBlog");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.ConsultationType", b =>
                {
                    b.Navigation("CountryServices");

                    b.Navigation("VisaServiceBlogs");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.Country", b =>
                {
                    b.Navigation("CountryServices");

                    b.Navigation("EntryProgramme");

                    b.Navigation("VisaCountries");

                    b.Navigation("VisaServiceBlogs");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaServBlog", b =>
                {
                    b.Navigation("AdditionalInfos");

                    b.Navigation("CountAndTitles");

                    b.Navigation("HoverImages");

                    b.Navigation("IntroBanner");

                    b.Navigation("Sliders");

                    b.Navigation("WalkInProcesses");
                });

            modelBuilder.Entity("BirdViewAPI.Entities.Models.VisaType", b =>
                {
                    b.Navigation("ConsultationTypes");

                    b.Navigation("VisaCountries");

                    b.Navigation("VisaServiceBlogs");
                });
#pragma warning restore 612, 618
        }
    }
}
