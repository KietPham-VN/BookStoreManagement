using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
{
    public void Configure(EntityTypeBuilder<BookCategory> builder)
    {
        builder.HasKey(bc => bc.BookCategoryId);

        builder.HasOne(bc => bc.Book)
               .WithMany(b => b.BookCategories)
               .HasForeignKey(bc => bc.BookId);

        builder.HasOne(bc => bc.Category)
               .WithMany(c => c.BookCategories)
               .HasForeignKey(bc => bc.CategoryId);
    }
}