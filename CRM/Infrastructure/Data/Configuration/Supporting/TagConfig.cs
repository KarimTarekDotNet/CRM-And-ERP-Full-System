using CRM.Domain.Entities.Supporting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Supporting
{
    // -------------------- Tag --------------------
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);

            builder.HasIndex(t => t.Name).IsUnique();

            // Seed
            builder.HasData(
                new Tag
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    Name = "VIP"
                },
                new Tag
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    Name = "Important"
                },
                new Tag
                {
                    Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    Name = "New Customer"
                }
            );
        }
    }
}