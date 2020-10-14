using System;
using ASP.NET_Core.ApplicationCore.Entities.Common;

namespace ASP.NET_Core.ApplicationCore.Entities.LectureAggregate
{
    public class Lecture : BaseEntity, ICreator, IHasCreationTime, IHasDeletionTime, IHasModificationTime
    {
        public int Name { get; set; }
        public string Description { get; set; }
        public Byte Type { get; set; }
        public DateTime DoccumentUrl { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? DeletionTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
