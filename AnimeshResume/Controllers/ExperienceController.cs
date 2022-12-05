using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeshResume.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Experience()
        {
            ViewBag.React = "React Js";
            ViewBag.Html = "Html";
            ViewBag.Css = "CSS";
            ViewBag.BootStrap = "Bootstrap";

            ViewBag.Node = "Node Js";
            ViewBag.Express = "Express";
            ViewBag.Net = ".Net";

            ViewBag.SqlServer = "SQLServer";
            ViewBag.MongoDB = "BootStrap";
            return View();
        }
    }
}