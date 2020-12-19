using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class AnswerUser : BaseEntity<int>, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string AnswerUserId { get; set; }
        public string AnswerId { get; set; }
        public string UserId { get; set; }
        public string CourseId { get; set; }
        public string LectureId { get; set; }
        public string QuestionId { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Answer Answer { get; set; }
        public User User { get; set; }
    }
}
