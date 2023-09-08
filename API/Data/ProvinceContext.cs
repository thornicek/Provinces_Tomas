using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ProvinceContext : DbContext
    {
        public ProvinceContext (DbContextOptions options) : base(options)
        {
        } 

        public DbSet<Province> Provinces { get; set; }
    }
}