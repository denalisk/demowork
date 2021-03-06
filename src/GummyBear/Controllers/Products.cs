﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GummyBearApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummyBearApp.Controllers
{
    public class Products : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GummyBear gummyBear)
        {
            db.GummyBears.Add(gummyBear);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisGummyBear = db.GummyBears.FirstOrDefault(gummyBear => gummyBear.GummyBearId == id);
            return View(thisGummyBear);
        }

        [HttpPost]
        public IActionResult Edit(GummyBear gummyBear)
        {
            db.Entry(gummyBear).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisGummyBear = db.GummyBears.FirstOrDefault(gummyBear => gummyBear.GummyBearId == id);
            return View(thisGummyBear);
        }

        [HttpPost]
        public IActionResult Delete(GummyBear gummyBear)
        {
            db.GummyBear.Remove(gummyBear);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
