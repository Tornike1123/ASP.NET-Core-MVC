using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public int DisplayOrder { get; set; }

		public DateTime CreateedDateTime { get; set; } = DateTime.Now;
	}
}

