using BirdViewAPI.Entities.DTOs.ConsultationServiceDTOs;
using BirdViewAPI.Entities.DTOs.CountryDTOs;
using BirdViewAPI.Entities.DTOs.VisaTypeDTOs;
using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs
{
    public class VisaServiceBlogGetAdminDTO
    {
        public VisaTypeNameGetDTO VisaType { get; set; }
        public ConsultationTypeNameGetDTO ConsultationType { get; set; }
        public CountryNameGetDTO Country { get; set; }
    }
}
