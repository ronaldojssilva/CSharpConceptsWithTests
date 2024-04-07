using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Teste.Services.Interfaces;

namespace TesteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadora _calculadora;

        public CalculadoraController(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpGet("/soma")]
        public int Calculadora(int numero1, int numero2)
        {
            return _calculadora.Soma(numero1, numero2);
        }

        [HttpGet("/divisao")]
        public int Divisao(int numero1, int numero2)
        {
            return _calculadora.Dividir(numero1, numero2);
        }
    }
}
