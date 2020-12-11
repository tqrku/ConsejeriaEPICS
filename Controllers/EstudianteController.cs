using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsejeriaEPICS.Models;
using ConsejeriaEPICS.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace ConsejeriaEPICS.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly ILogger<EstudianteController> _logger;
        private readonly ApplicationDbContext _context;

        public EstudianteController(ILogger<EstudianteController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var status=HttpContext.Session.GetString("State");          
            if(status!=null){
                var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                var tipo = user.Tipo;
                if(tipo=="E"){
                    return View();
                }else{
                    HttpContext.Session.Clear();
                    return RedirectToAction("Index","Login");
                }

            }else{
                return RedirectToAction("Index","Login");
            }    
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
