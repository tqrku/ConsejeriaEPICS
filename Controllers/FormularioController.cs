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
using System.Dynamic;

namespace ConsejeriaEPICS.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;
        private readonly ApplicationDbContext _context;

        public FormularioController(ILogger<FormularioController> logger, ApplicationDbContext context)
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
                    dynamic modelo = new ExpandoObject();
                    modelo.Categorias = _context.Categorias.ToList();
                    modelo.Requerimiento = new Requerimiento();
                    return View(modelo);
                }else{
                    HttpContext.Session.Clear();
                    return RedirectToAction("Index","Login");
                }

            }else{
                return RedirectToAction("Index","Login");
            }   
        }

        public IActionResult Envio(Requerimiento req){
            var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
            req.User_ID = user.ID;
            req.Estado = "PENDIENTE";
            req.Fecha_Inicio = DateTime.Today;
            if(ModelState.IsValid){
                _context.Requerimientos.Add(req);
                _context.SaveChanges();
                return RedirectToAction("Estudiante","Listado");

            }else{
                return View("Index");
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
