using CodingTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingTest.Persistence.JsonFile.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
  public void Configure(EntityTypeBuilder<Author> modelBuilder)
  {
    modelBuilder.Property(t => t.Name)
        .HasMaxLength(200)
        .IsRequired();
    
    modelBuilder
      .HasMany(t => t.Books)
      .WithOne(t => t.Author)
      .HasForeignKey(t => t.BookId)
      .IsRequired();
  }
}