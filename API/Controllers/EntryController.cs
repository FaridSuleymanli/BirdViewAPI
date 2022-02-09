using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs.EntryProgramme;
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
    public class EntryController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;
        public EntryController(BVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            IEnumerable<EntryProgrammeForGetDTO> entries = _mapper.Map<IEnumerable<EntryProgrammeForGetDTO>>(await _context.EntryProgrammes.Include(e => e.Country).ToListAsync());
            return Ok(entries);
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<EntryProgramme, EntryProgrammeForGetDTO>(await _context.EntryProgrammes.Include(v => v.Country).FirstOrDefaultAsync(c => c.Id == id)));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EntryProgrammeForCreateDTO entryProgramme)
        {
            EntryProgramme entry = _mapper.Map<EntryProgramme>(entryProgramme);

            await _context.EntryProgrammes.AddAsync(entry);
            await _context.SaveChangesAsync();
            return Ok(entryProgramme);
        }

        [HttpPut]
        [Route("id")]
        public async Task<ActionResult> Update(int id, [FromBody] EntryProgrammeForUpdateDTO entryProgramme)
        {
            EntryProgramme entry = await _context.EntryProgrammes.FirstOrDefaultAsync(e => e.Id == id);

            _mapper.Map<EntryProgrammeForUpdateDTO, EntryProgramme>(entryProgramme, entry);
            await _context.SaveChangesAsync();

            return Ok(entryProgramme);
        }

    }
}
