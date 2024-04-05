namespace Exercises.Domain
{
    public class HelloWorld
    {
        public string SayHello()
        {
            return "Hello World!";
        }

        public async Task<int> MultiplyAsync(int a, int b)
        {
            //simuling as asynchronous operation with delay
            await Task.Delay(1000); // Dalayiing for 1 second
            return a * b;
        }

        public async Task<string> TarefaAsync(string tarefa, int passos)
        {
            Console.WriteLine($"## Tarega {tarefa} INICIADA");
            //await Console.Out.WriteLineAsync($"## Tarega {tarefa} INICIADA");

            for (int i = passos; i > 0; i--)
            {
                await Task.Delay(1000);
                Console.WriteLine($"    >> Tarefa {tarefa} executando... {i}");
            }
            var fim = $"## Tarefa {tarefa} COCNLUÍDA!";
            Console.WriteLine(fim);
            return fim;
        }
    }
}
