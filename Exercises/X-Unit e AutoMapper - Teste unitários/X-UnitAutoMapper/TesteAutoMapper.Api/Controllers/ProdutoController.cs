using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteAutoMapper.Api.Dtos;
using TesteAutoMapper.Api.Models;

namespace TesteAutoMapper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ProdutoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ProdutoDto GetProdutoDto()
        {
            ProdutoModel model = new ProdutoModel
            {
                Nome = "Produto 01",
                Codigo = "1234"
            };

            return _mapper.Map<ProdutoDto>(model);
        }
    }
}
