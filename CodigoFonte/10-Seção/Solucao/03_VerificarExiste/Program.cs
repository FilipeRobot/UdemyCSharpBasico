using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_VerificarExiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigos Filipe Lemos de Souza!";

            Console.WriteLine("Verificar existência no inicio: " + texto.StartsWith("Olá"));

            Console.WriteLine("Verificar existência no final: " + texto.EndsWith("!"));

            Console.WriteLine("Verificar existência: " + texto.Contains("Lemos"));

            Console.ReadKey();
        }
    }
}
