using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class News : IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public string NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public User User { get; set; }
        public News()
        {
            NewsId = "news-" + Guid.NewGuid().ToString();
        }
    }
}
