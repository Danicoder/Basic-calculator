using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class ModelViewConsole
    {
        public static void ManagePower2()
        {
            UserInterface.PrintOption1();
            System.Console.WriteLine("Teclea los números que deseas calcular");
            int UserNumber=UserInterface.ReadOption();

            if (UserNumber > 0 || UserNumber == 0)
            {
                double Constant = 1.0;
                for (int i = 0; i < UserNumber; i++)
                    Constant *= 2;
                System.Console.WriteLine("la solución es: "+Constant);
            }
            else
            {
                double result = 1.0;
                for (int i = 0; i > UserNumber; i--)
                    result *= 2;
                    System.Console.WriteLine("la solución es: " + 1/result);
            }
        }
        public static void ManageSumatory ()
        {
            UserInterface.PrintSumatory();
            System.Console.WriteLine("Teclea el número que deseas sumar");
            int number = UserInterface.ReadOption();
            for (int i = 1; number >= i; i++)
            {
                System.Console.Write("+"+i);
            }
            for (int j= 0; number < j; j--)
            {
                System.Console.Write("+(-"+(-j)+")");
            }
        }
        public static void LaunchFactorialNumber()
        {
            UserInterface.PrintFactorial();
            System.Console.WriteLine("Teclea el número que deseas factorizar");
            int number = UserInterface.ReadOption();
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
            int number= UserInterface.ReadOption();
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

