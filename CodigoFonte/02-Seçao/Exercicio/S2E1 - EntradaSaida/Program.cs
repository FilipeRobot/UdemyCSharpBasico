using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2E1___EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.Write("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Console.WriteLine("Seu Nome é: " + nome + " \nSeu ano de nascimento é: " + (DateTime.Now.Year - idade));

            Console.ReadKey();
        }
    }
}
