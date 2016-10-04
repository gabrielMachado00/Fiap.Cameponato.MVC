using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Apostila08.MVC.Web.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public decimal Salario { get; set; }

        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}