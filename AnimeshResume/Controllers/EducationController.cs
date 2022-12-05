using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeshResume.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Education()
        {
            ViewBag.SchoolName = "School: Kendriya Vidyalaya Command Hospital";
            ViewBag.Degree = "Degree: Secondary";
            ViewBag.Percentage = "Percentage: 84%";

            ViewBag.SeniorSchoolName = "School: Delhi Public School";
            ViewBag.SeniorSchoolDegree = "Degree: Senior Secondary";
            ViewBag.SeniorSchoolPercentage = "Percentage: 73%";

            ViewBag.CollegeName = "College: Techno India";
            ViewBag.CollegeDegree = "Degree: BTECH";
            ViewBag.CollegeStream = "Stream: Computer Science & Engineering";
            ViewBag.CollegePercentage = "Percentage: 85%";
            return View();
        }
    }
}