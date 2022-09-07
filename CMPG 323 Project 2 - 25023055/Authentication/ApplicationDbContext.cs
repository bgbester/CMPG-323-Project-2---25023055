using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CMPG_323_Project_2___25023055.Models;

namespace JWTAuthentication.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<CMPG_323_Project_2___25023055.Models.Zone> Zone { get; set; }
        public DbSet<CMPG_323_Project_2___25023055.Models.Category> Category { get; set; }
        public DbSet<CMPG_323_Project_2___25023055.Models.Device> Device { get; set; }
    }
}

