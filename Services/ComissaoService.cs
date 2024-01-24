using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTest.Models;
using CodeTest.Repositories;

namespace CodeTest.Services
{
    public class ComissaoService : IComissaoService
{
    private readonly IComissaoRepository _comissaoRepository;

    public ComissaoService(IComissaoRepository comissaoRepository)
    {
        _comissaoRepository = comissaoRepository;
    }

    public List<ComissaoViewModel> ObterComissoesVendedores()
    {
        return _comissaoRepository.ListarComissoesVendedores();
    }
}
}