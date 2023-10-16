using FreelancerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace FreelancerAPI.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{				
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<User> User { get; set; }
	}
}
