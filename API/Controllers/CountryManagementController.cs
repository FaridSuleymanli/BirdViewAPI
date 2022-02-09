using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs.CountryDTOs;
using BirdViewAPI.Entities.Models;
using Microsoft.AspNetCore.Cors;
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
    public class CountryManagementController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        public CountryManagementController(BVContext context, IMapper mapper, IWebHostEnvironment environment)
        {
            _context = context;
            _mapper = mapper;
            _environment = environment;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            IEnumerable<CountryForGetAdminDTO> countries = _mapper.Map<IEnumerable<CountryForGetAdminDTO>>(await _context.Countries.ToListAsync());
            return Ok(countries);
        }

        [HttpGet]
        [Route("GetById/id")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<Country, CountryForGetAdminDTO>(await _context.Countries.FirstOrDefaultAsync(c => c.Id == id)));
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Create(IFormFile flag, IFormFile image,[FromForm] CountryForCreateDTO countryDTO)
        {
            if (flag == null)
                return BadRequest();
            string flagpath = Path.Combine(_environment.ContentRootPath, "Files");
            string flagFilepath = Path.Combine(flagpath, flag.FileName);
            using (var stream = new FileStream(flagFilepath, FileMode.Create))
            {
                flag.CopyTo(stream);
            }

            if (image == null)
                return BadRequest();
            string directpath = Path.Combine(_environment.ContentRootPath, "Files");
            string filepath = Path.Combine(directpath, image.FileName);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            Country country = _mapper.Map<Country>(countryDTO);

            country.Flag = flagFilepath;
            country.Image = filepath;

            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
            return Ok(countryDTO);
        }

        [HttpPut]
        [Route("Update/id")]
        public async Task<ActionResult> Update(int id, [FromBody] CountryForUpdateDTO updateDTO)
        {
            Country country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
            if (country == null)
                return BadRequest();

            _mapper.Map<CountryForUpdateDTO, Country>(updateDTO, country);
            await _context.SaveChangesAsync();
            return Ok(updateDTO);
        }

        [HttpDelete]
        [Route("Delete/id")]
        public async Task<ActionResult> Delete(int id)
        {
            Country country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);

            if (country == null)
                return BadRequest();
            _context.Remove(country);
            return Ok();
        }

    }
}
