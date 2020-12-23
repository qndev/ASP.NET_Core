using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.ApplicationCore.Interfaces
{
    public interface ISubjectService : IAsyncCrudService<Subject, string>
    {
    }
}
