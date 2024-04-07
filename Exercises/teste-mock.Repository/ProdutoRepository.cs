using teste_mock.Models.Entities;

namespace teste_mock.Repository.Interfaces
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Produto Add(int id, string nome, string codigo)
        {
            StreamWriter file = new StreamWriter("./produto.txt", true);
            file.WriteLine($"{id};{nome};{codigo};");
            file.Close();
            return new Produto { Id = id, Nome = nome, Codigo = codigo };
        }
    }
}
