using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace FinalProjectTest.Models
{
    public class UserViewModel
    {
        public IEnumerable<InventoryUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
