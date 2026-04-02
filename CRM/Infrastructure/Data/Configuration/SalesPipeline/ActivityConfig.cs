using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.SalesPipeline;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.SalesPipeline
{
    // -------------------- Activity --------------------
    public class ActivityConfig : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Type).IsRequired();
            builder.Property(a => a.Subject).IsRequired().HasMaxLength(200);
            builder.Property(a => a.CreatedBy).IsRequired();
            builder.Property(a => a.RelatedTo).IsRequired();

            builder.HasOne(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(a => a.CustomerId);

            builder.HasData(new Activity
            {
                Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                Type = Domain.Entities.Enums.CRMType.Call,
                Subject = "Default activity",
                CreatedBy = Guid.Parse("aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                RelatedTo = RelatedTo.Customer,
                CustomerId = Guid.Parse("11111111-1111-1111-1111-111111111111")
            });
        }
    }
}