namespace DTB.Infrastructure.Data.Entities
{
    public class Message
    {
        public string Id { get; set; } = null!;

        public BaseUser Sender { get; set; } = null!;

        public BaseUser Receiver { get; set; } = null!;

        public Chat Chat { get; set; } = null!;

        public string Content { get; set; } = null!;
    }
}