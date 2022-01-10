using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Heranca.Biblioteca;

namespace _01_Heranca
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
        }
    }
}
