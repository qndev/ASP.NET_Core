using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Comment : BaseEntity<int>, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string CommentId { get; set; }
        public string ParentId { get; set; }
        public string UserId { get; set; }
        public string CourseId { get; set; }
        public string LectureId { get; set; }
        public string CommentContent { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
    }
}
