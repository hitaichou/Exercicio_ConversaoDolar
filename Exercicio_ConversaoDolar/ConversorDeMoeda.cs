using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_ConversaoDolar
{
    class ConversorDeMoeda
    {
        //constante taxa IOF
        public static double iof = 0.06;

        public static double ConversaoDolar (double cotD, double qtD)
        {
            return (qtD + (qtD * iof)) * cotD;
        }
    }
}
