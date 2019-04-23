using Microsoft.EntityFrameworkCore;
using Drawers.Domain.Entities;
using Drawers.Persistence.Configurations;

namespace Drawers.Persistence
{
    public class DrawersDbContext : DbContext
    {
        public DrawersDbContext(DbContextOptions<DrawersDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new PersonPhoneNumberConfiguration());
        }
    }
}
