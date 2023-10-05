// Controllers/HomeController.cs
using Crops.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Crops.Controllers
{
    public class HomeController : Controller
    {
        // Using a static list as a cache for demo purposes
        private static List<Crops.Models.CropChange> _changes = new List<Crops.Models.CropChange>();

        public IActionResult Index()
        {
            return View(_changes);
        }

        [HttpPost]
        public IActionResult Submit(Crops.Models.CropChange change)
        {
            change.ModificationDate = DateTime.Now;
            _changes.Add(change);
            return RedirectToAction("Index");
        }
    }
}
