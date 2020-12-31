using System;
using ASP.NET_Core.ApplicationCore.Entities;

namespace ASP.NET_Core.MvcWebApp.Models.NewsViewModels
{
    public class NewsViewModel
    {
        public string NewsId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? CreationTime { get; set; }
        public User User { get; set; }
    }
}
