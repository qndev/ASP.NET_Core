using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core.MvcWebApp.Models.FaqViewModels
{
    public class FaqViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Answer is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Answer *")]
        public string Answer { get; set; }

        [Required(ErrorMessage = "Question is required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Question *")]
        public string Question { get; set; }
    }
}