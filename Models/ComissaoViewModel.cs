using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTest.Models
{
    public class ComissaoViewModel
    {
        public string NomeVendedor { get; set; } = string.Empty;
        public int QtdVeiculosVendidos { get; set; }
        public int QtdValesCombustiveis { get; set; }
        public decimal TotalVendas { get; set; }
        public decimal TotalComissao { get; set; }
    }
}
