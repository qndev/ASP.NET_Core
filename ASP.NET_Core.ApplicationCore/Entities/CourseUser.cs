using System;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseUser : BaseEntity
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public Byte OrderStatus { get; set; }
        public Byte OrderType { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime PaymentDateTime { get; set; }
    }
}
