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
        public ActionResult ErrorActionResult;
        public Articles article;

        public articlesController()
        {
            article = new Articles();
        }
        // GET: articles
        public ActionResult Index()
        {
            if (IsError()) return ErrorActionResult;
            return View("view", article);
        }

        public ActionResult add()
        {
            if (IsError()) return ErrorActionResult;
            return View();
        }

        public ActionResult view()
        {
            string id = (RouteData.Values["id"] ?? "").ToString();
            if (id == "")
                return Redirect("/page");
            article.Number(id);
            if (IsError()) return ErrorActionResult;
            return View(article);
        }

        public ActionResult random()
        {
            article.Random();
            if (IsError()) return ErrorActionResult;
            return View("view", article);
        }

        public bool IsError()
        {
            if (Database.IsError())
            {
                ViewBag.error = Database.error;
                ViewBag.query = Database.query;
                ErrorActionResult = View("~/Views/Error.cshtml");
                return true;
            }
            if (article.IsError())
            {
                ViewBag.error = "Article not found";
                ViewBag.query = Database.query;
                ErrorActionResult = View("~/Views/Error.cshtml");
                return true;
            }
            return false;
        }

    }
}