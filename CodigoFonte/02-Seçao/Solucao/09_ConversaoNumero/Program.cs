using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ConversaoNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short meuShort = 10;
            int meuInt = meuShort;
            long meuLong = meuInt;

            long meuLong2 = 10;
            int meuInt2 = System.Convert.ToInt32(meuLong2);
            short meuShort2 = System.Convert.ToInt16(meuInt2);

        }
    }
}
