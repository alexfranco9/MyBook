using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyBookWeb.Models;

public class Category
{
	[Key]
	public int Id { get; set; }

	[Required]
	public string Name { get; set; }

	[DisplayName("Display Order")]
	public int DisplayOrder  { get; set; }

	public DateTime CreatedDateTime { get; set; } = DateTime.Now;

	public DateTime UpdatedDateTime { get; set; } = DateTime.Now;
}