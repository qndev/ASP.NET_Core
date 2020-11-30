using System.ComponentModel.DataAnnotations;
using ASP.NET_Core.ApplicationCore.Dtos;

namespace ASP.NET_Core.ApplicationCore.Dtos.Faq
{
    public class CreateUpdateFaqDto
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
