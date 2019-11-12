using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UygulamaDeneme.Controllers
{
    public class OyunController : Controller
    {
        // GET: Oyun
        public ActionResult Oyun(string x,string y,string top)
        {
            ViewBag.x = Convert.ToInt32(x);
            ViewBag.y = Convert.ToInt32(y);
            ViewBag.top = Convert.ToInt32(top);
            return View();
        }
        [HttpPost]
        public JsonResult JOyun(string xeksen, string yeksen)
        {

            int[] data= new int[] {Convert.ToInt32(xeksen), Convert.ToInt32(yeksen) };


            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}