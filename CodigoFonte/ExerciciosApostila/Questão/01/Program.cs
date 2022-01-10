using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Escreva um programa que exiba os números de 1 a 1000 na tela em ordem decrescente.
            Console.Title = "Questão 1";
            for (int i = 1000; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
