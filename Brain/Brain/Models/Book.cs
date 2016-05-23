using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public class Book
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public int UserId { get; set; }
	}
}