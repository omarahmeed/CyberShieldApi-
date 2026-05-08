using Microsoft.EntityFrameworkCore;

namespace CyberShieldApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<ContactModel> Contacts { get; set; }
    }
}