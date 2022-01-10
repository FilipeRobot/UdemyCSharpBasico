using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConversaoTextoParaNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NumeroTexto = "30";
            int Numero1 = int.Parse(NumeroTexto);
            int Numero2 = 30;

            Console.Write("O resultado da soma é: " + (Numero1 + Numero2));
            Console.ReadKey();
        }
    }
}
