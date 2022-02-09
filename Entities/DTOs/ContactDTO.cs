using BirdViewAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs
{
    public class ContactDTO
    {
        public string Address { get; set; }
        public List<EmailAddressDTO> EAddresses { get; set; }
    }
}
