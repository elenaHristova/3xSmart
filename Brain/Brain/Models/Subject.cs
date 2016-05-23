using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public class Subject
	{
		public Subject(int id, string name, int userId)
		{
			this.SubjectId = id;
			this.Name = name;
			this.UserId = userId;
		}

		public int SubjectId { get; set; }
		public string Name { get; set; }
		public int UserId { get; set; }
	}
}