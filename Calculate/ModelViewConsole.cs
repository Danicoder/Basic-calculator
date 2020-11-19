using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelViewConsole
    {
        //potencia en base 2
        public static void Power2()
        {
            UserInterface.PrintOption1();
            System.Console.WriteLine("introduce los numeros que deseas calcular");
            int n=UserInterface.ReadMainMenuOption();
            if (n >= 0)
            {
                double result = 1.0;
                for (int i = 0; i < n; i++)
                    result *= 2;
                System.Console.WriteLine("la solución es: "+result);
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i < -n; i++)
                    result *= 20;
                System.Console.WriteLine("la solución es: " + result);
            }
        }
        public static void ManageSumatory ()
        {
            UserInterface.PrintSumatory();
            System.Console.WriteLine("introduce el numero que deseas sumar");
            int number = UserInterface.ReadMainMenuOption();
            for (int i = 1; number >= i; i++)
            {
                System.Console.Write("+"+i);
            }
        }
    }
}

