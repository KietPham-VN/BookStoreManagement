namespace Domain.Commons.BaseEntities;

public abstract class AuditableEntity : CreatedOnlyEntity
{
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}