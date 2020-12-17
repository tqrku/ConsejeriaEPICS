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
    public class FormularioRegistroController : Controller
    {
        private readonly ILogger<FormularioRegistroController> _logger;

        public FormularioRegistroController(ILogger<FormularioRegistroController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
