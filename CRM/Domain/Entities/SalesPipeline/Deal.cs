using CRM.Domain.Entities.Core;
using CRM.Domain.Entities.Enums;

namespace CRM.Domain.Entities.SalesPipeline
{
    public class Deal
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public decimal value { get; set; }
        public DateTime ExpectedCloseDate { get; set; }
        public Stage Stage { get; set; }
        public Guid AssignedTo { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}