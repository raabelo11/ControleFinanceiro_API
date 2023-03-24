using ControleFinanceiroDomain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleFinanceiroApplication.Interfaces
{
    public interface IDespesaUseCase
    {
        Task<List<DespesaDTO>> ListaDespesa();
        Task<bool> Incluir(DespesaDTO despesaDTO);
        Task<string> ExcluirDespesa(int id);
    }
}
