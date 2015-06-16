using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dialog()
        {
            return View();
        }

        public ActionResult PrintView()
        {
            if (Request.IsAjaxRequest())
            {
                return View("Dialog");
            }
            else return RedirectToAction("Dialog");
        }
    }
}
