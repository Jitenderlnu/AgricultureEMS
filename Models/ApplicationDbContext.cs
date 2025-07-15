using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgricultureEMS.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Crop> Crops { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<PestReport> PestReports { get; set; }
    }
}