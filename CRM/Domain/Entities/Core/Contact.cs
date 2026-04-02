namespace CRM.Domain.Entities.Core
{
    public class Contact // An individual associated with an account, often a point of contact for business communications
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public string PhoneNumber { get; set; } = default!;
    }
}