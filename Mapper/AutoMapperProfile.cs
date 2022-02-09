using AutoMapper;
using BirdViewAPI.Entities.DTOs;
using BirdViewAPI.Entities.DTOs.BookAppointment;
using BirdViewAPI.Entities.DTOs.ConsultationServiceDTOs;
using BirdViewAPI.Entities.DTOs.CountryDTOs;
using BirdViewAPI.Entities.DTOs.CountryServiceDTO;
using BirdViewAPI.Entities.DTOs.EntryProgramme;
using BirdViewAPI.Entities.DTOs.VisaCountryDTO;
using BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs;
using BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs.IntroBannerDTO;
using BirdViewAPI.Entities.DTOs.VisaTypeDTOs;
using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ContactDTO, Contact>().ReverseMap();

            CreateMap<VisaTypeForCreateDTO, VisaType>().ReverseMap();
            CreateMap<VisaType, VisaTypeForGetDTO>().ReverseMap();
            CreateMap<VisaType, VisaTypeForConsGetDTO>().ReverseMap();
            CreateMap<VisaType, VisaTypeNameGetDTO>().ReverseMap();

            CreateMap<Country, CountryForGetDTO>().ReverseMap();
            CreateMap<Country, CountryForGetAdminDTO>().ReverseMap();
            CreateMap<Country, CountryNameGetDTO>().ReverseMap();
            CreateMap<CountryForCreateDTO, Country>().ReverseMap();
            CreateMap<CountryNameCreateDTO, Country>().ReverseMap();
            CreateMap<CountryForUpdateDTO, Country>().ReverseMap();

            CreateMap<EntryProgrammeForCreateDTO, EntryProgramme>().ReverseMap();
            CreateMap<EntryProgrammeForUpdateDTO, EntryProgramme>().ReverseMap();
            CreateMap<EntryProgramme, EntryProgrammeForGetDTO>().ReverseMap();

            CreateMap<BookAppointmentForCreateDTO, BookAppointment>().ReverseMap();
            CreateMap<BookAppointment, BookAppointmentForGetDTO>().ReverseMap();
            CreateMap<BookAppointmentForUpdateDTO, BookAppointment>().ReverseMap();

            CreateMap<ConsultationType, ConsultationTypeForGetDTO>().ReverseMap();
            CreateMap<ConsultationType, ConsultationTypeNameGetDTO>().ReverseMap();
            CreateMap<ConsultationTypeForCreateDTO, ConsultationType>().ReverseMap();
            CreateMap<ConsultationTypeForUpdateDTO, ConsultationType>().ReverseMap();

            CreateMap<VisaCountry, VisaCountryGetDTO>().ReverseMap();
            CreateMap<VisaCountryCreateDTO, VisaCountry>().ReverseMap();

            CreateMap<CountryService, CountryServiceGetDTO>().ReverseMap();
            CreateMap<CountryServicePostDTO, CountryService>().ReverseMap();

            #region VisaServicesBlogMapper
            //VisaServiceBlogMapper
            CreateMap<VisaServiceBlogCreateDTO, VisaServBlog>().ReverseMap();
            CreateMap<VisaServBlog, VisaServiceBlogGetAdminDTO>().ReverseMap();

            //IntroBannerMapper
            CreateMap<IntroBannerCreateDTO, IntroBanner>().ReverseMap();
            CreateMap<IntroBanner, IntroBannerGetDTO>().ReverseMap();
            #endregion
        }
    }
}
