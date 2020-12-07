using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsejeriaEPICS.Models;

namespace ConsejeriaEPICS.Controllers
{
    public class AgregarRequerimientoController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public AgregarRequerimientoController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
