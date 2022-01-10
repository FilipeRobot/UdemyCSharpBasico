using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Classe.Veiculo;

namespace _01_Classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Console.WriteLine("Marca: " + carro1.Marca);
            carro1.Marca = "FORD";
            Console.WriteLine("Marca: " + carro1.Marca);


            Console.WriteLine("Luzes Internas: " + carro1.LuzesInternas);
            carro1.AbrirPorta();
            Console.WriteLine("Luzes Internas: " + carro1.LuzesInternas);

            /*     Codigo maior com uma variavel extra inutil
             * 
               string statusFarol = carro1.AcenderFarolAutomaticamente();
               Console.WriteLine("Status Farol: " + statusFarol);
            */

            Console.WriteLine("Status Farol: " + carro1.AcenderFarolAutomaticamente()); // Codigo menor sem variavel inutil
            
            
            
            
            Console.ReadKey();
        }
    }
}
