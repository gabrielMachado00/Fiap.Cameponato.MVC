using Fiap.Apostila08.MVC.Web.Contexts;
using Fiap.Apostila08.MVC.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.UnitsOfWork
{
    public class UnitOfWork : IDisposable
    {
        //Objeto Context
        private CampeonatoContext _db = new CampeonatoContext();

        //Repositories: propfull -> tab tab
        private ITimeRepository _timeRepository;

        public ITimeRepository TimeRepository
        {
            get
            {
                if (_timeRepository == null)
                {
                    _timeRepository = new TimeRepository(_db);
                }
                return _timeRepository;
            }
        }

        private IJogadorRepository _jogadorRepository;

        public IJogadorRepository JogadorRepository
        {
            get
            {
                if (_jogadorRepository == null)
                {
                    _jogadorRepository = new JogadorRepository(_db);
                }
                return _jogadorRepository;
            }
        }

        //Pattern para liberar o recurso (conexão)
        private bool _disposed = false;

        public void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _db.Dispose();
            }
            _disposed = true;
        }

        //Libera a conexão com o banco de dados
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _db.SaveChanges();
        }



    }
}