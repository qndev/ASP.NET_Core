using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Core.Infrastructure.Identity
{
    public class ApplicationUserRole : IdentityUserRole<int>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}
