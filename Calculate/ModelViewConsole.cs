using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelViewConsole
    {
        //potencia en base 2
        public static void ManagePower2()
        {
            UserInterface.PrintOption1();
            System.Console.WriteLine("Teclea los números que deseas calcular");
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
            System.Console.WriteLine("Teclea el número que deseas sumar");
            int number = UserInterface.ReadMainMenuOption();
            for (int i = 1; number >= i; i++)
            {
                System.Console.Write("+"+i);
            }
        }
        public static void LaunchFactorialNumber()
        {
            UserInterface.PrintFactorial();
            System.Console.WriteLine("Teclea el número que deseas factorizar");
            int number = UserInterface.ReadMainMenuOption();
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
            int number= UserInterface.ReadMainMenuOption();
            
            if (number != 0 || number > 0)
            {
                if ((number % number) == 0 && (number % 1) == 0)
                {
                    System.Console.WriteLine("Es primo");
                }
                else
                {
                    System.Console.WriteLine("No es primo");
                    System.Console.ReadLine();
                }
                
            }
            if (number < 0 || number == 0) System.Console.WriteLine("Los números negativos o menores a cero no son primos");
            UserInterface.ExitProgram();
        }

    }
}

