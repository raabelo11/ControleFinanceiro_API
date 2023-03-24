using AutoMapper;
using ControleFinanceiroDomain.DTOs;
using ControleFinanceiroApplication.Interfaces;
using ControleFinanceiroInfrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

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

        public async Task<bool> Incluir(DespesaDTO despesaDTO)
        {
            return await _controleDespesaRepository.IncluiDespesa(despesaDTO);
        }

        public async Task<string> ExcluirDespesa(int id)
        {
            try
            {
                if (id != 0)
                    await _controleDespesaRepository.ExcluirDespesa(id);

                    return ("Despesa Excluída !");

            }
            catch (Exception ex)
            {
                return ("Houve um erro ao excluir a despesa, por favor digite um id existente na base! Erro: " + ex.Message);
            }
        }           
    }
}
