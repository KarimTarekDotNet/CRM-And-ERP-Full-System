using CRM.Domain.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace CRM.Domain.Entities.Supporting
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = default!;
        public Role Role { get; set; }
    }
}
