using DTB.Core.Contracts;
using DTB.ViewModels.Job;
using Microsoft.AspNetCore.Mvc;

namespace DTB.Controllers
{
    public class JobController : Controller
    {
        private readonly ILogger<JobController> _logger;
        private readonly ICategoryService _categoryService;
        private readonly ILocationService _locationService;
        private readonly IJobService _jobService;

        public JobController(
            ILogger<JobController> logger,
            ICategoryService categoryService,
            ILocationService locationService,
            IJobService jobService)
        {
            _logger = logger;
            _categoryService = categoryService;
            _locationService = locationService;
            _jobService = jobService;
        }

        public async Task<IActionResult> Job(string id)
        {
            var job = await _jobService.GetJobById(id);
            return View(job);
        }

        public async Task<IActionResult> All()
        {
            var jobs = await _jobService.GetAllJobsAsync();
            return View(jobs);
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddJobViewModel viewModel = new AddJobViewModel();

            //viewModel.Id = GetUserId();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddJobViewModel model)
        {
            //model.AuthorId = User.Identity.Name;
            //await articleService.AddArticleAsync(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
