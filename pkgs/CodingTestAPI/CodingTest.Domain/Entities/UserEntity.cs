using System;
using CodingTest.Domain.Common;

namespace CodingTest.Domain.Entities
{
  public class UserEntity: AuditableEntity
  {
    public Guid UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
  }
}

