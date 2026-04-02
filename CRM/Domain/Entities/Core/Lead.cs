using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.Supporting;

namespace CRM.Domain.Entities.Core
{
    public class Lead // A potential customer who has shown interest but has not yet been qualified
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public Guid AssignedToId { get; set; }
        public LeadStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}