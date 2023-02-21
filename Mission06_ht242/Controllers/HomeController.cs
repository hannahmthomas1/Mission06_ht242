using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_ht242.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_ht242.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryContext meContext { get; set; }

        //constructor
        public HomeController( MovieEntryContext someName)
        {
            meContext = someName;
        }

        [HttpGet]
        public IActionResult Collection ()
        {
            //Populate Category Dropdown
            ViewBag.Categories = meContext.categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Collection(movieEntry response)
        {
            // update sqlite database if no error
            if (ModelState.IsValid)
            {
                meContext.Add(response);
                meContext.SaveChanges();
                return View("confirmation", response);
            }
            else
            {
                ViewBag.Categories = meContext.categories.ToList();

                return View();
            }
        }

        public IActionResult Podcast()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult movieList()
        {
            //Filter/sort table
            var movies = meContext.entries
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int entryid)
        {
            //Populate category Dropdown
            ViewBag.Categories = meContext.categories.ToList();

            //Use EntryId to pull info
            var application = meContext.entries.Single(x => x.EntryID == entryid);

            return View("Collection", application);
        }

        [HttpPost]
        public IActionResult Edit (movieEntry ent)
        {
            meContext.Update(ent);
            meContext.SaveChanges();

            return RedirectToAction("movieList");
        }

        [HttpGet]
        public IActionResult Delete(int entryid)
        {
            var entry = meContext.entries.Single(x => x.EntryID == entryid);
            return View();
        }

        [HttpPost]
        public IActionResult Delete(movieEntry ent)
        {
            meContext.entries.Remove(ent);
            meContext.SaveChanges();

            return RedirectToAction("movieList");
        }
    }
}
