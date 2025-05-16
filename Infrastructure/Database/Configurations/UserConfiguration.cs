using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.UserId);

        builder.HasIndex(u => u.Email).IsUnique();
        builder.Property(u => u.Email)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(u => u.Password)
               .IsRequired();

        builder.Property(u => u.FirstName)
               .HasMaxLength(100);
        builder.Property(u => u.LastName)
               .HasMaxLength(100);

        builder.Property(u => u.DateOfBirth)
               .IsRequired();

        builder.Property(u => u.Role)
               .IsRequired();

        builder.Property(u => u.CreatedAt)
               .IsRequired();
        builder.Property(u => u.UpdatedAt)
               .IsRequired();

        builder.HasMany(u => u.RefreshTokens)
               .WithOne(rt => rt.User)
               .HasForeignKey(rt => rt.UserId);

        builder.HasMany(u => u.Reviews)
              .WithOne(r => r.User)
              .HasForeignKey(r => r.UserId);
    }
}