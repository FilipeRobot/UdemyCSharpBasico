using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  9. Faça um programa de conversão de base numérica. O programa deverá apresentar 
             *     uma tela de entrada com as seguintes opções:
             *     1 – Adição
             *     2 – Subtração
             *     3 – Multiplicação
             *     4 – Divisão
             *     Informe a opção:
             *     A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois 
             *     números. Em seguida, o programa deve exibir o resultado da opção indicada pelo 
             *     usuário e perguntar ao usuário se ele deseja voltar ao menu principal. Caso a resposta 
             *     seja “S” ou “s”, deverá voltar ao menu, caso contrário deverá encerrar o programa.
             */
            string opcao = String.Empty; // 1, 2, 3, 4 ou sair
            int num1, num2, resultado; // numeros informados pelo usuario e uma variavel desnecessaria para gurdar o resultado das oprações

            while (opcao.Equals(String.Empty) || opcao == "n" || opcao == "N")
            {
                Console.WriteLine(opcao);
            }
            Console.ReadKey();
        }
    }
}
