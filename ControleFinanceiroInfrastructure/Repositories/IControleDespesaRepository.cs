using ControleFinanceiroDomain.DTOs;
using ControleFinanceiroDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleFinanceiroInfrastructure.Repositories
{
    public interface IControleDespesaRepository
    {
        Task<List<Despesa>> ListaDespesa();
        Task<bool> IncluiDespesa(DespesaDTO despesaDTO);
        Task<bool> ExcluirDespesa(int id);
    }
}
