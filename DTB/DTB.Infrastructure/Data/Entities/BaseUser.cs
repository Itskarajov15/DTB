namespace DTB.Infrastructure.Data.Entities
{
    public abstract class BaseUser
    {
        public string Id { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string ProfilePicture { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}