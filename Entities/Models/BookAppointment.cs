using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.Models
{
    public class BookAppointment
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Program { get; set; }
        public string AppointmentDate { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public BookAppointment()
        {
            Random generator = new Random();
            Reference = generator.Next(0, 1000000).ToString("D6");
            CreatedAt = DateTime.Now.AddHours(+4);
        }
    }
}
