using AutoMapper;
using BirdViewAPI.DAL;
using BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs;
using BirdViewAPI.Entities.DTOs.VisaServiceBlogDTOs.IntroBannerDTO;
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
    public class VisaServiceBlogController : ControllerBase
    {
        private readonly BVContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        public VisaServiceBlogController(BVContext context, IMapper mapper, IWebHostEnvironment environment)
        {
            _context = context;
            _mapper = mapper;
            _environment = environment;
        }

        [HttpGet]
        [Route("ServiceBlog/GetAll")]
        public async Task<ActionResult> GetAllServiceBlogForAdmin()
        {
            IEnumerable<VisaServiceBlogGetAdminDTO> visaBlogs = _mapper.Map<IEnumerable<VisaServiceBlogGetAdminDTO>>(await _context.VisaServiceBlogs
                .Include(v => v.VisaType).Include(v => v.Country).Include(v => v.ConsultationType).ToListAsync()
                );
            return Ok(visaBlogs);
        }

        [HttpPost]
        [Route("ServiceBlog/Create")]
        public async Task<ActionResult> CreateServiceBlog([FromBody] VisaServiceBlogCreateDTO visaService)
        {
            VisaServBlog blog = _mapper.Map<VisaServBlog>(visaService);
            await _context.VisaServiceBlogs.AddAsync(blog);
            await _context.SaveChangesAsync();
            return Ok(visaService);
        }

        [HttpPut]
        [Route("ServiceBlog/Update/{id}")]
        public async Task<ActionResult> UpdateServiceBlog(int id, [FromBody] VisaServiceBlogCreateDTO visaService)
        {
            VisaServBlog blog = await _context.VisaServiceBlogs.FirstOrDefaultAsync(v => v.Id == id);

            if (blog == null)
            {
                return BadRequest(new { error = "This Id doesnt exist" });
            }
            _mapper.Map<VisaServiceBlogCreateDTO, VisaServBlog>(visaService, blog);
            await _context.SaveChangesAsync();
            return Ok(visaService);
        }

        [HttpPost]
        [Route("ServiceBlog/IntroBanner/Create")]
        public async Task<ActionResult> CreateIntroBanner(IFormFile file, [FromForm] IntroBannerCreateDTO introBanner)
        {
            if (file == null)
                return BadRequest();
            string directpath = Path.Combine(_environment.ContentRootPath, "Files/VisaConsultationBlog/IntroBanner");
            string filepath = Path.Combine(directpath, file.FileName);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            IntroBanner banner = _mapper.Map<IntroBanner>(introBanner);
            banner.BannerImageUrl = filepath;

            await _context.IntroBanners.AddAsync(banner);
            await _context.SaveChangesAsync();
            return Ok(introBanner);
        }

        [HttpPut]
        [Route("ServiceBlog/IntroBanner/Update/{id}")]
        public async Task<ActionResult> CreateIntroBanner(int id, IFormFile file, [FromForm] IntroBannerCreateDTO introBanner)
        {
            if (file == null)
                return BadRequest();
            string directpath = Path.Combine(_environment.ContentRootPath, "Files/VisaConsultationBlog/IntroBanner/Update");
            string filepath = Path.Combine(directpath, file.FileName);
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            IntroBanner banner = await _context.IntroBanners.FirstOrDefaultAsync(v => v.Id == id);
            if (banner == null)
            {
                return BadRequest(new { error = "This Id doesnt exist" });
            }

            _mapper.Map<IntroBannerCreateDTO, IntroBanner>(introBanner, banner);
            banner.BannerImageUrl = filepath;
            await _context.SaveChangesAsync();
            return Ok(introBanner);
        }

        [HttpGet]
        [Route("ServiceBlog/IntroBanner/GetById")]
        public async Task<ActionResult> GetIntroBannerId(int id)
        {
            var banner = await _context.IntroBanners.FirstOrDefaultAsync(b => b.Id == id);
            if (banner == null)
            {
                return BadRequest(new { error = "Couldn't find the intro banner with the given id" });
            }
            return Ok(_mapper.Map<IntroBanner, IntroBannerGetDTO>(await _context.IntroBanners.FirstOrDefaultAsync(b => b.Id == id)));
        }

        

    }
}
