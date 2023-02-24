using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitesi.Models.Sınıflar;
namespace SeyahatSitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Blogyorum by = new Blogyorum();
        Context c = new Context();
        public ActionResult Index()
        {
            by.Değer1 = c.Blogs.ToList();
            by.Değer3 = c.Blogs.OrderBy(x=>x.ID).Take(5).ToList();
            return View(by);
        }
       
        public ActionResult BlogDetay(int id)
        {
            //var Blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Değer1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Değer2 = c.Yorumlars.Where(x=>x.Blogid == id).ToList();
                return View(by);

        }
        
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger=id;
            return PartialView();
        }
        [HttpPost]
       public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}