namespace DTB.Infrastructure.Data.Entities
{
    public class File
    {
        public string Id { get; set; } = null!;

        public string Name { get; set; } = null!;

        public List<byte> Content { get; set; } = new();
    }
}