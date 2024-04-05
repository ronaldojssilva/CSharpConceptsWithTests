using Exercises.Domain;
using System;
using Xunit.Abstractions;

namespace Exercises.Tests
{
    public class HelloWorldTest
    {
        private readonly ITestOutputHelper _output;

        public HelloWorldTest(ITestOutputHelper output)
        {
            _output = output;
        }


        [Fact]
        public void SayHello_Test()
        {
            //(A)Arrange
            var calculator = new HelloWorld();

            //(A)Act
            string mensagem = calculator.SayHello();

            //(A)Assert
            Assert.Equal("Hello World!", mensagem);
        }

        [Fact]
        public async Task MultiplyAsync_ShouldReturnProductOfNumbers()
        {
            // Arrange
            var calculator = new HelloWorld();
            int number1 = 5;
            int number2 = 10;
            int expected = 50;

            // Act
            int result = await calculator.MultiplyAsync(number1, number2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public async Task TarefaAsync_1_test()
        {
            //Arrange
            var helloWorld = new HelloWorld();

            //Act            
            var espected1 = $"## Tarefa Um COCNLU�DA!";

            // Redirecionar a sa�da do console para um StringWriter
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Executar o c�digo que gera mensagens com Console.WriteLine
                Task<string> task1 = helloWorld.TarefaAsync("Um", 5);
                Console.WriteLine("Esta mensagem ser� exibida no output do teste.");
                var return1 = await task1;

                // Obter o conte�do da sa�da do console e envi�-lo para o ITestOutputHelper
                string consoleOutput = sw.ToString();
                _output.WriteLine(consoleOutput);

                //assert
                Assert.Equal(espected1, return1);

            }
        }

        [Fact]
        public async Task TarefaAsync_3_test()
        {
            // Redirecionar a sa�da do console para um StringWriter
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                //Arrange
                var helloWorld = new HelloWorld();

                //Act            
                var espected1 = $"## Tarefa Um COCNLU�DA!";
                var espected2 = $"## Tarefa Dois COCNLU�DA!";
                var espected3 = $"## Tarefa Tres COCNLU�DA!";

                // Executar o c�digo que gera mensagens com Console.WriteLine
                Task<string> task1 = helloWorld.TarefaAsync("Um", 5);
                Task<string> task2 = helloWorld.TarefaAsync("Dois", 10);

                var return1 = await task1;

                Task<string> task3 = helloWorld.TarefaAsync("Tres", 5);

                var return2 = await task2;
                var return3 = await task3;

                // Obter o conte�do da sa�da do console e envi�-lo para o ITestOutputHelper
                string consoleOutput = sw.ToString();
                _output.WriteLine(consoleOutput);

                //assert
                Assert.Equal(espected1, return1);
                Assert.Equal(espected2, return2);
                Assert.Equal(espected3, return3);

            }
        }

        [Fact]
        public async Task TarefaAsync_2_test()
        {
            // Redirecionar a sa�da do console para um StringWriter
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                //Arrange
                var helloWorld = new HelloWorld();

                //Act            
                var espected1 = $"## Tarefa Um COCNLU�DA!";
                var espected2 = $"## Tarefa Dois COCNLU�DA!";

                // Executar o c�digo que gera mensagens com Console.WriteLine
                Task<string> task1 = helloWorld.TarefaAsync("Um", 5);
                Task<string> task2 = helloWorld.TarefaAsync("Dois", 5);

                Console.WriteLine("Esta mensagem ser� exibida no output do teste.");
                var return1 = await task1;
                var return2 = await task2;

                // Obter o conte�do da sa�da do console e envi�-lo para o ITestOutputHelper
                string consoleOutput = sw.ToString();
                _output.WriteLine(consoleOutput);

                //assert
                Assert.Equal(espected1, return1);
                Assert.Equal(espected2, return2);

            }
        }
    }
}