using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ASP.NET_Core.MvcWebApp.Models;

namespace ASP.NET_Core.MvcWebApp.ViewComponents
{
    public class PaginationViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(object paginatedList)
        {
            return Task.FromResult<IViewComponentResult>(View("Default", paginatedList));
            // return View(paginatedList);
        }

        // public Task<IViewComponentResult> InvokeAsync<T>(PaginatedList<T> paginatedList) where T : class
        // {
        //     return Task.FromResult<IViewComponentResult>(View("Default", paginatedList));
        // }
    }
}
