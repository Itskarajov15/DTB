using DTB.Core.Contracts;
using DTB.Core.Models.Locations;
using DTB.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DTB.Core.Services
{
    public class LocationService : ILocationService
    {
        private readonly ApplicationDbContext _context;

        public LocationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LocationViewModel>> GetAllLocationsAsync()
        {
            return await _context
                .Locations
                .Select(l => new LocationViewModel
                {
                    Id = l.Id,
                    Name = l.Name
                })
                .OrderBy(l => l.Name)
                .ToListAsync();
        }
    }
}