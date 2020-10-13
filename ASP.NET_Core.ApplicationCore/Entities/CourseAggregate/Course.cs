using System;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Entities.CourseAggregate
{
    public class Course : BaseEntity, IAuditedUserEntity, IAuditedTimeEntity
    {
        public int SubjectId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Resources { get; set; }
        public decimal Price { get; set; }
        public string ImageFile { get; set; }
        public Byte Status { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
