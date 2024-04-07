using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Services.Interfaces
{
    public interface ICalculadora
    {
        int Soma(int numero1, int numero2);
        
        int Dividir(int numero1, int numero2);
    }
}
