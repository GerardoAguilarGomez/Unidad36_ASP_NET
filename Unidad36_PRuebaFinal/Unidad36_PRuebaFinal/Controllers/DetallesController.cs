﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Unidad36_PRuebaFinal.Models;

namespace Unidad36_PRuebaFinal.Controllers
{
    public class DetallesController : Controller
    {
        public IActionResult Detalles()
        {
            return View();
        }
    }
}
