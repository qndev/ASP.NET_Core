using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class User : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public Byte Gender { get; set; }
        public string ImageUrl { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public  ICollection<Comment> Comments { get; set; }
        public  ICollection<Subject> Subjects { get; set; }
        public  ICollection<CourseUser> CourseUsers { get; set; }
        public  ICollection<AnswerUser> AnswerUsers { get; set; }
        public  ICollection<Faq> Faqs { get; set; }
        public  ICollection<News> News { get; set; }
    }
}
