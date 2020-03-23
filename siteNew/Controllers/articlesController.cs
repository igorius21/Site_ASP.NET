using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using siteNew.Models;

namespace siteNew.Controllers
{
    public class articlesController : Controller
    {
        // GET: articles
        public ActionResult Index()
        {
            return View("random");
        }

        public ActionResult add()
        {
            return View();
        }

        public ActionResult view()
        {
            Articles article = new Articles();
            article.view(1);
            return View(article);
        }

        public ActionResult random()
        {
            Articles article = new Articles();
            article.random();
            return View(article);
        }
    }
}