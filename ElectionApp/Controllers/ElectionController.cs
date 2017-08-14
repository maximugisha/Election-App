using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;
using ElectionApp.Models;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Web.UI;



namespace ElectionApp.Controllers
{
    public class ElectionController : Controller
    {
        private ApplicationDbContext _dbContext;
        public ElectionController()
        {
            _dbContext = new ApplicationDbContext();
        }


        // GET: Election

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ballotpage()
        {
            ViewBag.Message = "Cast Your Vote Here.";
            var candidates = _dbContext.Candidates.ToArray();
            return View(candidates);
        }
            public class RadioButton : CheckBox, IPostBackDataHandler{
                RadioButton();
            }
            
        public ActionResult tallypage()
        {
            ViewBag.Message = "Current Contestant Standings.";
            var candidates = _dbContext.Candidates.ToArray();
            return View(candidates);
        }
    }
}
        
