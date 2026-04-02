using CRM.Domain.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Domain.Seeding
{
    public static class SeedRole
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { Role.Admin.ToString(), Role.SalesManager.ToString(), Role.SalesRep.ToString(),
                               Role.SupportAgent.ToString()};

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
