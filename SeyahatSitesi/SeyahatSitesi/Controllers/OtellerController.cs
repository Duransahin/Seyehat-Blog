using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitesi.Models.Sınıflar;

namespace SeyahatSitesi.Controllers
{
    public class OtellerController : Controller
    {
        // GET: Oteller
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexOteller()
        {
            var oteller = c.Otellers.ToList();
            return View(oteller);
        }
     
    }
}