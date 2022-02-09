using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs
{
    public class VisaServiceBlogCreateDTO
    {
        public string EligibilityButton { get; set; }
        public string EligibilityLink { get; set; }
        public string EligibilityTitle { get; set; }
        public string SearchTitle { get; set; }
        public string IntroductionDescription { get; set; }
        public int VisaTypeId { get; set; }
        public int CountryId { get; set; }
        public int ConsultationTypeId { get; set; }
    }
}
