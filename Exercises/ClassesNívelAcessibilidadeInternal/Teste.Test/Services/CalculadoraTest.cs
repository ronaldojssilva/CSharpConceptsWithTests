using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Teste.Services;
using Teste.Services.Exception;
using Teste.Services.Interfaces;
using Xunit;

namespace Teste.Test.Services
{
    public class CalculadoraTest
    {
        private readonly ICalculadora calculadora;

        public CalculadoraTest()
        {
            calculadora = new Calculadora();
        }

        [Fact(DisplayName = "SomaDoisNumeros: 01 - Deve calcular a soma de dois numeros")]
        public void SomaDoisNumeros_01()
        {
            int numero1 = 10;
            int numero2 = 05;
            int resultadoEsperado = 15;

            int resultado = calculadora.Soma(numero1, numero2);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact(DisplayName = "Dvidir: 01 - Quando o segundo numero for igual a zero deve subir DivisaoPorZeroException")]
        public void Divisao_01()
        {
            int numero1 = 10;
            int numero2 = 0;

            Assert.Throws<DivisaoPorZeroException>(() => calculadora.Dividir(numero1, numero2));
        }

        [Fact(DisplayName = "Dvidir: 02 - Quando o segundo numero for igual a zero deve subir DivisaoPorZeroException")]
        public void Divisao_02()
        {
            int numero1 = 10;
            int numero2 = 0;

            var myException = Assert.Throws<DivisaoPorZeroException>(() => calculadora.Dividir(numero1, numero2));

            //Assert
            Assert.Equal("Teste", myException.Message);
        }

        [Fact(DisplayName = "Dvidir: 03 - Quando o segundo numero não for igual a zero não deve subir DivisaoPorZeroException")]
        public void Divisao_03()
        {
            int numero1 = 10;
            int numero2 = 5;

            // act
            var ex = calculadora.Dividir(numero1, numero2);
            //var ex = Record.Exception(() => calculadora.Dividir(numero1, numero2));

            // assert
            Assert.IsNotType<DivisaoPorZeroException>(ex);
            //Assert.Null(ex);

        }

        [Fact(DisplayName = "Dvidir: 04 - Quando o segundo numero não for igual a zero não deve subir DivisaoPorZeroException")]
        public void Divisao_04()
        {
            int numero1 = 10;
            int numero2 = 5;

            // Act & Assert
            try
            {
                calculadora.Dividir(numero1, numero2);

                // Se o método não lançar uma exceção, então o teste passa
            }
            catch (DivideByZeroException)
            {
                // Se o método lançar uma exceção DivideByZeroException, então o teste falha
                Assert.True(false, "O método lançou uma exceção DivisaoPorZeroException, mas não deveria.");
            }

        }


        [Fact(DisplayName = "Dvidir: 05 - Deve calcular o resultado da divisão corretamente")]
        public void Divisao_05()
        {
            //Arrange
            int numero1 = 10;
            int numero2 = 5;
            int expected = 2;

            var resultado = calculadora.Dividir(numero1, numero2);

            Assert.Equal(expected, resultado);
        }
    }
}
