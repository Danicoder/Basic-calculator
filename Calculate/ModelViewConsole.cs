using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelViewConsole
    {
        public static double ManagePower2(int Number)
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
        public static int ManageSumatory (int number)
        {
            int result =0;
            for (int i = 0; number > i; i++)
            {
                result += 1; 
            }
            return result;
        }
        public static void LaunchFactorialNumber()
        {
            
            if (number == 0) System.Console.Write("0! = 1"); //puesto que 0!=1
            for (int i= 0; number > i; i++)
            {
                System.Console.Write("x"+i);
            }
            if(number < 0) System.Console.Write("No se puede calcular el factorial de un número negativo");
        }
        public static void ManageIsPrime()
        {
            UserInterface.PrintPrime();
            System.Console.WriteLine("¿Cúal número quieres saber sí es primo o no? Teclealo");
            int number= Utils.ReadOption();
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

