using System;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Question : BaseEntity, IOrderNumberProperty
    {
        public int ExerciseId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
