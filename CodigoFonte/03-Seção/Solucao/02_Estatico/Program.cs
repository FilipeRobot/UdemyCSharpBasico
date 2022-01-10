using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estatico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro.QuantidadeCarrosProduzidos = 2000000000;
            Carro carro1 = new Carro();
            
        }
    }
}
