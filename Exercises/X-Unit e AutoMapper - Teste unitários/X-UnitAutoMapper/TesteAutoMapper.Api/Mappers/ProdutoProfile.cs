using AutoMapper;
using TesteAutoMapper.Api.Dtos;
using TesteAutoMapper.Api.Models;

namespace TesteAutoMapper.Api.Mappers
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<ProdutoModel, ProdutoDto>()
                .ForMember(m => m.NomeCodigo, opt => opt.MapFrom( src => $"{src.Codigo} - {src.Nome}"));
        }
    }
}
