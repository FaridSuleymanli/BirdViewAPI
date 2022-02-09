using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
        public int PhoneCode { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Flag { get; set; }
        public string Image { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<VisaCountry> VisaCountries { get; set; }
        public EntryProgramme EntryProgramme { get; set; }
        public virtual ICollection<CountryService> CountryServices { get; set; }
        public virtual ICollection<VisaServBlog> VisaServiceBlogs { get; set; }
        public Country()
        {
            UpdatedAt = DateTime.Now.AddHours(+4);
        }
    }
}
