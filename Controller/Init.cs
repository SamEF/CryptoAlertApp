using CryptoAlertApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlertApp.Controller
{
     public static class Init
     {
          static MenuController menuController;

          static Init()
          {
               menuController = new MenuController();
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WindowWidth = Console.LargestWindowWidth - 165;
               Console.WindowHeight = Console.LargestWindowHeight - 20;
          }

          public static void Run()
          {
               menuController.MainMenuPrompt();
          }
     }
}
