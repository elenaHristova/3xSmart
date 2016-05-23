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

			List<Book> books = new List<Book>
			{
				new Book("Pod Igoto","Ivan Vazov",1),
				new Book("Geracite","Elin Pelin",1),
				new Book("Bai Ganio","Aleko",1),
				new Book("Geracite","Elin Pelin",2),
				new Book("Geracite","Elin Pelin",3),
			};

			foreach (var book in books)
			{
				context.Books.Add(book);
			}
			context.SaveChanges();

			List<Subject> subjects = new List<Subject>
			{
				new Subject(1,"Physics",1),
				new Subject(2,"Biology",1),
				new Subject(3,"Programming",2),
				new Subject(4,"ComputerScience",2),
				new Subject(5,"OperatingSystems",2),
				new Subject(6,"Medicine",3),
				new Subject(7,"Botany",3),

			};

			foreach (var subject in subjects)
			{
				context.Subjects.Add(subject);
			}
			context.SaveChanges();

			List<PersonalInfo> personalInfos = new List<PersonalInfo>
			{
				new PersonalInfo("Petur Stoqnov",20,"male",1),
				new PersonalInfo("Petya Koleva", 24,"female",2),
				new PersonalInfo("Nikolay Lechev",34,"male",3),
			};

			foreach (var pi in personalInfos)
			{
				context.PersonalInfo.Add(pi);
			}
			context.SaveChanges();

			List<Hours> hoursList = new List<Hours>
			{
				new Hours(7,new int[] {1}, 1),
				new Hours(8,new int[] {2}, 2),
				new Hours(9,new int[] {3}, 3),
			};

			foreach (var hours in hoursList)
			{
				context.Hours.Add(hours);
			}
			context.SaveChanges();
		}
	}
}