using System;
using System.Collections.Generic;

namespace CodeTest.Models
{
    public partial class Vei004ModeloVersao
    {
        public Vei004ModeloVersao()
        {
            Vnd002Venda = new HashSet<Vnd002Vendum>();
        }

        public int IdeModeloVersao { get; set; }
        public int IdeModelo { get; set; }
        public byte IdeCombustivel { get; set; }
        public short? NroAno { get; set; }
        public decimal VlrPrecoTabelado { get; set; }

        public virtual Vei003Combustivel IdeCombustivelNavigation { get; set; } = null!;
        public virtual Vei002Modelo IdeModeloNavigation { get; set; } = null!;
        public virtual ICollection<Vnd002Vendum> Vnd002Venda { get; set; }
    }
}
