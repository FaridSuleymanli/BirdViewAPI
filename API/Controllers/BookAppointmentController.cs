using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs.BookAppointment;
using BirdViewAPI.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAppointmentController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;
        public BookAppointmentController(BVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            IEnumerable<BookAppointmentForGetDTO> books = _mapper.Map<IEnumerable<BookAppointmentForGetDTO>>(await _context.BookAppointments.ToListAsync());
            return Ok(books);
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<BookAppointment, BookAppointmentForGetDTO>(await _context.BookAppointments.FirstOrDefaultAsync(b => b.Id == id)));
        }

        [HttpPost]
        [Route("Post")]
        public async Task<ActionResult> Create([FromBody] BookAppointmentForCreateDTO bookAppointment)
        {
            BookAppointment appointment = _mapper.Map<BookAppointment>(bookAppointment);

            await _context.BookAppointments.AddAsync(appointment);
            await _context.SaveChangesAsync();
            return Ok(bookAppointment);
        }

        [HttpPut]
        [Route("Update/id")]
        public async Task<ActionResult> Update(int id, [FromBody] BookAppointmentForUpdateDTO bookAppointment)
        {
            BookAppointment appointment = await _context.BookAppointments.FirstOrDefaultAsync(b => b.Id == id);

            _mapper.Map<BookAppointmentForUpdateDTO, BookAppointment>(bookAppointment, appointment);
            await _context.SaveChangesAsync();
            return Ok(bookAppointment);
        }

        [HttpDelete]
        [Route("Delete/id")]
        public async Task<ActionResult> Delete(int id)
        {
            BookAppointment appointment = await _context.BookAppointments.FirstOrDefaultAsync(b => b.Id == id);

            if (appointment == null)
                return BadRequest();
            _context.BookAppointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
