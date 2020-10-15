using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.LectureAggregate
{
    public class Answer : BaseEntity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int QuestionId { get; set; }
        public string Content { get; set; }
        public string CorrectFlag { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}