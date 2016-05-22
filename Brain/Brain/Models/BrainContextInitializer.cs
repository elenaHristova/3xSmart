using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public class BrainContextInitializer : DropCreateDatabaseIfModelChanges<BrainContext>
	{
		protected override void Seed(BrainContext context)
		{
			List<User> users=new List<User>
			{
				new User() {UserId = 1, Username = "pesho",Password = "123"},
				new User() {UserId = 2,Username = "peti",Password = "123"},
                new User() {UserId = 3,Username = "niki",Password = "123"}

			};

			foreach (var user in users)
			{
				context.Users.Add(user);
			}
			context.SaveChanges();

		}
	}
}