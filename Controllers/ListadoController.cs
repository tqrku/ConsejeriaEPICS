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
using System.Dynamic;
using Microsoft.AspNetCore.Http;

namespace ConsejeriaEPICS.Controllers
{
    public class ListadoController : Controller
    {
        private readonly ILogger<ListadoController> _logger;
        private readonly ApplicationDbContext _context;

        private List<Requerimiento> listRequerimientos= new List<Requerimiento>();

        private List<Requerimiento> listMostrar= new List<Requerimiento>();

        public ListadoController(ILogger<ListadoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            listRequerimientos=_context.Requerimientos.ToList();
        }

        public IActionResult Consejero()
        {
            var status=HttpContext.Session.GetString("State"); 
            if(status!=null){
                var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                var tipo = user.Tipo;
                if(tipo=="D"){
                    switch(HttpContext.Session.GetString("Tipo")){
                        case "PENDIENTE": Pendiente();
                                            break;
                        case "EN PROCESO": Procesado();
                                            break;
                        case "TERMINADO": Terminado();
                                            break;
                    }
                    return View();
                }else{
                    HttpContext.Session.Clear();
                    return RedirectToAction("Index","Login");
                }
            }else{
                return RedirectToAction("Index","Login");
            }    
        }

        public IActionResult Estudiante()
        {
            var status=HttpContext.Session.GetString("State");
            if(status!=null){
                var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                var tipo = user.Tipo;
                if(tipo=="E"){
                    dynamic modelo= new ExpandoObject();
                    foreach(Requerimiento req in listRequerimientos){
                        if(req.User_ID==user.ID){
                            listMostrar.Add(req);
                        }
                    }
                    modelo.Mostrar=listMostrar;
                    return View("Estudiante",modelo);
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
            foreach(Requerimiento req in listRequerimientos){
                if(req.Estado=="PENDIENTE"){
                    listMostrar.Add(req);
                }
            }
            dynamic modelo= new ExpandoObject();
            modelo.Titulo="Requerimientos Pendientes";
            modelo.Desc="Visualiza todos los requerimientos que aun no han sido atendidos";
            modelo.Mostrar=listMostrar;
            return View("Consejero",modelo);
        }

        public IActionResult Procesado()
        {
            foreach(Requerimiento req in listRequerimientos){
                if(req.Estado=="EN PROCESO"){
                    listMostrar.Add(req);
                }
            }
            dynamic modelo= new ExpandoObject();
            modelo.Titulo="Requerimientos En Proceso";
            modelo.Desc="Visualiza todos los requerimientos que estan siendo atendidos";
            modelo.Mostrar=listMostrar;
            return View("Consejero",modelo);
        }

        public IActionResult Terminado()
        {
            foreach(Requerimiento req in listRequerimientos){
                if(req.Estado=="TERMINADO"){
                    listMostrar.Add(req);
                }
            }
            dynamic modelo= new ExpandoObject();
            modelo.Titulo="Requerimientos Terminados";
            modelo.Desc="Visualiza todos los requerimientos que ya han sido atendidos";
            modelo.Mostrar=listMostrar;
            return View("Consejero",modelo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
