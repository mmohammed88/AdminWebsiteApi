using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using AdminWebsiteApi.Data;

namespace AdminWebsiteApi
{
    public class AdminWebsiteContextFactory : IDesignTimeDbContextFactory<AdminWebsiteContext>
    {
        public AdminWebsiteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AdminWebsiteContext>();
            optionsBuilder.UseSqlServer("Server=YOUR_SQL_SERVER;Database=AdminWebsite;Trusted_Connection=True;TrustServerCertificate=True;");

            return new AdminWebsiteContext(optionsBuilder.Options);
        }
    }
}
