using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class EmailAddress
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
