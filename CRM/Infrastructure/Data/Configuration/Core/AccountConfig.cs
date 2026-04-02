using CRM.Domain.Entities.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Core
{
    // -------------------- Account --------------------
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(150);
            builder.Property(a => a.Industry).HasMaxLength(100);
            builder.Property(a => a.Size).IsRequired();
            builder.Property(a => a.AssignedToId).IsRequired();

            builder.HasMany(a => a.Customers)
                .WithOne(c => c.Account)
                .HasForeignKey(c => c.AccountId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasIndex(a => a.Name).IsUnique();

            // Seed
            builder.HasData(new Account
            {
                Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                Name = "Default Account",
                Industry = "Software",
                Size = 50,
                AssignedToId = Guid.Parse("aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1")
            });
        }
    }
}