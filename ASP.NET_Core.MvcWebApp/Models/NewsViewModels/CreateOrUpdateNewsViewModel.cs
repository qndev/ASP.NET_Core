using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core.MvcWebApp.Models.NewsViewModels
{
    public class CreateOrUpdateNewsViewModel
    {
        public string NewsId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Title *")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Content *")]
        public string Content { get; set; }
    }
}
