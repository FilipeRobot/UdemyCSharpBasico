using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Biblioteca
{
    internal class Calculo
    {
        public static int Soma(int[] valores)
        {
            int resultado = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                resultado += valores[i];
            }
            return resultado;
        }
        public static int Media(int[] valores)
        {
            int resultado = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                resultado = resultado + valores[i];
            }
            return resultado / valores.Length;
        }
    }
}
