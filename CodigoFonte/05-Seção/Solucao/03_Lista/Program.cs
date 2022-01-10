using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> marcas = new List<string>();

            marcas.Add("FIAT");
            marcas.Add("Chevrolet");
            marcas.Add("Renault");
            marcas.Add("Pegeout");
            marcas.Add("Volkswagen");

            foreach (string marca in marcas)
            {
                Console.WriteLine("Marca: " + marca);
            }
            Console.WriteLine("Primeira Marca: " + marcas[0]);

            Console.ReadKey();
        }
    }
}
