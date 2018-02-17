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
                PlaceName = "Shop1",
                GeoLong = "54.972842",
                GeoLat = "-1.428277"
            });
            model.Points.Add(new MapPoint
            {
                Id = 2,
                PlaceName = "Shop2",
                GeoLong = "54.972823",
                GeoLat = "-1.458364"
            });
            model.Points.Add(new MapPoint
            {
                Id = 3,
                PlaceName = "Shop3",
                GeoLong = "54.972949",
                GeoLat = "-1.408400"
            });
            model.MapPointsJSON = Newtonsoft.Json.JsonConvert.SerializeObject(model.Points);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(MapsModel model)
        {
            return RedirectToAction("Index");
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
