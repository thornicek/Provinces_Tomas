using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvincesController : ControllerBase
    {
        private readonly ProvinceContext _context;
        public ProvincesController(ProvinceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Province>>> GetProvinces()
        {
            
            var provinces = await _context.Provinces.ToListAsync();

            return provinces;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Province>> GetProvince(int id)
        {
            return await _context.Provinces.FindAsync(id);
        }
    }
}