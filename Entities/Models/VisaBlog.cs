using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class VisaBlog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public int VisaTypeId { get; set; }
        public VisaType VisaType { get; set; }

    }
}
