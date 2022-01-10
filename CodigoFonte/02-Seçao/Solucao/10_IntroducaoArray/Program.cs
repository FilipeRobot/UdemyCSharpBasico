using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroducaoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"João da Silva", "José da Costa", "Maria da Costa", "Filipe Lemos"}; 
            //O indice do Array Começa em 0 ! no exemplo acima o array tem 4 possições, ou seja, o indice vai de 0 a 3.

            Console.WriteLine("Nome de N3: " + nomes[2]);
            nomes[2] = "Miguel da Costa";
            Console.WriteLine("Nome de N3: " + nomes[2]);
            Console.ReadKey();
        }
    }
}
