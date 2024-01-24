using System;
using System.Collections.Generic;

namespace CodeTest.Models
{
    public partial class Vnd002Vendum
    {
        public int IdeVenda { get; set; }
        public int IdeVendedor { get; set; }
        public int IdeModeloVersao { get; set; }
        public decimal VlrPrecoVenda { get; set; }
        public bool StaValeCombustivel { get; set; }

        public virtual Vei004ModeloVersao IdeModeloVersaoNavigation { get; set; } = null!;
        public virtual Vnd001Vendedor IdeVendedorNavigation { get; set; } = null!;
    }
}
