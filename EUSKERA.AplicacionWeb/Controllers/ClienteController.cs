﻿using Microsoft.AspNetCore.Mvc;

namespace EUSKERA.AplicacionWeb.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
