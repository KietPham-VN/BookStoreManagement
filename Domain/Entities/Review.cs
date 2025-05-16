namespace Domain.Entities;

public class Review
{
    public Guid ReviewId { get; set; }
    public int Rate { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Guid BookId { get; set; }
    public Book? Book { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }
}