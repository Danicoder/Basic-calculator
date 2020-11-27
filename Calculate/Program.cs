using System;

namespace Calculate
{
    class Program
    {
            public static void Main(string[] arg)
            {
                for (; ;)
                {
                    UserInterface.PrintMainMenu();
                    int option = Utils.ReadOption();
                    switch (option)
                    {
                        case 1:
                            System.Console.Clear();
                            UserInterface.PrintOption1();
                            int Number = Utils.ReadOption();
                            double Result = ModelViewConsole.ManagePower2(Number);
                            System.Console.WriteLine("El resultado es: "+ Result);
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            break;
                        case 2:
                            System.Console.Clear();
                            UserInterface.PrintSumatory();
                            int Option = Utils.ReadOption();
                            double TournOn = ModelViewConsole.ManageSumatory(Option);
                        System.Console.WriteLine("Teclea el número que deseas sumar");
                        int number = Utils.ReadOption();
                            ModelViewConsole.ManageSumatory();
                            break;
                        case 3:
                            ModelViewConsole.LaunchFactorialNumber();
                            break;
                        case 4:
                            ModelViewConsole.ManageIsPrime();
                            break;
                        case 0:
                            return;
                    }
                }
            }
    }
    
}