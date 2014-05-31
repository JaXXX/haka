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
            return RedirectToAction("History", "Home");
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
