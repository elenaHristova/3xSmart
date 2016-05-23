using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public class BrainContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<PersonalInfo> PersonalInfo { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Book> Books { get; set; }  
		public DbSet<Hours> Hours { get; set; }  

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}