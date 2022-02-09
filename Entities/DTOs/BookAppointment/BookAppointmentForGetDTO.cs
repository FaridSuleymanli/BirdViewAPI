using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.Entities.DTOs.BookAppointment
{
    public class BookAppointmentForGetDTO
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Program { get; set; }
        public string AppointmentDate { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
