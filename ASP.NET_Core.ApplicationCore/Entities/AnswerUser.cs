using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class AnswerUser : BaseEntity<int>, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int AnswerId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public int QuestionId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Answer Answer { get; set; }
        public User User { get; set; }
    }
}
