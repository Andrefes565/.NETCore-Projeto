using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace site01.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            /*
            ContentResult resultado = new ContentResult() { Content = "Dale meu pirraia" };
            return resultado;
            */
            //return new ContentResult() { Content = "Olá  Mundo" };

            return View();
        }

        [HttpGet] // apenas para requisição do tipo GET
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] // apenas para requisição do tipo POST
        public ActionResult Login([FromForm] Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                if(usuario.Email == "andrexfes08@gmail.com" && usuario.Senha == "1234")
                {
                    /*
                    //Add Session
                    HttpContext.Session.SetString("Login", "true");
                    HttpContext.Session.SetString();
                    return RedirectToAction("Index", "Palavra");
                    */
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Os dados informados são inválidos";
                    return View();
                }
            } 
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
