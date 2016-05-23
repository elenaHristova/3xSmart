﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brain.Models;

namespace Brain.Controllers
{
	public class HomeController : Controller
	{
		private BrainContext db = new BrainContext();

		public ActionResult Index()
		{
			var users = db.Users.ToList();

			return View(users);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		[HttpPost]
		public ActionResult Login(string txtUsername, string txtPassword)
		{
			bool flag = false;
			int uid = 0;

			foreach (User user in db.Users)
			{
				if (user.Username == txtUsername && user.Password == txtPassword)
				{
					flag = true;
					uid = user.UserId;
				}
			}
			Session.Add("uid", uid);
			if (flag)
			{
				return RedirectToAction("Index", "Profile");
			}
			return Index();
		}
	}
}