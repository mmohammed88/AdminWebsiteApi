using Microsoft.EntityFrameworkCore;
using AdminWebsiteApi.Models;

namespace AdminWebsiteApi.Data
{
    public class AdminWebsiteContext : DbContext
    {
        public AdminWebsiteContext(DbContextOptions<AdminWebsiteContext> options)
            : base(options) { }

        public DbSet<FreeTrialForm> FreeTrialForms { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Companies> Companies { get; set; }
    }
}
