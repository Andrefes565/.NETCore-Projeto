using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using site01.Library;
using site01.Models;

namespace site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Contato = new Contato();
            return View();
        }

        //Obter Dados Automaticamente
        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if(ModelState.IsValid)
            {

                //string conteudo = string.Format("Nome:{0}, Email:{1}, Assunto:{2}, Menssagem:{3}", contato.Nome, contato.Email, contato.Assunto, contato.Menssagem);

                //return new ContentResult() { Content = conteudo };
                ViewBag.Contato = new Contato();
                EnviarEmail.EnviarMessagemContato(contato);
                ViewBag.Mensagem = "Mensagem enviada com sucesso!";
                return View("Index");
            }
            else
            {
                ViewBag.Contato = contato;
                return View("Index");
            }
            
        }

        /* Obter Dados Manualmente
        public IActionResult ReceberContato()
        {
            //Post - Request.Form
            //Get - Request.QueryString
            Contato contato = new Contato();
            contato.Nome = Request.Form["nome"];
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Menssagem = Request.Form["menssagem"];

            string conteudo = string.Format("Nome:{0}, Email:{1}, Assunto:{2}, Menssagem:{3}", contato.Nome, contato.Email, contato.Assunto, contato.Menssagem);

            return new ContentResult() {Content = conteudo };
        }
        */
    }
}