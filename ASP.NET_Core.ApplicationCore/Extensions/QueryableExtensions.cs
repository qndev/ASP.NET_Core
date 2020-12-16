using System;
using System.Linq;

namespace ASP.NET_Core.ApplicationCore.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, int skipCount, int pageSize)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            return query.Skip(skipCount).Take(pageSize);
        }
    }
}
