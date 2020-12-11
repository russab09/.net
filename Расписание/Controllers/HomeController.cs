using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var weeks = new Week();
            weeks[0] = new WeekDay();
            weeks[0].Name = "Monday";
            weeks[0].Lessons = new Lesson[] { new Lesson { hour = 11, minute = 40, lesson = "дискретная математика" },
                                              new Lesson { hour = 9, minute = 40, lesson = "мат. анализ"} };
            Array.Sort(weeks[0].Lessons);
            weeks[1] = new WeekDay();
            weeks[1].Name = "Thuesday";
            weeks[1].Lessons = new Lesson[] { new Lesson { hour = 13, minute = 20, lesson = "мат. анализ" },
                                              new Lesson { hour = 9, minute = 40, lesson = "физкультура"} };
            Array.Sort(weeks[1].Lessons);
            return View(weeks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}