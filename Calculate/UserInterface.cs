using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class UserInterface
    {

        public static void PrintPrimeNumber()
        {
            System.Console.WriteLine("------------");
            System.Console.WriteLine("Série Fibonacci");
            System.Console.WriteLine("------------");

        }
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
            //esplicar la potencia ne base dos
            System.Console.WriteLine("Introduce un número");
        }
        /*Como para la mayoria de los casos son números naturales utilizamos int*/
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Menú principal");
            System.Console.WriteLine("--------------");

            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número"); 
            System.Console.WriteLine("4) Saber si un número es primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir del programa");
        }
        
    }
}
