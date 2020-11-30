using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseUser : Entity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public Byte OrderStatus { get; set; }
        public Byte OrderType { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
