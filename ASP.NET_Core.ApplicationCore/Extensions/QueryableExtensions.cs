using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

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

        public static Expression<Func<TSource, bool>> EntityIdComparison<TSource, TPrimaryKey>(TPrimaryKey id, string nameOfEntityKey)
        {
            Type type = typeof(TSource);
            PropertyInfo propertyInfo = type.GetProperty(nameOfEntityKey);
            ParameterExpression parameterExpression = Expression.Parameter(type, "entity");
            MemberExpression memberExpression = Expression.Property(parameterExpression, propertyInfo);
            ConstantExpression constantExpression = Expression.Constant(id, typeof(TPrimaryKey));
            BinaryExpression bodyExpression = Expression.Equal(memberExpression, constantExpression);

            return Expression.Lambda<Func<TSource, bool>>(bodyExpression, parameterExpression);
        }
    }
}
