using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Faq : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string FaqId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string UserId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
    }
}
