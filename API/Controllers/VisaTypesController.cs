using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs.VisaTypeDTOs;
using BirdViewAPI.Entities.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BirdViewAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisaTypesController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        public VisaTypesController(BVContext context, IMapper mapper, IWebHostEnvironment environment)
        {
            _context = context;
            _mapper = mapper;
            _environment = environment;
        }

        [HttpGet]
        [Route("GetNames")]
        public async Task<ActionResult> GetNames()
        {
            IEnumerable<VisaTypeNameGetDTO> visaTypes = _mapper.Map<IEnumerable<VisaTypeNameGetDTO>>(await _context.VisaTypes.ToListAsync());
            return Ok(visaTypes);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var visatypes = _context.VisaTypes.Include(v => v.VisaCountries)
                .ThenInclude(v => v.Country).Select(v => new 
                {
                    Title = v.Title,
                    Priority = v.Priority,
                    UpdatedAt = v.UpdatedAt,
                    Status = v.Status,
                    Countries = v.VisaCountries.Select(c => c.Country.Name).ToList()
                });
            return Ok(visatypes);
        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult> GetById(int id)
        {
            var visas = _mapper.Map<VisaType, VisaTypeForGetDTO>(await _context.VisaTypes.Include(v => v.VisaCountries).ThenInclude(c => c.Country).FirstOrDefaultAsync(v => v.Id == id));
            if (visas == null)
                return BadRequest(new { error = "Visa type doesn't exist"});
            return Ok(visas);
        }

        [HttpPost]
        [Route("Services/Create")]
        public async Task<ActionResult> ServiceCreate(IFormFile file, [FromForm] VisaTypeForCreateCT visaType)
        {
            if (file == null)
                return BadRequest();
            string directpath = Path.Combine(_environment.ContentRootPath, "Files");
            string filepath = Path.Combine(directpath, file.FileName);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            VisaType visa = _mapper.Map<VisaType>(visaType);
            visa.VisaTypeImageUrl = filepath;
            await _context.VisaTypes.AddAsync(visa);
            await _context.SaveChangesAsync();
            return Ok(visaType);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] VisaTypeForCreateDTO visaTypeDTO)
        {
            var visaType = new VisaType()
            {
                Title = visaTypeDTO.Title,
                Priority = visaTypeDTO.Priority,
                Status = visaTypeDTO.Status,
            }; 

            await _context.VisaTypes.AddAsync(visaType);
            await _context.SaveChangesAsync();

            foreach (var id in visaTypeDTO.CountryIds)
            {
                var visaCountry = new VisaCountry()
                {
                    VisaTypeId = visaType.Id,
                    CountryId = id
                };
                await _context.VisaCountries.AddAsync(visaCountry);
                await _context.SaveChangesAsync();
            }
            
            return Ok(visaTypeDTO);
        }

        [HttpPut]
        [Route("id")]
        public async Task<ActionResult> Update(int id, [FromBody] VisaTypeUpdateDTO visaType)
        {
            VisaType visa = await _context.VisaTypes.FirstOrDefaultAsync(v => v.Id == id);

            visa.Title = visaType.Title;
            visa.Priority = visaType.Priority;
            visa.Status = visaType.Status;

            var vCountries = await _context.VisaCountries.Where(v => v.VisaTypeId == visaType.Id).ToListAsync();
            _context.Remove(vCountries);
            
            foreach (var item in visaType.CountryIds)
            {
                VisaCountry country = new VisaCountry
                {
                    VisaTypeId = visa.Id,
                    CountryId = item
                };
            }

            await _context.SaveChangesAsync();
            return Ok(visaType);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var visaTypes = await _context.VisaCountries.FirstOrDefaultAsync(v => v.Id == id);
            if (visaTypes == null)
            {
                return BadRequest(new { error = "Visa type doesn't exist" });
            }
            _context.Remove(visaTypes);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Deleted successfully"});
        }
    }
}
