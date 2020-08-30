using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using kiwiprod_iteration1.Models;
namespace kiwiprod_iteration1.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search

        public ActionResult Analysis()
        {
            searchDBEntities sd = new searchDBEntities();
            ViewBag.age = new SelectList(sd.AgeSet, "Id", "Age");
            ViewBag.education = new SelectList(sd.EducationLevelSet, "Id", "level");
            ViewBag.skill = new SelectList(sd.SkillsSet, "Id", "skillName");
            //ViewBag.education = new SelectList(sd.EducationLevelSet, "Id", "level");
            return View();
        }
        
        [HttpPost]
    
        public ActionResult Result(FormCollection sd)
        {
            ViewBag.result = sd["education"];
          
            return View();

        }
    
    }
}