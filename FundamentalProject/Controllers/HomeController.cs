using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FundamentalProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ItemPage()
        {
            return View();
        }
        public ActionResult FlightPage()
        {
            return View();
        }
        public ActionResult HotelPage()
        {

            return View();
        }
    }
}