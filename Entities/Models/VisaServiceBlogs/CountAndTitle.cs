using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models.VisaServiceBlogs
{
    public class CountAndTitle
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public bool RemoveImage { get; set; }
        public int VisaServiceBlogId { get; set; }
        public VisaServBlog VisaServiceBlog { get; set; }
    }
}
