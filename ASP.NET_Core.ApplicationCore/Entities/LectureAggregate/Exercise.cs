using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.LectureAggregate
{
    public class Exercise : BaseEntity, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int LectureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
