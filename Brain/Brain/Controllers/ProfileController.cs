using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Brain.Models;

namespace Brain.Controllers
{
    public class ProfileController : Controller
    {
		BrainContext db=new BrainContext();
        // GET: Profile
        public ActionResult Index()
        {
	        ViewBag.Id = Session["uid"];
            return View();
        }

	    public ActionResult ManageNewUser()
	    {
		    return View();
	    }
		
		[HttpPost]
	    public ActionResult SaveNewUserInfo(string fullName, string age, string gender)
		{
			int ageInt = Convert.ToInt16(age);
			PersonalInfo personalInfo=new PersonalInfo(fullName,ageInt,gender);
			db.PersonalInfo.Add(personalInfo);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
    }
}