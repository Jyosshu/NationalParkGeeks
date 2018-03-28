using Microsoft.AspNetCore.Mvc;
using NationalParkGeeks.Models;
using NationalParkGeeks.DAL;
using System.Collections.Generic;

namespace NationalParkGeeks.Controllers
{
    public class ParkDetailController : Controller
    {
        public IActionResult Index(string ParkCode)
        {
            ParkDAL dal = new ParkDAL();
            WeatherDAL wDal = new WeatherDAL();

            Park SelectedPark = dal.GetParkByParkCode(ParkCode);
            List<Weather> Weather = wDal.GetWeatherByParkCode(ParkCode);
            Dictionary<string, object> model = new Dictionary<string,object>();
            
            ViewBag.one = Weather;
            
            return View(SelectedPark);
        }
    }
}