using System;
using System.Collections.Generic;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.LectureAggregate
{
    public class Question : BaseEntity<int>, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string QuestionId { get; set; }
        public string ExerciseId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public Exercise Exercise { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
