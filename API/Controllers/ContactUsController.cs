using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs;
using BirdViewAPI.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;

        public ContactUsController(BVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Contact-create")]
        public async Task<ActionResult> Post([FromBody] ContactDTO contactDTO)
        {
            Contact newContact = _mapper.Map<Contact>(contactDTO);

            await _context.Contacts.AddAsync(newContact);
            await _context.SaveChangesAsync();
            return Ok(contactDTO);
        }


    }
}
