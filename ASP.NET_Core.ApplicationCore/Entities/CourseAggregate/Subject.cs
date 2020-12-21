using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.CourseAggregate
{
    public class Subject : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string SubjectId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
        public  ICollection<Course> Courses { get; set; }
    }
}
