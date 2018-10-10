using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClearSkyLogicTechnicalAssessment.Models;
using ClearSkyLogicTechnicalAssessment.Database;

namespace ClearSkyLogicTechnicalAssessment.Controllers
{
    public class HomeController : Controller
    {
        public SubscriberDbContext _context { get; }

        public HomeController(SubscriberDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody]Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                bool exists = _context.Subscribers.Any(s => s.Email == subscriber.Email);
                if (exists)
                {
                    var error = new Error { ErrorMessage = "Email Already Subscribed!"};
                    return Json(error);
                }

                _context.Add(subscriber);
                _context.SaveChanges();
                return Json(subscriber);
                
            }

            return BadRequest(subscriber);
        }


    }
}
