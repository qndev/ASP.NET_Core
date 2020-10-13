using System;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class AnswerUser : BaseEntity, IAuditedTimeEntity
    {
        public int AnswerId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public int QuestionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
