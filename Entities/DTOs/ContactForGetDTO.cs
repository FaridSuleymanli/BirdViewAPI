using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs
{
    public class ContactForGetDTO
    {
        public string Address { get; set; }
        public List<EmailAddressDTO> EAddresses { get; set; }
    }
}
