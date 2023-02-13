﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;

        private MovieEntryContext _firstContext { get; set; }

        //constructor
        public HomeController(ILogger<HomeController> logger, MovieEntryContext someName)
        {
            _logger = logger;
            _firstContext = someName;
        }

        [HttpGet]
        public IActionResult Collection ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Collection(movieEntry response)
        {
            _firstContext.Add(response);
            _firstContext.SaveChanges();
            return View("confirmation", response);
        }

        public IActionResult Podcast()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
