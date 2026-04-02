using CRM.Domain.Entities.Core;
using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.Supporting;

namespace CRM.Domain.Entities.SalesPipeline
{
    public class Activity
    {
        public Guid Id { get; set; }
        public CRMType Type { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public string Subject { get; set; } = default!;
        public ICollection<Note>? Notes { get; set; }
        public RelatedTo RelatedTo { get; set; }
        public Guid CreatedBy { get; set; }
    }
}