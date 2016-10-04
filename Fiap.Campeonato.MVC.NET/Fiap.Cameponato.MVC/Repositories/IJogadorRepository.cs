using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public interface IJogadorRepository
    {
        void Insert(Jogador jogador);
        void Update(Jogador jogador);
        void Delete(int id);
        List<Jogador> List();
        Jogador FindById(int id);
        List<Jogador> SearchFor(Expression<Func<Jogador, bool>> busca);
    }
}
