using System;
using System.Collections.Generic;

namespace CodeTest.Models
{
    public partial class Vnd001Vendedor
    {
        public Vnd001Vendedor()
        {
            Vnd002Venda = new HashSet<Vnd002Vendum>();
        }

        public int IdeVendedor { get; set; }
        public string NmeVendedor { get; set; } = null!;

        public virtual ICollection<Vnd002Vendum> Vnd002Venda { get; set; }
    }
}
