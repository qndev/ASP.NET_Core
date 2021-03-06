using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.LectureAggregate
{
    public class Answer : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string AnswerId { get; set; }
        public string QuestionId { get; set; }
        public string Content { get; set; }
        public bool CorrectFlag { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Question Question { get; set; }
        public ICollection<AnswerUser> AnswerUsers { get; set; }
    }
}
