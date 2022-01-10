using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sobrescrita.Biblioteca
{
    internal class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QuantidadeMaxPassageiros;
        public int Ano;

        public virtual void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Veiculo.Mover");
        }
    }
}
