﻿using System;
using System.Collections.Generic;

namespace CodeTest.Models
{
    public partial class Vei003Combustivel
    {
        public Vei003Combustivel()
        {
            Vei004ModeloVersaos = new HashSet<Vei004ModeloVersao>();
        }

        public byte IdeCombustivel { get; set; }
        public string NmeCombustivel { get; set; } = null!;

        public virtual ICollection<Vei004ModeloVersao> Vei004ModeloVersaos { get; set; }
    }
}
