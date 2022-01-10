using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo.Biblioteca.Derivada
{
    internal class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Carro se movendo!!!");
        }
    }
}
