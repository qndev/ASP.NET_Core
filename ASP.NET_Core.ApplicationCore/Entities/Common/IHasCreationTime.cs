using System;

namespace ASP.NET_Core.ApplicationCore.Entities.Common
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}
