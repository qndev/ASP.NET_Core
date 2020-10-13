using System;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class Faq : BaseEntity
    {
        public int Question { get; set; }
        public string Answer { get; set; }
        public Byte Type { get; set; }
        public DateTime DoccumentUrl { get; set; }
    }
}
