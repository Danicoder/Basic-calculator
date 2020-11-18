using System;

namespace Calculate
{
    class Program
    {
            public static void Main(string[] args)
            {
                UserInterface.PrintHeadMenu();
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMainMenuOption();
                switch (option)
                {
                    case 1:
                        ModelViewConsole.Power2();
                        break;
                }
            }
    }
    
}