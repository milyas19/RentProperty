using Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.DBContextConfig;

namespace Persistence
{
    public class RentPropertyContext : DbContext
    {
        public DbSet<Tenant> Quizzes { get; set; }
        public DbSet<RentedProperty> Questions { get; set; }

        public RentPropertyContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new TenantConfig());
            builder.ApplyConfiguration(new RentedPropertyConfig());
        }
    }
}