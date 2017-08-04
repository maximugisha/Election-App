using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectionApp.Controllers
{
    public class ElectionController : Controller
    {
        // GET: Election
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ballotpage()
        {
            ViewBag.Message = "Cast Your Vote Here.";

            return View();
        }
        public ActionResult tallypage()
        {
            ViewBag.Message = "Current Contestant Standings.";

            return View();
        }
    }
}