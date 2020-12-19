using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.LectureAggregate
{
    public class Lecture : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string LectureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Byte Type { get; set; }
        public string DoccumentUrl { get; set; }
        public string UserId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public ICollection<CourseLecture> CourseLectures { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
