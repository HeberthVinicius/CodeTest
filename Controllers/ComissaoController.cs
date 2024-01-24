using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CodeTest.Models;
using CodeTest.Services;

namespace CodeTest.Controllers
{
    public class ComissaoController : Controller    
    {
        private readonly IComissaoService _comissaoService;

        public ComissaoController(IComissaoService comissaoService)
        {
            _comissaoService = comissaoService;
        }

        public IActionResult Index()
        {
            var comissoes = _comissaoService.ObterComissoesVendedores();
            return View(comissoes);
        }
    }
}

