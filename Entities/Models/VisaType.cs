using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class VisaType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        public string VisaTypeImageUrl { get; set; }
        public virtual ICollection<VisaCountry> VisaCountries { get; set; }
        public virtual ICollection<ConsultationType> ConsultationTypes { get; set; }
        public virtual ICollection<VisaServBlog> VisaServiceBlogs { get; set; }

        public VisaType()
        {
            UpdatedAt = DateTime.Now.AddHours(+4);
        }
    }
}
