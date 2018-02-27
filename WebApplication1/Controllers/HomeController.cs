using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        
        [HttpPost]
        public ActionResult Connect(BluetoothconnectionModel model)
        {
         
            return View("Index", model);
        }

        public ActionResult Disconnect()
        {
            ViewBag.Title = "Home Page";

            return View("Index");
        }

    }
}
