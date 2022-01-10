using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca.Derivada.Carro carro = new Biblioteca.Derivada.Carro();
            MoverVeiculo(carro);

            Biblioteca.Derivada.Moto moto = new Biblioteca.Derivada.Moto();
            MoverVeiculo(moto);

            Console.ReadKey();
        }

        public static void MoverVeiculo(Biblioteca.Veiculo veiculo)
        {
            veiculo.Mover();
        }
    }
}
