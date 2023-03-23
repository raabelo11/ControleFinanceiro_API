using ControleFinanceiroDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroApplication.Repositories
{
    public interface IControleDespesaRepository
    {
        Task<List<Despesa>> ListaDespesa();
    }
}
