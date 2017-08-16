using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectionApp.Models;

namespace ElectionApp.Controllers
{
   
    public class CandidatesController : Controller
    {
        private ApplicationDbContext _dbContext;
        public CandidatesController()
        {
            _dbContext = new ApplicationDbContext();
        }
      
     
        // GET: Candidates
        public ActionResult Index()
        {
            var candidates = _dbContext.Candidates.ToArray();
            return View(candidates);
        }
        public ActionResult Vote()
        {
            return View();
        }
    }
}