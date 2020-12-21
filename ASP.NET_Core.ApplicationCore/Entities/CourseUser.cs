using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseUser : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string CourseUserId { get; set; }
        public string CourseId { get; set; }
        public string UserId { get; set; }
        public Byte OrderStatus { get; set; }
        public Byte OrderType { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
