using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class CourseLecture : BaseEntity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public int OrderNumber { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
