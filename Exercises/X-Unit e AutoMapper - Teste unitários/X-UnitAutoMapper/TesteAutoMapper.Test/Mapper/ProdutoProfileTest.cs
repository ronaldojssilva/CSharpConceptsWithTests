using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutoMapper.Api.Dtos;
using TesteAutoMapper.Api.Mappers;
using TesteAutoMapper.Api.Models;

namespace TesteAutoMapper.Test.Mapper
{
    public class ProdutoProfileTest
    {
        private readonly IMapper mapper;

        public ProdutoProfileTest()
        {
            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProdutoProfile());
            });

            mapper = config.CreateMapper();
        }

        [Fact(DisplayName = "Map: 01 - Deve maperar coretamente a propriedade ProdutoCodigo")]
        public void Map_01()
        {
            const string expected = "1234 - PRODUTO TESTE";
            ProdutoModel produto = new ProdutoModel
            {
                Codigo = "1234",
                Nome = "PRODUTO TESTE"
            };

            ProdutoDto produtoDto = mapper.Map<ProdutoDto>(produto);

            Assert.Equal(expected, produtoDto.NomeCodigo);
        }

    }
}
