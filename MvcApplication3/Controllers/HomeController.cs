using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        //BdData _data = new BdData();

        public ActionResult Index()
        {
            ViewBag.ActiveMenu = "Index";
            return View();
        }



        public ActionResult Hiatory()
        {
            ViewBag.ActiveMenu = "Hiatory";
            return View();
        }


        public ActionResult Profile()
        {
            ViewBag.ActiveMenu = "Profile";
            return View();
        }


        public ActionResult Support()
        {
            ViewBag.ActiveMenu = "Support";
            return View();
        }



        public ActionResult Accounts()
        {
            ViewBag.ActiveMenu = "Accounts";
            return View();
        }

        public ActionResult CategoryCosts()
        {
            ViewBag.ActiveMenu = "CategoryCosts";
            return View();
        }

        public ActionResult ReportCosts()
        {
            ViewBag.ActiveMenu = "ReportCosts";
            return View();
        }

        public ActionResult ReportIncome()
        {
            ViewBag.ActiveMenu = "ReportIncome";
            return View();
        }

        public ActionResult ReportIncomeCosts()
        {
            ViewBag.ActiveMenu = "ReportIncomeCosts";
            return View();
        }

        public ActionResult Targets()
        {
            ViewBag.ActiveMenu = "Targets";
            return View();
        }

        public ActionResult Calendar()
        {
            ViewBag.ActiveMenu = "Calendar";
            return View();
        }

        public ActionResult ReportAllTransaction()
        {
            ViewBag.ActiveMenu = "ReportAllTransaction";
            return View();
        }

        public ActionResult Budget()
        {
            ViewBag.ActiveMenu = "Budget";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

