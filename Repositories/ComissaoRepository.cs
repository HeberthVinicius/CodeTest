using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeTest.Models;
using CodeTest.Repositories;
using CodeTest.Context;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;

namespace CodeTest.Repositories
{
    public class ComissaoRepository : IComissaoRepository
    {
        private readonly DBCONCESSIONARIAContext _context;

        public ComissaoRepository(DBCONCESSIONARIAContext context)
        {
            _context = context;
        }

        public List<ComissaoViewModel> ListarComissoesVendedores()
        {   
            using (var connection = new SqlConnection(_context.Database.GetConnectionString()))
            {
                connection.Open();

                var comissoes = connection.Query<ComissaoViewModel>("ListarComissoesVendedores", commandType: CommandType.StoredProcedure).ToList();

                return comissoes;
            }

        }
    }
}