using CRM.Domain.Entities.Enums;

namespace CRM.Domain.Entities.Supporting
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = default!;
        public Guid CreatedBy { get; set; }
        public RelatedTo RelatedTo { get; set; }
    }
}
