using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.Supporting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Supporting
{
    // -------------------- User --------------------
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Role).IsRequired();

            builder.HasIndex(u => u.Email).IsUnique();

            // Seed
            builder.HasData(
                new User
                {
                    Id = "aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1",
                    Name = "Admin User",
                    UserName = "adminCRM",
                    NormalizedUserName = "ADMINCRM",
                    Email = "admin@crm.com",
                    NormalizedEmail = "ADMIN@CRM.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==",
                    SecurityStamp = "SOME_FIXED_GUID_STRING_1",
                    ConcurrencyStamp = "02cd6c9a-ee34-4b78-a000-919d741f2854",
                    Role = Role.Admin
                },
                new User
                {
                    Id = "aaaaaaa2-aaaa-aaaa-aaaa-aaaaaaaaaaa2",
                    Name = "Sales Rep User",
                    UserName = "salesRepCRM",
                    NormalizedUserName = "SALESREPCRM",
                    Email = "salesrep@crm.com",
                    NormalizedEmail = "SALESREP@CRM.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==",
                    SecurityStamp = "SOME_FIXED_GUID_STRING_2",
                    ConcurrencyStamp = "12cd6c9a-ee34-4b78-a000-919d741f2854",
                    Role = Role.SalesRep
                },
                new User
                {
                    Id = "aaaaaaa3-aaaa-aaaa-aaaa-aaaaaaaaaaa3",
                    Name = "Sales Manager User",
                    UserName = "salesManagerCRM",
                    NormalizedUserName = "SALESMANAGERCRM",
                    Email = "salesmanager@crm.com",
                    NormalizedEmail = "SALESMANAGER@CRM.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==",
                    SecurityStamp = "SOME_FIXED_GUID_STRING_3",
                    ConcurrencyStamp = "22cd6c9a-ee34-4b78-a000-919d741f2854",
                    Role = Role.SalesManager
                },
                new User
                {
                    Id = "aaaaaaa4-aaaa-aaaa-aaaa-aaaaaaaaaaa4",
                    Name = "Support Agent User",
                    UserName = "supportAgentCRM",
                    NormalizedUserName = "SUPPORTAGENTCRM",
                    Email = "support@crm.com",
                    NormalizedEmail = "SUPPORT@CRM.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEEhwmPAcl0KEK72JjAvBdzsUdHBe18eFTeUth6kaNpX+zOA5arJRLp5zcwPQaQqpjw==",
                    SecurityStamp = "SOME_FIXED_GUID_STRING_4",
                    ConcurrencyStamp = "32cd6c9a-ee34-4b78-a000-919d741f2854",
                    Role = Role.SupportAgent
                }
            );
        }
    }
}