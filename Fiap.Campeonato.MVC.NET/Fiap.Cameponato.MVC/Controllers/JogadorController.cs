using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class JogadorController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Listar()
        {
            //Recuperar os jogadores cadastrados
            var lista = _unit.JogadorRepository.List();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Valores para o select
            var lista = _unit.TimeRepository.Listar();
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _unit.JogadorRepository.Insert(jogador);
            _unit.Save();
            TempData["msg"] = "Jogador Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}