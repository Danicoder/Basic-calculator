using System;

namespace Calculate
{
    class Program
    {
            public static void Main(string[] arg)
            {
                UserInterface.PrintHeadMenu();
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMainMenuOption();
                switch (option)
                {
                    case 1:
                            ModelViewConsole.Power2();
                        break;
                    case 2:
                            ModelViewConsole.ManageSumatory();
                        break;
                }
            }
    }
    
}