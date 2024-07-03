using DashBoardAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashBoardAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashBoard()
        {
            /*Equipment.LstEquipment();*/ // from here data also can be sent to view by viewbag;
            return View();
        }

        
    }
}