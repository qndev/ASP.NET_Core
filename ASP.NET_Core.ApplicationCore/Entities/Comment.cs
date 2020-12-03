using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Comment : BaseEntity<int>, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int ParentId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public int LectureId { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
    }
}
