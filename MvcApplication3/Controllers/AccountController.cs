using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using MvcApplication3.Filters;
using MvcApplication3.Models;

namespace MvcApplication3.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class AccountController : Controller
    {

        BdData _data = new BdData();
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(string log, string pass)
        {
            if (_data.Validate(log, pass) == true)
            {
                FormsAuthentication.SetAuthCookie(log, true);
            }
            return RedirectToAction("Profile", "Home");
        }


        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public ActionResult registered (string email, string name, string surname,  string phone, string password)
        {
            _data.registered(email, name, surname, phone, password);

            if (_data.Validate(email, password) == true)
            {
                FormsAuthentication.SetAuthCookie(email, true);
            }

            return RedirectToAction("Next", "Home");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/LogOff

        //[ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            WebSecurity.Logout();

            return RedirectToAction("MainPage", "Home");
        }


    }
}
