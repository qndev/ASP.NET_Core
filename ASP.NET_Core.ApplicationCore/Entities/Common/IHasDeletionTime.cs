using System;

namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    public interface IHasDeletionTime
    {
        DateTime? DeletionTime { get; set; }
    }
}
