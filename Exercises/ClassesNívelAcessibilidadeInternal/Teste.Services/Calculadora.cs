using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teste.Services.Exception;
using Teste.Services.Interfaces;

[assembly: InternalsVisibleTo("Teste.Test")]
namespace Teste.Services
{
    internal class Calculadora : ICalculadora
    {
        public int Dividir(int numero1, int numero2)
        {
            if (numero2 == 0)
                throw new DivisaoPorZeroException("Teste");
            return numero1 / numero2;
        }

        public int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}
