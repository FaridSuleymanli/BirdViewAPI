using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class ConsultationType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string BannerTitle { get; set; }
        public string BannerSubtitle { get; set; }
        public string IconBgColor { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int VisatypeId { get; set; }
        public VisaType VisaType { get; set; }
        public virtual ICollection<CountryService> CountryServices { get; set; }
        public virtual ICollection<VisaServBlog> VisaServiceBlogs { get; set; }
        public ConsultationType()
        {
            UpdatedAt = DateTime.Now.AddHours(+4);
        }
    }
}
