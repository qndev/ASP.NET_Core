using System;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Lecture : BaseEntity, IAuditedTimeEntity, IAuditedUserEntity
    {
        public int Name { get; set; }
        public string Description { get; set; }
        public Byte Type { get; set; }
        public DateTime DoccumentUrl { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
