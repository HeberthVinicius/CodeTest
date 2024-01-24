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
        // var comissoes = _context.Set<ComissaoViewModel>()
        //     .FromSqlRaw("EXEC ListarComissoesVendedores")
        //     .ToList();

        // return comissoes;
        
        using (var connection = new SqlConnection(_context.Database.GetConnectionString()))
            {
                connection.Open();

                // Execute a stored procedure using Dapper and map the result to ComissaoViewModel
                var comissoes = connection.Query<ComissaoViewModel>("ListarComissoesVendedores", commandType: CommandType.StoredProcedure).ToList();

                return comissoes;
            }

    }
    }
}