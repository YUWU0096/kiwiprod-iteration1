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
        webModel sd = new webModel();
        public ActionResult Analysis()
        {
           
            //ViewBag.age = new SelectList(sd.AgeSet, "Id", "Age");
            ViewBag.education = new SelectList(sd.EducationLevelSets, "Id", "level");
            ViewBag.skill = new SelectList(sd.degreeEmployments, "Id", "skillName");
            //ViewBag.education = new SelectList(sd.EducationLevelSet, "Id", "level");
           
            
           
            return View();
        }
        
        [HttpPost]

        public ViewResult Result(FormCollection Fc)
        {
            int y;
            if (int.TryParse(Fc["Education"],out y))
            {
                y = int.Parse(Fc["Education"]);
                foreach (var x in sd.EducationLevelSets)
                {
                    if (x.Id == y)
                    {
                        ViewBag.Msg = x.level;
                    }
                }
                foreach (var degree in sd.degreeEmployments)
                {
                    if (degree.Degree == ViewBag.Msg)
                    {

                        ViewBag.rate = degree.Employment_Rate.ToString("#.#");
                    }
                }
            }
            else {
                ViewBag.mention = "You need to select one level ";
                ViewBag.rate = 0;
            }
          
           
            return View();
        }
    
    }
}