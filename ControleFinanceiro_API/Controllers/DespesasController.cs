using ControleFinanceiroApplication.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControleFinanceiro_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class DespesasController : Controller
    {
        public readonly IDespesaUseCase _despesaUseCase;

        public DespesasController(IDespesaUseCase despesaUseCase)
        {
            _despesaUseCase = despesaUseCase;
        }

        [HttpGet]
        [Route("ListarDespesas")]
        public async Task<IActionResult> ListaDespesa()
        {
            var retorno = await _despesaUseCase.ListaDespesa();

            return Ok(retorno);
        }
    }
}
