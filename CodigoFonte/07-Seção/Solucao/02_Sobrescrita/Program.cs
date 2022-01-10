using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Sobrescrita.Biblioteca;

namespace _02_Sobrescrita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Veiculo vei = new Veiculo();

            carro.Marca = "FIAT";
            moto.Marca = "Triumph";
            vei.Marca = "Airbus";

            carro.Mover();
            moto.Mover();
            vei.Mover();

            Console.ReadKey();
        }
    }
}
