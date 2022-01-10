using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Faça um programa que gera a tabuada do número informado pelo usuário.
            Console.Title = "Questão 4";
            Console.Write("Informe para qual numero você quer ver a tabuada: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num*i));
            }
            Console.ReadKey();
        }
    }
}
