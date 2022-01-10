using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4E1___POO_e_EstruturaRepeticao
{
    internal class Matematica
    {
        public static int Exponenciacao(int Base, int Exp)
        {
            int Resultado = 0;
            for (int i = 0; i < Exp; i++)
            {
                if (i == 0)
                {
                    Resultado = Base;
                    continue;
                }
                else
                {
                    Resultado = Resultado * Base;
                }
            }
            if(Exp == 0)
            {
                Resultado = 1;
            }
            return Resultado;
        }
    }
}

/*
 * 
 * namespace S4E1___PO_e_EstruturaRepeticao

{

    class Matematica

    {

        public static int Exponenciacao(int Base, int Exp)

        {

            int Resultado = 0;



            for (int i = 0; i < Exp; i++)

            {

                if (i == 0)

                {

                    Resultado = Base;

                    continue;

                }

                else

                {

                    Resultado = Resultado * Base;

                }

               

            }



            if (Exp == 0)

            {

                Resultado = 1;

            }

            return Resultado;

        }

    }

}
 * 
 * 
 * 
 * 
 * 
 */