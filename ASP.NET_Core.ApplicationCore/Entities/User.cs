using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class User : BaseEntity, ICreator, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Byte Type { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public Byte Gender { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public DateTime EmailVerifiedAt { get; set; }
        public string RememberToken { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
