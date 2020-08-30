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
        searchDBEntities sd = new searchDBEntities();
        public ActionResult Analysis()
        {
           
            ViewBag.age = new SelectList(sd.AgeSet, "Id", "Age");
            ViewBag.education = new SelectList(sd.EducationLevelSet, "Id", "level");
            ViewBag.skill = new SelectList(sd.SkillsSet, "Id", "skillName");
            //ViewBag.education = new SelectList(sd.EducationLevelSet, "Id", "level");
           
            
           
            return View();
        }
        
        [HttpPost]

        public ViewResult Result(FormCollection Fc)
        {
           
            EducationLevelSet edu = new EducationLevelSet();
            edu.level = Fc["Education"].ToString();

            ViewBag.Msg = edu.level;
            return View();

        }
    
    }
}