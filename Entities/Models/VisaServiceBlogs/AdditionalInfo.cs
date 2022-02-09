using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models.VisaServiceBlogs
{
    public class AdditionalInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TagLine { get; set; }
        public string Description { get; set; }
        public string AdditionalInfoImageUrl { get; set; }
    }
}
