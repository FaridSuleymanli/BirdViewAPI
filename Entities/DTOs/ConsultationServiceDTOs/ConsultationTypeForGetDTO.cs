using BirdViewAPI.Entities.DTOs.CountryDTOs;
using BirdViewAPI.Entities.DTOs.CountryServiceDTO;
using BirdViewAPI.Entities.DTOs.VisaTypeDTOs;
using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.ConsultationServiceDTOs
{
    public class ConsultationTypeForGetDTO
    {
        public VisaTypeNameGetDTO VisaType { get; set; }
        //public virtual ICollection<CountryForGetDTO> CountryForGetDTOs  { get; set; }
        public string Title { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<CountryServiceGetDTO> CountryServices { get; set; }
    }
}
