using PdfJSViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PdfJSViewer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new DocumentViewModel()
            {
                DocumentId = new Random().Next(1, 100),
                DocumentUrl = "Resources/Oculus-Quest-Tutorial-ENG.pdf"
            });
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