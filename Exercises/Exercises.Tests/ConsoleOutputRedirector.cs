using Xunit.Abstractions;

namespace Exercises.Domain
{
    public class ConsoleOutputRedirector : IDisposable
    {
        private readonly ITestOutputHelper _output;
        private readonly StringWriter _consoleOutputWriter;
        private readonly TextWriter _originalConsoleOutputWriter;

        public ConsoleOutputRedirector(ITestOutputHelper output)
        {
            _output = output;
            _consoleOutputWriter = new StringWriter();
            _originalConsoleOutputWriter = Console.Out;
            Console.SetOut(_consoleOutputWriter);
        }

        public void Dispose()
        {
            // Restaurar a saída original do console quando terminar
            Console.SetOut(_originalConsoleOutputWriter);
            // Escrever todo o conteúdo redirecionado para ITestOutputHelper
            _output.WriteLine(_consoleOutputWriter.ToString());
            _consoleOutputWriter.Dispose();
        }
    }
}
