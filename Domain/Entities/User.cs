using Domain.Commons.BaseEntities;
using Domain.Commons.Enums;

namespace Domain.Entities;

public class User : AuditableEntity
{
    public Guid UserId { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public UserRole Role { get; set; } = UserRole.RegisteredUser;
    public ICollection<RefreshToken> RefreshTokens { get; set; } = [];
}