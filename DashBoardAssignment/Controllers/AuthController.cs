using DashBoardAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashBoardAssignment.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            //var outMessage = "";
            return View();
        }
        [HttpPost]
        public ActionResult Login(Account model)
        {
            if (model.UserName == "aziz" && model.Password == "123")
            {
                Session["User"] = model.UserName;
                ViewBag.Message = "Login successful";

                //return RedirectToAction("Dashboard", "Home");
            }
                
            else
            {
                ViewBag.Message = "Login Failed";

            }
                
            return View();
        }
    }
}