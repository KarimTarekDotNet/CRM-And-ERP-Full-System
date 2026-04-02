namespace CRM.Domain.Entities.Core
{
    public class Account // Represents a company or organization that is a customer of the business
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Industry { get; set; } = default!;
        public Guid AssignedToId { get; set; }
        public int Size { get; set; }
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}