using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(b => b.BookId);

        builder.Property(b => b.Title)
               .IsRequired()
               .HasMaxLength(200);

        builder.Property(b => b.Description)
               .HasMaxLength(1000);

        builder.Property(b => b.ISBN)
               .HasMaxLength(20);

        builder.Property(b => b.Author)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(b => b.CreatedAt).IsRequired();
        builder.Property(b => b.UpdatedAt).IsRequired();

        builder.HasMany(b => b.BookCategories)
               .WithOne(bc => bc.Book)
               .HasForeignKey(bc => bc.BookId);

        builder.HasMany(b => b.Reviews)
               .WithOne(r => r.Book)
               .HasForeignKey(r => r.BookId);
    }
}