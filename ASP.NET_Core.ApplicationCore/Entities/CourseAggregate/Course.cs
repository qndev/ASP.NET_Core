using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.CourseAggregate
{
    public class Course : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string CourseId { get; set; }
        public string SubjectId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Resources { get; set; }
        public decimal Price { get; set; }
        public string ImageFile { get; set; }
        public Byte Status { get; set; }
        public string UserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public Subject Subject { get; set; }
        public  ICollection<CourseLecture> CourseLectures { get; set; }
        public  ICollection<CourseUser> CourseUsers { get; set; }
    }
}
