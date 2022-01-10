using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita.Biblioteca
{
    internal class Moto : Veiculo
    {
        public int Rodas = 2;

        public override void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Moto.Mover");
            base.Mover();
        }
    }
}
