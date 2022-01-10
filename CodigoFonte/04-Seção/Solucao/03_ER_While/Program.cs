using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ER_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Valor da Variável i: " + i);
                i++; // i = i + 1;
            }

            Console.WriteLine("--------------------------------");
            int x = 0;
            bool repetir = true;
            while (repetir)
            {
                Console.WriteLine("Valor da Variável x: " + x);
                if (x > 20)
                {
                    Console.WriteLine("Saindo do programa");
                    repetir = false;
                }
                x++; // x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
