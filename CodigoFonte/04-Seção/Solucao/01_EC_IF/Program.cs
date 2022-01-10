using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EC_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char saida = 'n';
            while (saida == 'n' || saida == 'N')
            {
                float valorPoupanca;
                Console.Write("Digite o valor que você possui na conta poupança: ");
                valorPoupanca = float.Parse(Console.ReadLine()); //Convert.ToSingle(Console.ReadLine());

                if (valorPoupanca > 100000)
                {
                    Console.WriteLine("Você cliente VIP possui uma taxa de jurus diferenciada.");
                } else if (valorPoupanca > 50000)
                {
                    Console.WriteLine("Você cliente especial com taxa de jurus de 1.2% ao mês.");
                }
                else
                {
                    Console.WriteLine("Você é um cliente especial. Mas sua taxa de jurus é normal(0,5% ao mês).");
                }

                //-------------------------------------------------//
                Console.Write("Deseja sair do programa ? S/N : ");
                saida = char.Parse(Console.ReadLine());
            }
        }
    }
}
