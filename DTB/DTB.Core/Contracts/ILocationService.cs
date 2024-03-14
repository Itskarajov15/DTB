using DTB.Core.Models.Locations;

namespace DTB.Core.Contracts
{
    public interface ILocationService
    {
        Task<List<LocationViewModel>> GetAllLocationsAsync();
    }
}