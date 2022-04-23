using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirvi_Meeli_Kodutöö_nr_02
{
    internal class matemaatika
    {
        public float number1;
        public float number2;
        public string tehing = "";
        public float result;

        public float arvutus()
        {
            if (tehing == "+")
            {
                result = number1 + number2;
            }
            else if (tehing == "-")
            {
                result = number1 - number2;
            }
            else if (tehing == "*")
            {
                result = number1 * number2;
            }
            else if (tehing == "/")
            {
                result = number1 / number2;
            }

            return (result);
        }
    }
}
