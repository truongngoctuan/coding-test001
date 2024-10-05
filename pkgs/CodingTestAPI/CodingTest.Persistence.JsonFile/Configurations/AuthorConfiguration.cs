using CodingTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingTest.Persistence.JsonFile.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
  public void Configure(EntityTypeBuilder<Author> builder)
  {
    builder.Property(t => t.Name)
        .HasMaxLength(200)
        .IsRequired();
  }
}