using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LocalizarTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigos, estou muito feliz de esta aqui com voces. Desejo a todos um feliz ano novo.";
            string palavra = "feliz";

            Console.WriteLine("Tamanho do texto: " + texto.Length);
            Console.WriteLine("Localizar: " + texto.IndexOf(palavra));
            Console.WriteLine("Localizar último: " + texto.LastIndexOf(palavra));

            Console.ReadKey();
        }
    }
}
