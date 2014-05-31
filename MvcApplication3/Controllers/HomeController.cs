using MvcApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{

    public class HomeController : Controller
    {
        BdData _data = new BdData();

        [Authorize]
        public ActionResult Index()
        {
            ViewBag.ActiveMenu = "Index";
            return View();
        }


        [Authorize]
        public ActionResult History()
        {
            List<Transaction> Transaction = _data.GetUserTransaction(1);
            ViewBag.Transaction = Transaction;
            ViewBag.ActiveMenu = "History";
            return View();
        }

        [Authorize]
        public ActionResult Goods()
        {
            List<Good> Goods = _data.GetAllGood(1);
            ViewBag.AllGood = Goods;
            ViewBag.ActiveMenu = "Goods";
            return View();
        }

        [Authorize]
        public ActionResult Profile()
        {
            ViewBag.ActiveMenu = "Profile";
            return View();
        }

        [Authorize]
        public ActionResult Support()
        {
            ViewBag.ActiveMenu = "Support";
            return View();
        }

       
        public ActionResult MainPage()
        {
            ViewBag.ActiveMenu = "Support";
            return View();
        }

        [Authorize]
        public ActionResult Next()
        {
            ViewBag.ActiveMenu = "Next";
            return View();
        }

        //public ActionResult Accounts()
        //{
        //    ViewBag.ActiveMenu = "Accounts";
        //    return View();
        //}

        //public ActionResult CategoryCosts()
        //{
        //    ViewBag.ActiveMenu = "CategoryCosts";
        //    return View();
        //}

        //public ActionResult ReportCosts()
        //{
        //    ViewBag.ActiveMenu = "ReportCosts";
        //    return View();
        //}

        //public ActionResult ReportIncome()
        //{
        //    ViewBag.ActiveMenu = "ReportIncome";
        //    return View();
        //}

        //public ActionResult ReportIncomeCosts()
        //{
        //    ViewBag.ActiveMenu = "ReportIncomeCosts";
        //    return View();
        //}

        //public ActionResult Targets()
        //{
        //    ViewBag.ActiveMenu = "Targets";
        //    return View();
        //}

        //public ActionResult Calendar()
        //{
        //    ViewBag.ActiveMenu = "Calendar";
        //    return View();
        //}

        //public ActionResult ReportAllTransaction()
        //{
        //    ViewBag.ActiveMenu = "ReportAllTransaction";
        //    return View();
        //}

        //public ActionResult Budget()
        //{
        //    ViewBag.ActiveMenu = "Budget";
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}

