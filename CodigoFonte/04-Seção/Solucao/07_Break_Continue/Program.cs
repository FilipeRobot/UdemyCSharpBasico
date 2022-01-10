using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Break_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Continue--------------");
            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    Console.WriteLine("-");
                    continue;
                }
                Console.WriteLine("Linha: " + i);
            }

            Console.WriteLine("--------------Break--------------");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("Linha: " + i);
            }

            Console.ReadKey();
        }
    }
}
