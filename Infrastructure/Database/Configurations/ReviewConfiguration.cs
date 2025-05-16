using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasKey(r => r.ReviewId);

        builder.Property(r => r.Rate)
               .IsRequired();

        builder.Property(r => r.Content)
               .HasMaxLength(1000);

        builder.Property(r => r.CreatedAt)
               .IsRequired();

        builder.HasOne(r => r.User)
               .WithMany(u => u.Reviews)
               .HasForeignKey(r => r.UserId);

        builder.HasOne(r => r.Book)
               .WithMany(b => b.Reviews)
               .HasForeignKey(r => r.BookId);
    }
}