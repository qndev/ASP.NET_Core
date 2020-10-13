using System;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface IAuditedTimeEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime DeletedAt { get; set; }
    }
}
