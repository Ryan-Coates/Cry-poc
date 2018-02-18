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
                PlaceName = "Chinese palace",
                GeoLong = "54.972842",
                GeoLat = "-1.428277",
                Distance = "12 km",
                Offer = "Promo: 20% off",
                Rating = "4.5/5"
                
            });
            model.Points.Add(new MapPoint
            {
                Id = 2,
                PlaceName = "King kebab",
                GeoLong = "54.972823",
                GeoLat = "-1.458364",
                Distance = "1 km",
                Offer = "None",
                Rating = "4.1/5"
            });
            model.Points.Add(new MapPoint
            {
                Id = 3,
                PlaceName = "Pizza Pizza!",
                GeoLong = "54.972949",
                GeoLat = "-1.408400",
                Distance = "2 km",
                Offer = "Promo: Buy one get one free",
                Rating = "3.5/5"
            });
            model.MapPointsJSON = Newtonsoft.Json.JsonConvert.SerializeObject(model.Points);

            model.Promotions = new List<Promotion>();
            model.Promotions.Add(new Promotion
            {
                Id = 1,
                PlaceName = "Better Cafe",
                Description = "20% off all orders over £20 when paying with NANO"
            });
            model.Promotions.Add(new Promotion
            {
                Id = 2,
                PlaceName = "OK Cafe",
                Description = "Free coffee with NANO order over £5"

            });
            model.Promotions.Add(new Promotion
            {
                Id = 3,
                PlaceName = "Good Cafe",
                Description = "15% off if you pay voa Bitcoin & NANO!"
            });
            model.Promotions.Add(new Promotion
            {
                Id = 3,
                PlaceName = "Small Cafe",
                Description = "2 for 1 on all orders via bitcoin"
            });

            model.Recomendations = new List<Recomendation>();
            model.Recomendations.Add(new Recomendation
            {
                Id = 1,
                PlaceName = "Better Cafe",
                Description = "Received five recomendations today"

            });
            model.Recomendations.Add(new Recomendation
            {
                Id = 2,
                PlaceName = "OK Cafe",
                Description = "Your friend Andrew recommends OK Cafe's Bacon Sandwich"

            });
            model.Recomendations.Add(new Recomendation
            {
                Id = 3,
                PlaceName = "Fancy Cafe",
                Description = "Tried and toasted! Get 5% off on us!"

            });
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
