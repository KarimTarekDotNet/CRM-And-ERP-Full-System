using CRM.Domain.Entities.Enums;
using CRM.Domain.Entities.SalesPipeline;
using CRM.Domain.Entities.Supporting;

namespace CRM.Domain.Entities.Core
{
    public class Customer // Represents a customer in the CRM system
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public string? Email { get; set; }
        public CustomerStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Source Source { get; set; }

        public Guid? AccountId { get; set; }
        public Account? Account { get; set; }
        public string OwnerId { get; set; } = null!;
        public User Owner { get; set; } = null!;
        public Guid? ConvertedFromLeadId { get; set; }
        public Lead? ConvertedFromLead { get; set; }

        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public ICollection<Deal> Deals { get; set; } = new List<Deal>();
    }
}