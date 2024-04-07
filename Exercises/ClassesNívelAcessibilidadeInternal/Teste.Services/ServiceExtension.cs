using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teste.Services.Interfaces;

namespace Teste.Services
{
    public static class ServiceExtension
    {
        public static void InjectService(this IServiceCollection service)
        {
            service.AddScoped<ICalculadora, Calculadora>();
        }
    }
}
