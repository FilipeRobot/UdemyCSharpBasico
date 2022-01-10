using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DividirTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomes = "João, Maria., José, Filipe., Tiago e Paulo.";
            string[] separador = { ", ", " e " };
            string[] nomeArray = nomes.Split(separador, StringSplitOptions.None);

            Console.WriteLine("--------Sem remover ponto do final de cada nome---------");
            foreach (string nome in nomeArray)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("--------Removendo ponto do final de cada nome---------");
            foreach (string nome in nomeArray)
            {
                if (nome.Last() == '.')
                {
                    Console.WriteLine(nome.Remove(nome.IndexOf('.')));
                }
                else
                {
                    Console.WriteLine(nome);
                }
            }

            Console.ReadKey();
        }
    }
}
