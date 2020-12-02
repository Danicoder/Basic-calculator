using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelViewConsole
    {
        public static double LaunchPower2(int Number)
        {
            if (Number > 0 || Number == 0)
            {
                double Constant = 1.0;
                for (int i = 0; i < Number; i++)
                    Constant *= 2;
                return Constant;
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i > Number; i--)
                    result *= 2;
                return (1 / result);
            }
        }
        //no hay números negativos porque en dicho caso se realizaría el valor absoluto del mismo.
        public static int GiveSumatory(int Option)
        {
            if(Option > 0)
            {
                int result = 0;
                for (int j = 0; Option > j; j++)
                {
                    result += 1;
                }
                return result;
            }
        }
        public static double LaunchFactorialNumber(int number)
        {
            for (int i= 0; number > i; i++)
            {
                return i;
            }
        }
        public static void LaunchIsPrime(int number)
        {
            bool salir = true;
            if (salir == true)
            {
                if (number != 0 || number > 0)
                {
                    if ((number % 2) == 0 || (number % 3) == 0)
                        System.Console.WriteLine("No es primo");
                    else
                        System.Console.WriteLine("Es primo");
                }
                if (number < 0 || number == 0) System.Console.WriteLine("Los numeros negativos y el cero, no son primos");
            }
        }

    }
}

