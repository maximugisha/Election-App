using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ElectionApp.Controllers
{
    public class ElectionController : Controller
    {
        // GET: Election
        MySqlConnection connection = new MySqlConnection("server=localhost; user = Maximo; database = election_db; port = 3306; password = 'UPbeat123'; ");
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ballotpage()
        {
            ViewBag.Message = "Cast Your Vote Here.";
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `candidates`", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("candidates");
            da.Fill(dt);
            //dbtable.ItemsSource = dt.DefaultView;

            connection.Close();
            
            return View();
        }
        public ActionResult tallypage()
        {
            ViewBag.Message = "Current Contestant Standings.";

            return View();
        }
    }
}