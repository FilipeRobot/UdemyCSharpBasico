using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FormatarTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Filipe Lemos";
            string texto = "Bem vindo " + nome + "! Feliz natal!";

            string textoFormatado = string.Format("Bem vindo {0}! Feliz Natal! {0} {1}", nome, "Feliz");

            Console.WriteLine(texto);
            Console.WriteLine(textoFormatado);
            Console.ReadKey();
        }
    }
}
