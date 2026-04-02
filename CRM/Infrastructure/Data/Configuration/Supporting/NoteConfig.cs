using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.Supporting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRM.Infrastructure.Data.Configuration.Supporting
{
    // -------------------- Note --------------------
    public class NoteConfig : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Content).IsRequired();
            builder.Property(n => n.CreatedBy).IsRequired();
            builder.Property(n => n.RelatedTo).IsRequired();

            builder.HasData(new Note
            {
                Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                Content = "Default note content",
                CreatedBy = Guid.Parse("aaaaaaa1-aaaa-aaaa-aaaa-aaaaaaaaaaa1"),
                RelatedTo = RelatedTo.Customer
            });
        }
    }
}