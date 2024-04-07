using teste_mock.Models.Entities;

namespace teste_mock.Services.Interfaces
{
    public interface IProdutoService
    {
        Produto Add(int id, string nome, string codigo);
    }
}
