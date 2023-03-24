using ControleFinanceiroDomain.DTOs;
using ControleFinanceiroDomain.Models;
using ControleFinanceiroInfrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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

        public async Task<bool> IncluiDespesa(DespesaDTO despesaDTO)
        {
            Despesa despesa = new Despesa(){
                NomeDespesa = despesaDTO.NomeDespesa,
                VlrDespesa = despesaDTO.VlrDespesa,
                DtDespesa = despesaDTO.DtDespesa,
                DtVencimento = despesaDTO.DtVencimento,
            };

             _context.ControleDespesas.Add(despesa);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ExcluirDespesa(int id)
        {
            var despesa = await _context.ControleDespesas.FirstOrDefaultAsync(p => p.IdDespesa == id);
            _context.ControleDespesas.Remove(despesa);
            _context.SaveChanges();

            return true;
        }
    }
}
