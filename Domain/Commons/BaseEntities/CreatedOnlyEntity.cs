namespace Domain.Commons.BaseEntities;

public abstract class CreatedOnlyEntity
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}