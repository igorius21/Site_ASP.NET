using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using siteNew.Models;

namespace siteNew.Controllers
{
    public class aboutController : Controller
    {
        // GET: about
        public ActionResult Index()
        {
            Articles article = new Articles();
            article.About();
            return View(article);
        }
    }
}