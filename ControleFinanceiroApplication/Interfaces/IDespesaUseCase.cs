using ControleFinanceiroApplication.DTOs;
using ControleFinanceiroApplication.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroApplication.Interfaces
{
    public interface IDespesaUseCase
    {
        Task<List<DespesaDTO>> ListaDespesa();
    }
}
