﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GedHelpDesk.Models;

namespace GedHelpDesk.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login ()
        {
            return View();
        }

        public IActionResult Verificar (Login log)
        {
            return View(); 
        }
    }
}