using System.Runtime.CompilerServices;
using teste_mock.Models.Entities;
using teste_mock.Repository.Interfaces;


[assembly: InternalsVisibleTo("teste-mock.Tests")]
namespace teste_mock.Services.Interfaces
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public Produto Add(int id, string nome, string codigo)
        {
            _repository.Add(id, nome, codigo);
            return null;
        }
    }
}
