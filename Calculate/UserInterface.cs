using System;
using System.Collections.Generic;
using System.Text;

namespace Calculate
{
    class UserInterface
    {

        public static void PrintPrimeNumber()
        {
            System.Console.WriteLine("---------------");
            System.Console.WriteLine("Série Fibonacci");
            System.Console.WriteLine("---------------");

        }
        /*Esta clase sirve para dar opociones e imprimir por pantalla
         MVC: Muestra el menu, lo lee y lo ejecuta*/
        public static void PrintHeader4()
        {
            System.Console.WriteLine("------------");
            System.Console.WriteLine("Número Primo");
            System.Console.WriteLine("------------");
            System.Console.WriteLine("Un número primo es un número entero mayor que cero, que tiene exactamente dos divisores positivos. " +
                "También podemos definirlo como aquel número que no puede expresarse como producto de dos números enteros positivos " +
                "más pequeños que él, o bien, como producto de dos enteros positivos de más de una forma. Conviene observar que con cualquiera de las " +
                "dos definiciones el 1 queda excluido del conjunto de los números primos.");
            System.Console.WriteLine("¿Cúal número quieres saber sí es primo o no? Teclealo");
        }
        public static void PrintHeader3()
        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Factorial de un número");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("La función factorial se representa con un signo de exclamación “!” detrás de un número.\n " +
                "Esta exclamación quiere decir que hay que multiplicar\n todos los números enteros positivos que hay entre ese número natural y el 1\n " +
                "también hay que tener en cuenta que el 0 en este caso tendrá un valor distinto.");
            System.Console.WriteLine("Teclea el número a factorizar");
        }
        public static void PrintHeader2()
        {
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("Sumatorio de un número");
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine("la operación de suma es un operador matemático \n que permite representar sumas de muchos sumandos, incluso infinitos sumandos");
            System.Console.WriteLine("Teclea el número que deseas sumar");
        }
        public static void PrintHeader1 ()
        {
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Potencia en base 2");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Una potencia es el resultado de multiplicar un número por sí mismo varias veces.\n El número que multiplicamos es la base," +
                " mientras que el número de veces que multiplicamos la base se llama exponente");
            System.Console.WriteLine("Introduce el número a calcular");
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
