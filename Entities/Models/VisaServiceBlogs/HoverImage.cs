using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class HoverImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TagLine { get; set; }
        public string Description { get; set; }
        public string HoverImagesUrl { get; set; }
        public int VisaServiceBlogId { get; set; }
        public VisaServBlog VisaServiceBlog { get; set; }
    }
}
