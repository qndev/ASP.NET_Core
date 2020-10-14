using System;

namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}
