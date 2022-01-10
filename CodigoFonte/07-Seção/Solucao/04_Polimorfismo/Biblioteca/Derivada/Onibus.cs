using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo.Biblioteca.Derivada
{
    internal class Onibus : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Onibus se movendo!!!");
        }
    }
}
