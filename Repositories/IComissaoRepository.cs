using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTest.Models;

namespace CodeTest.Repositories
{
    public interface IComissaoRepository
    {
        List<ComissaoViewModel> ListarComissoesVendedores();
    }
}