using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using _01_LocalizarCodigo.Lib;

namespace _01_LocalizarCodigo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lib.Veiculo.Mover(); //Para remover o "Lib" dessa linha precisa descomentar o "using _01_LocalizarCodigo.Lib;"
            Console.WriteLine();
        }
    }
}
