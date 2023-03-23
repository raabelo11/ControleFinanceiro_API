using AutoMapper;
using ControleFinanceiroApplication.DTOs;
using ControleFinanceiroApplication.Interfaces;
using ControleFinanceiroApplication.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroApplication.UseCases
{
    public class DespesaUseCase : IDespesaUseCase
    {
        private readonly IControleDespesaRepository _controleDespesaRepository;
        private readonly IMapper _mapper;

        public DespesaUseCase(IControleDespesaRepository controleDespesaRepository, IMapper mapper)
        {
            _controleDespesaRepository = controleDespesaRepository;
            _mapper = mapper;
        }

        public async Task<List<DespesaDTO>> ListaDespesa()
        {
            var retorno = await _controleDespesaRepository.ListaDespesa();

            return _mapper.Map<List<DespesaDTO>>(retorno);
        }
    }
}
