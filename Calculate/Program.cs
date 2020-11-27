using System;

namespace Calculate
{
    class Program
    {
            public static void Main(string[] arg)
            {
                for (; ; )
                {
                    UserInterface.PrintHeadMenu();
                    UserInterface.PrintMainMenu();
                    int option = UserInterface.ReadOption();
                    switch (option)
                    {
                        case 1:
                            ModelViewConsole.ManagePower2();
                            
                            break;
                        case 2:
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