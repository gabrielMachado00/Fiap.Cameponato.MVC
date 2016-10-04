using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.Contexts;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public class TimeRepository : ITimeRepository
    {
        private CampeonatoContext _context;

        public TimeRepository(CampeonatoContext context)
        {
            this._context = context;
        }

        public void Cadastrar(Time time)
        {
            _context.Times.Add(time);
        }

        public List<Time> Listar()
        {
            return _context.Times.ToList();
        }
    }
}