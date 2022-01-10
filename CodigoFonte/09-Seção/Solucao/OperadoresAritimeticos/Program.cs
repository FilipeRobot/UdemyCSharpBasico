using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritimeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma: " + 2 + 2);
            Console.WriteLine("Soma: " + (2 + 2));

            Console.WriteLine("Sobtração: " + (5 - 2));

            Console.WriteLine("Multiplicação: " + (3 * 9));

            Console.WriteLine("Divisão: " + (6 / 2));

            Console.WriteLine("Módulo/Resto: " + (8 % 3));

            Console.ReadKey();
        }
    }
}
