using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Faq : BaseEntity<int>, ICreator, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
    }
}
