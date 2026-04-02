using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.Supporting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Supporting
{
    // -------------------- Task --------------------
    public class TaskConfig : IEntityTypeConfiguration<SupportTask>
    {
        public void Configure(EntityTypeBuilder<SupportTask> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.DueDate).IsRequired();
            builder.Property(t => t.AssignedTo).IsRequired();
            builder.Property(t => t.RelatedTo).IsRequired();

            builder.HasData(new SupportTask
            {
                Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                DueDate = new(2026, 5, 15),
                AssignedTo = Guid.Parse("aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                RelatedTo = RelatedTo.Customer
            });
        }
    }
}