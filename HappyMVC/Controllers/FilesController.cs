using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyMVC.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            var names = Directory
                .EnumerateFiles(Server.MapPath("~/App_Data/TextFiles"), "*", SearchOption.AllDirectories)
                .Select(Path.GetFileNameWithoutExtension);
            return View(names);
        }

        public ActionResult Contents(String id)
        {
            String txt = System.IO.File.ReadAllText(Server.MapPath($"~/App_Data/TextFiles/{id}.txt"));
            ViewBag.Contents = txt;
            return View();
        }
    }
}