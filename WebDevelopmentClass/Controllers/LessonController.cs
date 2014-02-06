using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDevelopmentClass.Controllers
{
    public class LessonController : Controller
    {
        //
        // GET: /Lesson/1
        public ActionResult Index(int id)
        {
            return View("Lesson" + id);
        }

        public ActionResult MinMaxDemo()
        {
            return View();
        }

        public ActionResult CenteredContentDemo()
        {
            return View();
        }
	}
}