namespace DTB.Infrastructure.Data.Entities
{
    public class Company : BaseUser
    {
        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string Industry { get; set; } = null!;

        public List<Position> Positions { get; set; } = new();

        public List<Location> Locations { get; set; } = new();
    }
}