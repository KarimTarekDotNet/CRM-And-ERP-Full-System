using CRM.Domain.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Core
{
    // -------------------- Contact --------------------
    public class ContactConfig : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(150);
            builder.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(20);

            builder.HasOne(x => x.Customer)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(c => c.PhoneNumber).IsUnique();

            // Seed
            builder.HasData(new Contact
            {
                Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                Name = "Default Contact",
                PhoneNumber = "0100000000",
                CustomerId = Guid.Parse("11111111-1111-1111-1111-111111111111")
            });
        }
    }
}