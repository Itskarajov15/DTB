using DTB.ViewModels.Job;

namespace DTB.Core.Contracts
{
    public interface IJobService
    {
        Task<List<GetAllJobsViewModel>> GetAllJobsAsync();
    }
}
