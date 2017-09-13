using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyMVC.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            var processes = System.Diagnostics.Process.GetProcesses();
            ViewBag.CurrentProcesses = processes;
            return View();
        }

        // GET: Process
        public ActionResult Concrete()
        {
            var processes = System.Diagnostics.Process.GetProcesses();
            return View(processes);
        }

        public ActionResult Details(int id)
        {
            var process = System.Diagnostics.Process.GetProcessById(id);
            return View(process);
        }
    }
}