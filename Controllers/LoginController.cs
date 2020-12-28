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
            var userLogged= new Usuario();
            var listUsuarios=_context.Usuarios.ToList();
            for(int i=0; i<listUsuarios.Count; i++){
                Usuario user = listUsuarios[i];
                if(user.Correo==usuario.Correo && user.Password==usuario.Password){
                    userLogged=user;
                    HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userLogged));
                    HttpContext.Session.SetString("State","logged");
                    
                    if(user.Tipo=="E"){
                        return RedirectToAction("Index", "Estudiante", new { area = "" });
                    }else{

                        return RedirectToAction("Index", "Consejeria", new { area = "" });
                    }
                }
            }
            return RedirectToAction("Index");
            
        }


        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Redir(){
            var status=HttpContext.Session.GetString("State");
            if(status!=null){
                var user = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("SessionUser"));
                var tipo = user.Tipo;
                if(tipo=="C"){
                    return RedirectToAction("Index","Consejeria");
                }else{
                    return RedirectToAction("Index","Estudiante");
                }
            }else{
                return RedirectToAction("Index");
            }
        }

        public IActionResult Registro(){
            return View();
        }

        public IActionResult Registrar(Usuario usuario){

            usuario.Tipo="E";
            if(ModelState.IsValid){
                _context.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }else{
                return RedirectToAction("Registro");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
