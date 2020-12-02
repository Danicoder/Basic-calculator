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
                    int option = Utils.ReadInteger();
                    switch (option)
                    {
                        case 1:
                            System.Console.Clear();
                            UserInterface.PrintHeader1();
                            int NumberUser = Utils.ReadInteger();
                            double RiseTo = ModelViewConsole.LaunchPower2(NumberUser);
                            System.Console.WriteLine("El resultado de "+ NumberUser + " = " + RiseTo);
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            break;
                        case 2:
                            System.Console.Clear();
                            UserInterface.PrintHeader2();
                            int OnlyOneNumber = Utils.ReadInteger();
                            int Result = ModelViewConsole.GiveSumatory(OnlyOneNumber);
                            System.Console.WriteLine("El resultado de " + OnlyOneNumber + " = " + Result);
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            break;
                        case 3:
                            System.Console.Clear();
                            UserInterface.PrintHeader3();
                            int UserOption = Utils.ReadInteger();
                            if (UserOption < 0) 
                                System.Console.Write("No se puede calcular el factorial de un número negativo");
                            if (UserOption == 0)
                                System.Console.Write("0! = 1");
                            else
                            {
                                double GiveAnswer = ModelViewConsole.LaunchFactorialNumber(UserOption);
                                System.Console.Write("x" + GiveAnswer);
                                System.Console.WriteLine("El resultado de " + UserOption + " = " + GiveAnswer);
                            }
                            System.Console.WriteLine("Teclea intro para ir al menu principal");
                            System.Console.ReadLine();
                            break;
                        case 4:
                            System.Console.Clear();
                            UserInterface.PrintHeader3(); 
                            int RequestUser = Utils.ReadInteger();
                            ModelViewConsole.LaunchIsPrime(RequestUser);
                            break;
                        case 0:
                            return;
                    }
                }
            }
    }
    
}