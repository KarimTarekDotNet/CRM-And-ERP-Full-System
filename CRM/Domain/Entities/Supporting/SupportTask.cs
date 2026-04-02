using CRM.Domain.Entities.Enums;

namespace CRM.Domain.Entities.Supporting
{
    public class SupportTask
    {
        public Guid Id { get; set; }
        public DateTime DueDate { get; set; }
        public Guid AssignedTo { get; set; }
        public RelatedTo RelatedTo { get; set; }
    }
}
