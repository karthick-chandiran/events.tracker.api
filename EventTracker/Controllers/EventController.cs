using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventTracker.Data;
using EventTracker.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventTracker.Controllers
{
    [ApiController]
    [EnableCors("allowedOrigin")]
    [Route("[controller]")]
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EventController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var events = _db.Events;
            return Json(events);
        }

        [HttpPost]
        public IActionResult Create(EventModel obj)
        {
            if (ModelState.IsValid)
            {

            _db.Events.Add(obj);
            _db.SaveChanges();
            }
            return Json(_db.Events);
        }

        [HttpPut]
        public IActionResult Update(EventModel obj)
        {
            if (ModelState.IsValid)
            {

                _db.Events.Update(obj);
                _db.SaveChanges();
            }
            return Json(_db.Events);
        }


    }
}

