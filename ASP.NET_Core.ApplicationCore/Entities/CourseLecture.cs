using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseLecture : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string CourseLectureId { get; set; }
        public string CourseId { get; set; }
        public string LectureId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Course Course { get; set; }
        public Lecture Lecture { get; set; }
    }
}
