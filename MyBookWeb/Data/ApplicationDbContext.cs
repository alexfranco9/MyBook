using System;
using MyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MyBookWeb.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
	}
}