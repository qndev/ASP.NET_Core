using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;

namespace ASP.NET_Core.ApplicationCore.Services
{
    public class SubjectService : AsyncCrudService<Subject, string>, ISubjectService
    {
        public SubjectService(IRepository<Subject, string> repository)
            : base(repository)
        {
        }
    }
}
