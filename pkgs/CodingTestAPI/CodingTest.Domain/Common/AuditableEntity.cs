using System;
namespace CodingTest.Domain.Common
{
	public class AuditableEntity
	{
		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
	}
}

