using ControleFinanceiroApplication.Repositories;
using ControleFinanceiroDomain.Models;
using ControleFinanceiroInfrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroInfrastructure.Repositories
{
    public class ControleDespesaRepository : IControleDespesaRepository
    {
        private readonly ControleFinanceiroContext _context;

        public ControleDespesaRepository(ControleFinanceiroContext context)
        {
            _context = context;
        }

        public async Task<List<Despesa>> ListaDespesa()
        {
            return await _context.ControleDespesas.AsNoTracking().ToListAsync();
        }
    }
}
