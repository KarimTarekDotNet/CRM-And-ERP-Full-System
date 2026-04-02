using CRM.Domain.Entities.Core;
using CRM.Domain.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Core
{
    // -------------------- Lead --------------------
    public class LeadConfig : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name).IsRequired().HasMaxLength(150);
            builder.Property(l => l.Email).IsRequired().HasMaxLength(100);
            builder.Property(l => l.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(l => l.Status).IsRequired();
            builder.Property(l => l.CreatedAt).IsRequired();

            builder.HasIndex(l => l.Email).IsUnique();
            builder.HasIndex(l => l.PhoneNumber).IsUnique();

            // Seed
            builder.HasData(new Lead
            {
                Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                Name = "Default Lead",
                Email = "lead@crm.com",
                PhoneNumber = "01111111111",
                Status = LeadStatus.New,
                AssignedToId = Guid.Parse("aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                CreatedAt = new(2026, 4, 2)
            });
        }
    }
}