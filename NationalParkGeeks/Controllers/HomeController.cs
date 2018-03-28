using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationalParkGeeks.Models;
using NationalParkGeeks.DAL;

namespace NationalParkGeeks.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ParkDAL dal = new ParkDAL();
            List<Park> model = dal.GetParks();

            return View(model);
        }

        public IActionResult Survey()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult TopParks()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
