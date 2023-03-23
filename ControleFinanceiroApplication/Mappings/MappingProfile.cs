using AutoMapper;
using ControleFinanceiroApplication.DTOs;
using ControleFinanceiroDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
