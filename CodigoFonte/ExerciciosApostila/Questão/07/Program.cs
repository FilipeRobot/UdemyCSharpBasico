using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  7. Escreva um programa que receba uma quantidade definida pelo usuário de números e
             *     pegue o maior e o menor número informado e apresente na tela.
             */
            List<int> listaNumeros = new List<int>();
            int qtdNumeros;

            Console.Write("Informe quantos numeros serão informados: ");
            qtdNumeros = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 0; i < qtdNumeros; i++)
            {
                Console.Write($"Informe o {i + 1}º número: ");
                listaNumeros.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("=========================");
            Console.WriteLine("O menor número informado foi: " + listaNumeros.Min());
            Console.WriteLine("O maior número informado foi: " + listaNumeros.Max());

            Console.ReadKey();
        }
    }
}
