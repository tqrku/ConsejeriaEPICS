using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsejeriaEPICS.Models;
using ConsejeriaEPICS.Data;

namespace ConsejeriaEPICS.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ApplicationDbContext _context;

        public LoginController(ILogger<LoginController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logueo(Usuario usuario)
        {
            var listUsuarios=_context.Usuarios.ToList();
            
            for(int i=0; i<listUsuarios.Count; i++){
                Usuario user = listUsuarios[i];
                if(user.Correo==usuario.Correo && user.Password==usuario.Password){
                    if(user.Tipo=="E"){
                        return RedirectToAction("Index", "EstudianteController", new { area = "" });
                    }else{
                        return RedirectToAction("Index", "ConsejeriaController", new { area = "" });
                    }
                }
            }

            return View("Index");
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
