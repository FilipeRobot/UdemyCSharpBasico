using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EC_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char saida = 'n';
            do
            {
                
                Console.WriteLine("Qual é o seu estado civil? (informe: S - Solteiro, C - Casado, V - Viuvo, D - Divorciado");
                string estadoCivil = Console.ReadLine();
                switch (estadoCivil.ToUpper())
                {
                    case "S":
                        Console.WriteLine("Você está solteiro, sugestão: Encontre alguem na rede social.");
                        break;
                    case "C":
                        Console.WriteLine("Você está casado, sugestão: Prepare uma noite especial.");
                        break;
                    case "V":
                        Console.WriteLine("Você está viuvo, sugestão: Tente outra vez.");
                        break;
                    case "D":
                        Console.WriteLine("Você está divorciado, sugestão: Tente reatar.");
                        break;
                    default:
                        Console.WriteLine("Comando não reconhecido");
                        break;
                }

                //-------------------------------------------------//
                Console.Write("Deseja sair do programa ? S/N : ");
                saida = char.Parse(Console.ReadLine().ToLower());
            } while (saida == 'n');
        }
    }
}
