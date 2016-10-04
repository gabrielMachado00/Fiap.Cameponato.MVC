using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Apostila08.MVC.Web.Models;
using Fiap.Apostila08.MVC.Web.Contexts;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        //Context
        private CampeonatoContext _db;

        //Construtor: ctor -> tab tab
        public JogadorRepository(CampeonatoContext context)
        {
            _db = context;
        }

        public void Delete(int id)
        {
            var jogador = _db.Jogadores.Find(id);
            _db.Jogadores.Remove(jogador);
        }

        public Jogador FindById(int id)
        {
            return _db.Jogadores.Find(id);
        }

        public void Insert(Jogador jogador)
        {
            _db.Jogadores.Add(jogador);
        }

        public List<Jogador> List()
        {
            //Include -> busca o time do jogador
            return _db.Jogadores.Include("Time").ToList();
        }

        public List<Jogador> SearchFor(Expression<Func<Jogador, bool>> busca)
        {
            return _db.Jogadores.Where(busca).ToList();
        }

        public void Update(Jogador jogador)
        {
            _db.Entry(jogador).State = System.Data.Entity.EntityState.Modified;
        }
    }
}