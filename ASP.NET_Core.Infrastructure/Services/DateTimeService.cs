using System;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
