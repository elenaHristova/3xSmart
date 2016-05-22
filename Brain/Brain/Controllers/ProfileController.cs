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
        // GET: Profile
        public ActionResult Index()
        {
	        ViewBag.Id = Session["uid"];
            return View();
        }
    }
}