using System.ComponentModel.DataAnnotations;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;
using ASP.NET_Core.ApplicationCore.Interfaces;

namespace ASP.NET_Core.MvcWebApp.Models.SubjectViewModels
{
    public class SubjectViewModel
    {
        public string SubjectId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Subject *")]
        public string Name { get; set; }

        public static Subject MapSubjectViewModelToEntity(SubjectViewModel subjectViewModel)
        {
            return new Subject
            {
                Name = subjectViewModel.Name
            };
        }
    }
}
