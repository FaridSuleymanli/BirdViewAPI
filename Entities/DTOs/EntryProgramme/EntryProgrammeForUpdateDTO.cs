using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.EntryProgramme
{
    public class EntryProgrammeForUpdateDTO
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
    }
}
