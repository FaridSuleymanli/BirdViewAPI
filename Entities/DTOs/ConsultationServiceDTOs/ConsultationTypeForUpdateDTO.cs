using BirdViewAPI.Entities.DTOs.CountryServiceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.ConsultationServiceDTOs
{
    public class ConsultationTypeForUpdateDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BannerTitle { get; set; }
        public string BannerSubtitle { get; set; }
        public string IconBgColor { get; set; }
        public int VisatypeId { get; set; }
        public virtual ICollection<CountryServicePostDTO> CountryServices { get; set; }
    }
}
