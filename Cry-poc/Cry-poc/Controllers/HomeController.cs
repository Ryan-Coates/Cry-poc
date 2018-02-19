using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cry_poc.Models;
using Crypoc;
using Crypoc.Models;

namespace Crypoc.Controllers
{
    public class HomeController : Controller
    {
        MockDataService mockDataService = new MockDataService();
        public IActionResult Index()
        {
            var model = mockDataService.GetStoreModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(StoreModel model)
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
