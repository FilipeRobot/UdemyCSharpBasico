using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Biblioteca;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 2. Escreva um programa que leia:
             *   - A quantidade de números que o usuário deseja informar
             *   - Leia cada número e informe a média aritmética e a soma deles.
             * */

            Console.Title = "Questão 2";

            Console.Write("Quantos numeros você deseja informar: ");
            int quantNumeros = int.Parse(Console.ReadLine());
            int[] numeros = new int[quantNumeros];

            for (int i = 1; i < numeros.Length + 1 ; i++)
            {
                Console.Write("Informe o " + i + "º número: ");
                numeros[i-1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("============");
            Console.WriteLine("A média aritimética dos números é: " + Calculo.Media(numeros));
            Console.WriteLine("A soma dos números é: " + Calculo.Soma(numeros));

            Console.ReadKey();
        }
    }
}
