using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.CourseAggregate
{
    public class Subject : BaseEntity<int>, ICreator, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
        public  ICollection<Course> Courses { get; set; }
    }
}
