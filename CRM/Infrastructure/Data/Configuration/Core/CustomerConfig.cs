using CRM.Domain.Entities.Core;
using CRM.Domain.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CRM.Infrastructure.Data.Configuration.Core
{
    // -------------------- Customer --------------------
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(150);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.CreatedAt).IsRequired();
            builder.Property(c => c.Source).IsRequired();

            builder.HasOne(c => c.Account)
                .WithMany(a => a.Customers)
                .HasForeignKey(c => c.AccountId);

            builder.HasOne(c => c.Owner)
                .WithMany()
                .HasForeignKey(c => c.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.ConvertedFromLead)
                .WithMany()
                .HasForeignKey(c => c.ConvertedFromLeadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Contacts)
                .WithOne(x => x.Customer)
                .HasForeignKey(ct => ct.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(c => c.Email).IsUnique();
            builder.HasIndex(c => c.PhoneNumber).IsUnique();

            // Seed
            builder.HasData(new Customer
            {
                Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                Name = "Default Customer",
                PhoneNumber = "0123456789",
                Email = "default@customer.com",
                Status = CustomerStatus.Active,
                CreatedAt = new(2026, 4, 2),
                Source = Source.Website,
                OwnerId = "aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1",
                AccountId = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                ConvertedFromLeadId = Guid.Parse("33333333-3333-3333-3333-333333333333")
            });
        }
    }
}