using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class AnswerUser : BaseEntity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int AnswerId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public int QuestionId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
