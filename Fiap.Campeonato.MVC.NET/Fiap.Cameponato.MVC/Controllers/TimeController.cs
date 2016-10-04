using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Apostila08.MVC.Web.Controllers
{
    public class TimeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            _unit.TimeRepository.Cadastrar(time);
            _unit.Save();
            TempData["msg"] = "Time Cadastrado!";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose(); //Fecha a conexão com o banco
            base.Dispose(disposing);
        }

    }
}