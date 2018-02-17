using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cry_poc.Models;

namespace Cry_poc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MapsModel model = new MapsModel();
            model.Points = new List<MapPoint>();
            model.Points.Add(new MapPoint
            {
                Id = 1,
                PlaceName = "Zaghouan",
                GeoLong = "36.401081",
                GeoLat = "10.16596"
            });
            model.MapPointsJSON = Newtonsoft.Json.JsonConvert.SerializeObject(model.Points);
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
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
