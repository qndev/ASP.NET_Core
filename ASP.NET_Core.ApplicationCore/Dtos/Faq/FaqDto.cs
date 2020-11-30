using System;

namespace ASP.NET_Core.ApplicationCore.Dtos.Faq
{
    public class FaqDto : EntityDto
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
