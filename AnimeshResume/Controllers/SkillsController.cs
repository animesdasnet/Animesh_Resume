using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeshResume.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        public ActionResult Skills()
        {
            ViewBag.React = "React Js";
            ViewBag.Html = "Html";
            ViewBag.Css = "CSS";
            ViewBag.Bootstrap = "Bootstrap";

            ViewBag.Node = "Node Js";
            ViewBag.Express = "Express";
            ViewBag.Net = ".Net";

            ViewBag.SqlServer = "SQLServer";
            ViewBag.MongoDB = "MongoDB";
            return View();
        }
    }
}