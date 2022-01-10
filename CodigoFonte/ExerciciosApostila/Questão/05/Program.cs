using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Escreva um programa que receba 4 números e apresente a soma dos números pares e depois dos números impares.
            Console.Title = "Questão 5";
            List<int> par = new List<int>();
            List<int> impar = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Informe um número: ");
                int num = int.Parse(Console.ReadLine());
                if((num % 2) == 0)
                {
                    par.Add(num);
                }
                else
                {
                    impar.Add(num);
                }
            }
            Console.WriteLine("Soma numeros pares: " + par.Sum());
            Console.WriteLine("Soma numeros impares: " + impar.Sum());

            Console.ReadKey();
        }
    }
}
