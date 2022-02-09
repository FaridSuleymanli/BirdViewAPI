using BirdViewAPI.Entities.Models.VisaServiceBlogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class VisaServBlog
    {
        public int Id { get; set; }
        public string EligibilityButton { get; set; }
        public string EligibilityLink { get; set; }
        public string EligibilityTitle { get; set; }
        public string SearchTitle { get; set; }
        public string IntroductionDescription { get; set; }
        public int? VisaTypeId { get; set; }
        public VisaType VisaType { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? ConsultationTypeId { get; set; }
        public ConsultationType ConsultationType { get; set; }
        public IntroBanner IntroBanner { get; set; }
        public virtual ICollection<HoverImage> HoverImages { get; set; }
        public virtual ICollection<AdditionalInfo> AdditionalInfos { get; set; }
        public virtual ICollection<Slider> Sliders { get; set; }
        public virtual ICollection<CountAndTitle> CountAndTitles { get; set; }
        public virtual ICollection<WalkInProcess> WalkInProcesses { get; set; }
    }
}
