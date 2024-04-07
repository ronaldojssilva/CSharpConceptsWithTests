using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_mock.Repository.Interfaces;
using teste_mock.Services.Interfaces;

namespace teste_mock.Tests.Services
{
    public class ProdutoServiceTest
    {
        private readonly IProdutoService service;
        private readonly Mock<IProdutoRepository> repository;

        public ProdutoServiceTest()
        {
            repository = new Mock<IProdutoRepository>();
            service = new ProdutoService(repository.Object);
        }

        [Fact(DisplayName = "Add: 01 - Deve utilizar respository.Add")]
        public void Add_01()
        {
            int id = 01;
            string nome = "PRODUTO 01";
            string codigo = "1234";

            service.Add(id, nome, codigo);

            repository.Verify(m => m.Add(id, nome, codigo), Times.Once);
        }
    }
}
