using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public class PersonalInfo
	{
		public PersonalInfo(string name, int age,string sex)
		{
			this.Name = name;
			this.Age = age;
			this.Sex = sex;
		}
		public int PersonalInfoId { get; set; }
		//public byte[] Avatar { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Sex { get; set; }
		public int UserId { get; set; }
	}
}