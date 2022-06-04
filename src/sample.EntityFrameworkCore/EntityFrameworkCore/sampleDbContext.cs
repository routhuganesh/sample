using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using sample.Authorization.Roles;
using sample.Authorization.Users;
using sample.MultiTenancy;
using sample.Domain;
using System.Reflection;

namespace sample.EntityFrameworkCore
{
    public class sampleDbContext : AbpZeroDbContext<Tenant, Role, User, sampleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Team> Teams { get; set; }
        public sampleDbContext(DbContextOptions<sampleDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
