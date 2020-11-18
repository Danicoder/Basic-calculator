using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class UserInterface
    {

        public static void PrintHeadMenu()
        {
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("Menú principal");
            System.Console.WriteLine("-----------------");

        }
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número");
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("6) Salir del programa");
        }
        public static int ReadMainMenuOption()
        {

            int option1;
            option1 = System.Convert.ToInt32(System.Console.ReadLine());
            return option1;
        }
    }
}
