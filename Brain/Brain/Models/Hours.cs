using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brain.Models
{
	public class Hours
	{
		public Hours(int sleepHours, int[] args, int userId )
		{
			this.SleepHours = sleepHours;
			this.UserId = userId;
		}

		public int HoursId { get; set; }
		public int SleepHours { get; set; }
		public int Nap { get; set; }
		public int WorkHours { get; set; }
		public int TrainHours { get; set; }
		public int UserId { get; set; }
	}
}