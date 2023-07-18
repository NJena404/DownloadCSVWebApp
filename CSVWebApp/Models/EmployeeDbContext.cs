using Microsoft.EntityFrameworkCore;

namespace CSVWebApp.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<EmployeeDetails> empdetails { get; set; }
    }
}
