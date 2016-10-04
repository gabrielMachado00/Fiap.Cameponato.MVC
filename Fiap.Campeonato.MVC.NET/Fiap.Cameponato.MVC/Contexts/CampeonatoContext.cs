using Fiap.Apostila08.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Contexts
{
    public class CampeonatoContext : DbContext
    {
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Time> Times { get; set; }
    }
}