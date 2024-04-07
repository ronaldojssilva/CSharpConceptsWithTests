using teste_mock.Models.Entities;

namespace teste_mock.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        Produto Add(int id, string nome, string codigo);
    }
}
