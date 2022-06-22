using Day64Self.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Day64Self.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Nationality> Nationalities { get; set; } = null!;
    }
}
