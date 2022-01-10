using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_MudarCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amiguinhos! Feliz ano novo!";

            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto.ToLower());

            Console.ReadKey();
        }
    }
}
