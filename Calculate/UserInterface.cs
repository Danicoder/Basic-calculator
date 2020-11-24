using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class UserInterface
    {

        /*Esta clase sirve para dar opociones e imprimir por pantalla
         MVC: Muestra el menu, lo lee y lo ejecuta*/
        public static void PrintPrime()
        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Número Primo");
            System.Console.WriteLine("----------------------");
        }
        public static void PrintFactorial()

        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Factorial de un número");
            System.Console.WriteLine("----------------------");
        }
        public static void PrintSumatory()
        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Sumatorio de un número");
            System.Console.WriteLine("----------------------");
        }
        public static void PrintOption1 ()
        {
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Potencia en base 2");
            System.Console.WriteLine("------------------");
        }
        public static void PrintHeadMenu()
        {
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Menú principal");
            System.Console.WriteLine("--------------");

        }
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número"); //multiplicar todos los numeros enteros y positivos consecutivamente desde la unidad hasta el numero 
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir del programa");
        }
        public static int ReadMainMenuOption()
        {
            try
            {
                int UserOption;
                UserOption = System.Convert.ToInt32(System.Console.ReadLine());
                return UserOption;
            }
            catch
            {
                return -1;
            }
        }
        public static void ExitProgram ()
        {
            System.Console.WriteLine("Si deseas salir del programa pulsa 0 \nde lo contrario escribe: volver");
            string Choice = System.Console.ReadLine();
            string BackTo = ("volver");
            string exit = "0";

            if (Choice == BackTo)
            {
                PrintMainMenu();
                ReadMainMenuOption();
            }
            else if (Choice == exit) return;
        }
    }
}
