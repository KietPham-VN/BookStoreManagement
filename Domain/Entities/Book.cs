using Domain.Commons.BaseEntities;

namespace Domain.Entities;

public class Book : AuditableEntity
{
    public Guid BookId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;

    public ICollection<BookCategory> BookCategories { get; set; } = [];
    public ICollection<Review> Reviews { get; set; } = [];
}