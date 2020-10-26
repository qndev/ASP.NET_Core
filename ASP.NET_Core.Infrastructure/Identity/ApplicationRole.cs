using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core.Infrastructure.Identity
{
    public class ApplicationRole : IdentityRole<int>
    {
        public string Description { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
