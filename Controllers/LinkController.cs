using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using coouncil.Models;
using Coun.Data;
using Microsoft.AspNetCore.Mvc;

namespace Coun.Controllers {
    public class LinkController : Controller {
        private readonly DataContext _db;
        public LinkController (DataContext _db) {
            this._db = _db;
        }

        public IActionResult Info (string id) {
            ViewBag.Info = _db.LinkModels.Where (x => x.Catogary == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult History () {
            ViewBag.history = _db.ImportantLocationModels.ToArray ();
            return View (ViewBag);
        }

      

        [HttpGet]
        public IActionResult HistoryInfo (int id) {
            ViewBag.history = _db.ImportantLocationModels.Where (x => x.Id == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult HistoryEng (int id) {
            ViewBag.history = _db.ImportantLocationModels.Where (x => x.Id == id).ToArray ();
            return View (ViewBag);
        }
        [HttpGet]
        public IActionResult GuestHouse () {
            ViewBag.GH = _db.GuestHousesModels.OrderByDescending (x => x.Id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult GuestHouseInfo (int id) {
            ViewBag.GuestInfo = _db.GuestHousesModels.Where (x => x.Id == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult GuestHouseEngInfo (int id) {
            ViewBag.GuestInfo = _db.GuestHousesModels.Where (x => x.Id == id).ToArray ();
            return View (ViewBag);
        }

        [HttpGet]
        public IActionResult Bussiness () {
            ViewBag.bussines = _db.LinkModels.Where (x => x.Catogary == "bussiness").ToArray ();
            return View (ViewBag);
        }
        [HttpGet]
        public IActionResult FerryService(){
            return View();
        }

    }
}