using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models.VisaServiceBlogs
{
    public class WalkInProcess
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string WalkInProcessImageUrl { get; set; }
        public int VisaServiceBlogId { get; set; }
        public VisaServBlog VisaServiceBlog { get; set; }
    }
}
