using AutoMapper;
using ControleFinanceiroDomain.DTOs;
using ControleFinanceiroDomain.Models;

namespace ControleFinanceiroApplication.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Despesa, DespesaDTO>().ReverseMap();
        }
    }
}
