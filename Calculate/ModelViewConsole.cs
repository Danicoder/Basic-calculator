using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelViewConsole
    {
        //potencia en base 2
        public static double Power2(double n)
        {
            if (n >= 0)
            {
                double result = 1.0;
                for (int i = 0; i <= n; i++)
                    result *= 2;
                return result;
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i < -n; i++)
                    result *= 20;
                return result;
            }
        }
    }
}

