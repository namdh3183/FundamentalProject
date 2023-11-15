using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using FundamentalProject.Models;
using PagedList;
using PagedList.Mvc;

namespace FundamentalProject.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PackagePage(int? page)
        {
            var lstPackage = db.PACKAGEs.OrderBy(s => s.ID);
            int pageNumber = (page) ?? 1;
            int pageSize = 6;
            return View(lstPackage.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult FlightPage(int ? page)
        {
            var lstFlight = db.FLIGHTs.OrderBy(s => s.ID);
            int pageNumber = (page) ?? 1;
            int pageSize = 5;
            return View(lstFlight.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult HotelPage(int ? page)
        {
            var lstHotel = db.HOTELs.OrderBy(s => s.ID);
            int pageNumber = (page) ?? 1;
            int pageSize = 5;
            return View(lstHotel.ToPagedList(pageNumber, pageSize));
        }

        //********************** Partial View **********************

        //----- NavBar -----
        public ActionResult NavBarPartial() 
        {
            return PartialView();
        }
        public ActionResult NavBarItemPartial()
        {
            return PartialView();
        }

        //----- Index Partial View -----
        public ActionResult TrendLocaPartial()
        {
            return PartialView();
        }
        public ActionResult NewLocaPartial()
        {
            return PartialView();
        }
        public ActionResult TopHotelPartial()
        {
            return PartialView();
        }
        public ActionResult InforHotelPartial()
        {
            return PartialView();
        }

        //----- Footer ----- 
        public ActionResult Footer()
        {
            return PartialView();
        }
    }
}