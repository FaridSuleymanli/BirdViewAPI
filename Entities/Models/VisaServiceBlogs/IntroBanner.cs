using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class IntroBanner
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BannerImageUrl { get; set; }
        public int? VisaServiceBlogId { get; set; }
        public VisaServBlog VisaServiceBlog { get; set; }
    }
}
