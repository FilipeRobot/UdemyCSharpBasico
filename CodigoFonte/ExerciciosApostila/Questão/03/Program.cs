﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Faça um programa que gera e escreve os números ímpares dos números lidos entre 0 e 200

            Console.Title = "Questão 3";

            for (int i = 0; i < 200; i++)
            {
                if((i % 2) == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
