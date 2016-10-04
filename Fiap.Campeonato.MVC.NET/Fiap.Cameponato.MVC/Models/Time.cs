using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public DateTime DataFundacao { get; set; }
        public string Cor { get; set; }
        public virtual List<Jogador> Jogadores { get; set; }
    }
}