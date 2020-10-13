using System;

namespace ASP.NET_Core.ApplicationCore.Entities
{
    public class News : BaseEntity
    {
        public int Title { get; set; }
        public string Content { get; set; }
    }
}
