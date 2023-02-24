using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitesi.Models.Sınıflar;
using SeyahatSitesi.Controllers;

namespace SeyahatSitesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Hakkımızda.ToList();
            return View(degerler);
        }
    }
}