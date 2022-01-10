using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Construtor
{
    internal class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro()
        {
            Marca = "Fiat";
            Modelo = "Palio";
        }
        public Carro(string Marca, string Modelo, int ano)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            Ano = ano;
        }
    }
}
