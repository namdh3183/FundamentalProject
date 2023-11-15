using FundamentalProject.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FundamentalProject.Controllers
{
    public class BookingController : Controller
    {
        Model1 db = new Model1();
        // GET: Booking
        public ActionResult Index()
        {
            var userLogin = (CUSTOMER)Session["USERNAME"];
            List<object> model = new List<object>();
            if (userLogin == null)
            {
                return Redirect("~/User/Login");
            }
            else
            {
                var lstBHotel = db.BOOKINGHOTELs.Where(d => d.IDCUSTOMER == userLogin.ID).ToList();
                var lstBFlight = db.BOOKINGFLIGHTs.Where(d => d.IDCUSTOMER == userLogin.ID).ToList();
                var lstBPackage = db.BOOKINGPACKAGEs.Where(d => d.IDCUSTOMER == userLogin.ID).ToList();
                
                model.Add(lstBHotel); 
                model.Add(lstBFlight); 
                model.Add(lstBPackage);
            }
            return View(model);
        }
    }
}