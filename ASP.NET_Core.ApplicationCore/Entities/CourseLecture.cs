using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseLecture : BaseEntity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Course Course { get; set; }
        public Lecture Lecture { get; set; }
    }
}
