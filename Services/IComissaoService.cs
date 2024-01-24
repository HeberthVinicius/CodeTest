using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTest.Models;

namespace CodeTest.Services
{
    public interface IComissaoService
    {
        List<ComissaoViewModel> ObterComissoesVendedores();
    }
}