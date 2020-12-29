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
    public class ConsejeriaController : Controller
    {
        private readonly ILogger<ConsejeriaController> _logger;
        private readonly ApplicationDbContext _context;

        private List<Requerimiento> listRequerimientos= new List<Requerimiento>();

        private List<Requerimiento> listMostrar= new List<Requerimiento>();

        public ConsejeriaController(ILogger<ConsejeriaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            listRequerimientos=_context.Requerimientos.ToList();
        }

        public IActionResult Index()
        {
            var status=HttpContext.Session.GetString("State");
            if(status!=null){
                var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                var tipo = user.Tipo;
                if(tipo=="C"){
                    return View();
                }else{
                    HttpContext.Session.Clear();
                    return RedirectToAction("Index","Login");
                }

            }else{
                return RedirectToAction("Index","Login");
            }           
        }

        public IActionResult Pendiente()
        {
            HttpContext.Session.SetString("Tipo","PENDIENTE");
            return RedirectToAction("Consejero","Listado");
        }

        public IActionResult Procesado()
        {
            HttpContext.Session.SetString("Tipo","EN PROCESO");
            return RedirectToAction("Consejero","Listado");
        }

        public IActionResult Terminado()
        {
            HttpContext.Session.SetString("Tipo","TERMINADO");
            return RedirectToAction("Consejero","Listado");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
