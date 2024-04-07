using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using teste_mock.Services.Interfaces;

namespace teste_mock.Services
{
    public static class InjectServices
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddTransient<IProdutoService, ProdutoService>();
        }
    }
}
