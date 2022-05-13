using Microsoft.EntityFrameworkCore;

namespace GumNaam.API.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpLogin>()
                .HasMany(c => c.Employees)
                .WithOne(a => a.EmpLogin)
                .HasForeignKey(a => a.UserRole);

            modelBuilder.Seed();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpLogin> Categories { get; set; }
    }
}
