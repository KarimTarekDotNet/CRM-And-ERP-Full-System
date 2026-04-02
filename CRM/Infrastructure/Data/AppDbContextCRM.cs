using CRM.Domain.Entities.Core;
using CRM.Domain.Entities.SalesPipeline;
using CRM.Domain.Entities.Supporting;
using CRM.Infrastructure.Data.Configuration.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRM.Infrastructure.Data
{
    public class AppDbContextCRM : IdentityDbContext<User>
    {
        public AppDbContextCRM(DbContextOptions<AppDbContextCRM> options) : base(options) { }

        // Core Entities
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Lead> Leads { get; set; } = default!;
        public DbSet<Contact> Contacts { get; set; } = default!;
        public DbSet<Account> Accounts { get; set; } = default!;

        // Supporting Entities
        public DbSet<User> AppUsers { get; set; } = default!;
        public DbSet<Domain.Entities.Supporting.SupportTask> Tasks { get; set; } = default!;
        public DbSet<Note> Notes { get; set; } = default!;
        public DbSet<Tag> Tags { get; set; } = default!;

        // Sales Pipeline
        public DbSet<Deal> Deals { get; set; } = default!;
        public DbSet<Activity> Activities { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfig).Assembly);
        }
    }
}