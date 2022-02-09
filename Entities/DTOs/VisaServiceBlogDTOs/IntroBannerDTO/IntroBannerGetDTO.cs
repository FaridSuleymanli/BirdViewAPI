using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs.IntroBannerDTO
{
    public class IntroBannerGetDTO
    {
        public string Title { get; set; }
        public string BannerImageUrl { get; set; }
        public int VisaServiceBlogId { get; set; }
    }
}
