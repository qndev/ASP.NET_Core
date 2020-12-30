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
using ASP.NET_Core.MvcWebApp.Models.SubjectViewModels;

namespace ASP.NET_Core.MvcWebApp.Controllers
{
    [Authorize]
    public class SubjectController : BaseController
    {
        private readonly InfrastructureContext _dbContext;
        private readonly ISubjectService _subjectService;
        private readonly ICurrentUserService _currentUserService;
        private readonly ILogger _logger;

        public SubjectController(
            InfrastructureContext dbContext,
            ISubjectService subjectService,
            ICurrentUserService currentUserService,
            ILogger<SubjectController> logger
        )
        {
            _dbContext = dbContext;
            _subjectService = subjectService;
            _currentUserService = currentUserService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? pageNumber)
        {
            return View(await PaginatedList<Subject>.GetPaginatedListAsync(
                                                        _dbContext.Subjects
                                                            .Include(u => u.User)
                                                            .Select(s => new Subject
                                                            {
                                                                SubjectId = s.SubjectId,
                                                                Name = s.Name,
                                                                User = new User
                                                                {
                                                                    LastName = s.User.LastName,
                                                                    Email = s.User.Email
                                                                }
                                                            }).AsNoTracking(),
                                                        pageNumber ?? Constants.Pagging.DEFAULT_PAGE_INDEX,
                                                        Constants.Pagging.PAGE_SIZE));
        }

        [HttpGet]
        public async Task<ActionResult<Faq>> Details(string subjectId)
        {
            var subjectDetails = await _subjectService.GetAsync(subjectId, Constants.EntityKey.SUBJECT_ID);
            if (subjectDetails == null)
            {
                _logger.LogInformation("Subject Not found");
                return NotFound("Subject Not found");
            }
            var subjectViewModel = new SubjectViewModel
            {
                SubjectId = subjectDetails.SubjectId,
                Name = subjectDetails.Name
            };
            return View(subjectViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult<Subject>> Create([FromForm] SubjectViewModel subjectViewModel)
        {
            if (subjectViewModel == null)
            {
                return NoContent();
            }
            if (ModelState.IsValid)
            {
                Subject subject = SubjectViewModel.MapSubjectViewModelToEntity(subjectViewModel);
                subject.UserId = _currentUserService.UserId;
                subject.ModifiedBy = subject.UserId;
                _logger.LogInformation(subject.UserId);
                var createdResult = await _subjectService.CreateAsync(subject);
                if (createdResult.Item2)
                {
                    return Ok("Successfully created Subject!");
                }
                return BadRequest("Something went wrong when create Subject.");
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string subjectId)
        {
            var subjectDetails = await _subjectService.GetAsync(subjectId, Constants.EntityKey.SUBJECT_ID);
            if (subjectDetails == null)
            {
                return NotFound();
            }
            var subjectViewModel = new SubjectViewModel
            {
                SubjectId = subjectDetails.SubjectId,
                Name = subjectDetails.Name
            };
            return View(subjectViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([FromForm] SubjectViewModel subjectViewModel)
        {
            if (subjectViewModel.SubjectId == null)
            {
                return NotFound("Notfound");
            }
            Subject subject = new Subject
            {
                SubjectId = subjectViewModel.SubjectId,
                Name = subjectViewModel.Name
            };
            var updatedResult = await _subjectService.UpdateAsync(subject);
            if (updatedResult.Item2)
            {
                return View("Details", subjectViewModel);
            }
            return BadRequest();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string subjectId)
        {
            _logger.LogInformation(subjectId);
            if (await _subjectService.DeleteAsync(subjectId, Constants.EntityKey.SUBJECT_ID))
            {
                return RedirectToAction("Index");
            }
            return View("Error");
        }
    }
}
