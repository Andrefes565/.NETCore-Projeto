using Microsoft.AspNetCore.Mvc;
using site01.Database;
using site01.Library.Filters;
using site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace site01.Controllers
{
    [Login]
    public class PalavraController:Controller
    {
        List<Nivel> niveis = new List<Nivel>();
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
            
            niveis.Add(new Nivel() { Id = 1, Nome = "Facil" });
            niveis.Add(new Nivel() { Id = 2, Nome = "Médio" });
            niveis.Add(new Nivel() { Id = 3, Nome = "Difícil" });
        }

        //Listar todas as palvras do banco de dados
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var palavras = _db.Palavras.ToList();
            var resultadopaginado = palavras.ToPagedList(pageNumber, 5);

            return View(resultadopaginado);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Nivel = niveis;
            return View(new Palavra());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            List<Nivel> niveis = new List<Nivel>();
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();
                TempData["Mensagem"] = "A palavra ' " + palavra.Nome + "' foi cadastrada com sucesso! ";
                return RedirectToAction("Index");
            }
            return View(palavra);
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            List<Nivel> niveis = new List<Nivel>();
            Palavra palavra = _db.Palavras.Find(Id);
            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            List<Nivel> niveis = new List<Nivel>();
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();
                TempData["Mensagem"] = "A palavra ' " + palavra.Nome + "' foi atualizada com sucesso! ";
                return RedirectToAction("Index");
            }

            return View("Cadastrar", palavra);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();
            TempData["Mensagem"] = "A palavra ' " + palavra.Nome + "' foi excluída com sucesso! ";
            return RedirectToAction("Index");
            
        }

    }
}
