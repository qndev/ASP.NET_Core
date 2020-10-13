using System;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseLecture : BaseEntity, IAuditedUserEntity, IAuditedTimeEntity, IOrderNumberProperty
    {
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public int OrderNumber { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
