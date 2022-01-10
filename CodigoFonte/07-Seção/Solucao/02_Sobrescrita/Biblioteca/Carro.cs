using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita.Biblioteca
{
    internal class Carro : Veiculo
    {
        public int Rodas = 4;

        public override void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Carro.Mover");
        }
    }
}
