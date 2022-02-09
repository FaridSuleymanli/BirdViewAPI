using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs.ConsultationServiceDTOs;
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
    public class ConsultationTypeController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;
        public ConsultationTypeController(BVContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            var consultationTypes = _context.ConsultationTypes.Include(c => c.VisaType).Include(c => c.CountryServices)
                .ThenInclude(c => c.Country).Select(c => new
                {
                    VisaName = c.VisaType.Title,
                    Title = c.Title,
                    UpdatedAt = c.UpdatedAt,
                    Countries = c.CountryServices.Select(s => s.Country.Name).ToList()
                });
            return Ok(consultationTypes);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var consultationType = _mapper.Map<ConsultationType, ConsultationTypeForGetDTO>(await _context.ConsultationTypes
                .Include(c => c.VisaType).Include(c => c.CountryServices).ThenInclude(c => c.Country).FirstOrDefaultAsync(c => c.Id == id));
            return Ok(consultationType);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create([FromBody] ConsultationTypeForCreateDTO consultationType)
        {
            ConsultationType consultation = _mapper.Map<ConsultationType>(consultationType);

            await _context.ConsultationTypes.AddAsync(consultation);
            await _context.SaveChangesAsync();
            return Ok(consultationType);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ConsultationTypeForUpdateDTO consultationType)
        {
            ConsultationType consultation = await _context.ConsultationTypes.Include(c => c.VisaType).Include(c => c.CountryServices)
                .ThenInclude(c => c.Country).FirstOrDefaultAsync(c => c.Id == id);
            _mapper.Map<ConsultationTypeForUpdateDTO, ConsultationType>(consultationType, consultation);
            await _context.SaveChangesAsync();
            return Ok(consultationType);
        }
    }
}
