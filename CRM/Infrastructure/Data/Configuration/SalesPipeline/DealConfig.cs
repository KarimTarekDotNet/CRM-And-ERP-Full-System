using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.SalesPipeline;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.SalesPipeline
{
    // -------------------- Deal --------------------
    public class DealConfig : IEntityTypeConfiguration<Deal>
    {
        public void Configure(EntityTypeBuilder<Deal> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.value).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(d => d.ExpectedCloseDate).IsRequired();
            builder.Property(d => d.Stage).IsRequired();

            builder.HasOne(d => d.Customer)
                .WithMany(c => c.Deals)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(d => d.CustomerId);

            builder.HasData(new Deal
            {
                Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                CustomerId = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                value = 1000m,
                ExpectedCloseDate = new(2026, 5, 1),
                Stage = Stage.Prospecting,
                AssignedTo = Guid.Parse("aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1")
            });
        }
    }
}