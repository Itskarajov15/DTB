namespace DTB.Infrastructure.Data.Entities
{
    public class Status
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public List<BaseUser> Users { get; set; } = new();
    }
}