using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Apostila08.MVC.Web.Repositories
{
    public interface ITimeRepository
    {
        void Cadastrar(Time time);
        List<Time> Listar();
    }
}
