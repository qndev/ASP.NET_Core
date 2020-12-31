using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Constants;
using ASP.NET_Core.ApplicationCore.Interfaces;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;
using ASP.NET_Core.Infrastructure.Data;
using ASP.NET_Core.MvcWebApp.Models;
using ASP.NET_Core.MvcWebApp.Models.NewsViewModels;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Authorize]
    public class NewsController : BaseController
    {
        private readonly InfrastructureContext _dbContext;
        private readonly INewsService<News, string> _newsService;
        private readonly ICurrentUserService _currentUserService;
        private readonly ILogger _logger;
        private readonly IDateTime _dateTime;

        public NewsController(
            InfrastructureContext dbContext,
            INewsService<News, string> newsService,
            ICurrentUserService currentUserService,
            ILogger<SubjectController> logger,
            IDateTime dateTime
        )
        {
            _dbContext = dbContext;
            _newsService = newsService;
            _currentUserService = currentUserService;
            _logger = logger;
            _dateTime = dateTime;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? pageNumber)
        {
            return View(await PaginatedList<News>.GetPaginatedListAsync(
                                                        _dbContext.News
                                                            .Include(u => u.User)
                                                            .Select(n => new News
                                                            {
                                                                NewsId = n.NewsId,
                                                                Title = n.Title,
                                                                Content = n.Content,
                                                                CreationTime = n.CreationTime,
                                                                User = new User
                                                                {
                                                                    LastName = n.User.LastName,
                                                                    Email = n.User.Email
                                                                }
                                                            }).AsNoTracking(),
                                                        pageNumber ?? Constants.Pagging.DEFAULT_PAGE_INDEX,
                                                        Constants.Pagging.PAGE_SIZE));
        }

        [HttpGet]
        public async Task<ActionResult<Faq>> Details(string newsId)
        {
            var newsDetails = await _newsService.GetNewsByIdAsync(newsId, Constants.EntityKey.NEWS_ID);
            if (newsDetails == null)
            {
                _logger.LogInformation("News Not found");
                return NotFound("News Not found");
            }
            var newsViewModel = new NewsViewModel
            {
                NewsId = newsDetails.NewsId,
                Title = newsDetails.Title,
                Content = newsDetails.Content,
                CreationTime = newsDetails.CreationTime
            };
            return View(newsViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Subject>> Create([FromForm] CreateOrUpdateNewsViewModel createNewsViewModel)
        {
            if (createNewsViewModel == null)
            {
                return NoContent();
            }
            if (ModelState.IsValid)
            {
                News news = new News
                {
                    Title = createNewsViewModel.Title,
                    Content = createNewsViewModel.Content,
                    UserId = _currentUserService.UserId,
                    CreationTime = _dateTime.Now
                };
                var createdResult = await _newsService.CreateNewsAsync(news);
                if (createdResult.Item2)
                {
                    return Ok("Successfully created Subject!");
                }
                return BadRequest("Something went wrong when create Subject.");
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string newsId)
        {
            if (newsId == null)
            {
                return NotFound("Notfound news");
            }
            var newsDetails = await _newsService.GetNewsByIdAsync(newsId, Constants.EntityKey.NEWS_ID);
            if (newsDetails == null)
            {
                return NotFound("Notfound news");
            }
            var updateNewsViewModel = new CreateOrUpdateNewsViewModel
            {
                NewsId = newsDetails.NewsId,
                Title = newsDetails.Title,
                Content = newsDetails.Content
            };
            return View(updateNewsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] CreateOrUpdateNewsViewModel updateNewsViewModel)
        {
            if (updateNewsViewModel.NewsId == null)
            {
                return NotFound("Notfound");
            }
            News news = new News
            {
                NewsId = updateNewsViewModel.NewsId,
                Title = updateNewsViewModel.Title,
                Content = updateNewsViewModel.Content
            };
            var updatedResult = await _newsService.UpdateNewsAsync(news);
            if (updatedResult.Item2)
            {
                return View("Details", updateNewsViewModel);
            }
            return BadRequest();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string newsId)
        {
            var newsDetails = await _newsService.GetNewsByIdAsync(newsId, Constants.EntityKey.NEWS_ID);
            if (newsDetails == null)
            {
                return NotFound();
            }
            if (await _newsService.DeleteNewsAsync(newsDetails))
            {
                return RedirectToAction("Index");
            }
            return View("Error");
        }
    }
}
