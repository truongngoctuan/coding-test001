
using CodingTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingTest.Persistence.JsonFile.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
  public void Configure(EntityTypeBuilder<Book> builder)
  {
    builder.Property(t => t.Title)
        .HasMaxLength(200)
        .IsRequired();
    builder.Property(t => t.Description)
        .HasMaxLength(5000)
        .IsRequired();
  }
}