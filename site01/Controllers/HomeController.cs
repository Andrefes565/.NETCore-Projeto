using Microsoft.AspNetCore.Mvc;
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
    }
}
