using Domain.Commons.BaseEntities;

namespace Domain.Entities;

public class Category : AuditableEntity
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<BookCategory> BookCategories { get; set; } = [];
}