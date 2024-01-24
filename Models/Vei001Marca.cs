using System;
using System.Collections.Generic;

namespace CodeTest.Models
{
    public partial class Vei001Marca
    {
        public Vei001Marca()
        {
            Vei002Modelos = new HashSet<Vei002Modelo>();
        }

        public int IdeMarca { get; set; }
        public string NmeMarca { get; set; } = null!;

        public virtual ICollection<Vei002Modelo> Vei002Modelos { get; set; }
    }
}
