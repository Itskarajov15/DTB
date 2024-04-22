using DTB.Core.Contracts;
using DTB.Infrastructure.Data;
using DTB.ViewModels.Job;
using Microsoft.EntityFrameworkCore;

namespace DTB.Core.Services
{
    public class JobService : IJobService
    {
        private readonly ApplicationDbContext context;

        public JobService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<GetAllJobsViewModel>> GetAllJobsAsync()
        {
            return await context
            .JobAds
            .Include(j => j.Company)
            .Select(a => new GetAllJobsViewModel
            {
                Id = a.Id,
                Profession = a.Profession.Name,
                Experience = a.Experience,
                Description = a.Description,
                Company = "Nai-dobrata firma",
                Location = a.Location.Name,
                Category = a.Category.Name
            })
            .ToListAsync();
        }

        public async Task<JobViewModel> GetJobById(string id)
        {
            var result = await context
            .JobAds
            .Include(j => j.Company)
            .Where(j => j.Id == id)
            .Select(a => new JobViewModel
            {
                Id = a.Id,
                Profession = a.Profession.Name,
                Experience = a.Experience,
                Description = a.Description,
                Company = "Nai-dobrata firma",
                Location = a.Location.Name,
                Category = a.Category.Name
            })
            .FirstOrDefaultAsync();

            return result;
        }
    }
}
