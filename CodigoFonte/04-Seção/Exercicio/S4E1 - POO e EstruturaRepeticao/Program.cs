using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4E1___POO_e_EstruturaRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Infome a Base: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Infome o Expoente: ");
                int num2 = int.Parse(Console.ReadLine());
                int resultado = Matematica.Exponenciacao(num1, num2);

                Console.WriteLine(num1 + " Elevado a " + num2 + " é: " + resultado);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
