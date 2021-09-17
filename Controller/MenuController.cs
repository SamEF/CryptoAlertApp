using CryptoAlertApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CryptoAlertApp.Controller
{
     public class MenuController
     {
          MenuView menuView;

          public MenuController()
          {
               menuView = new MenuView();
          }

          // ****************************************************************
          // 
          // ****************************************************************
          public void MainMenuPrompt()
          {
               try
               {
                    int choice;
                    do
                    {
                         Console.Clear();
                         menuView.MainMenu();
                         choice = Convert.ToInt32(Console.ReadLine());
                    } while (choice > 4 || choice < 1);

                    switch (choice)
                    {
                         case 1: // Run App
                              break;
                         case 2: // Options
                              OptionsMenuPrompt();
                              break;
                         case 3: // Credits
                              break;
                         case 4: // Exit
                              Environment.Exit(0);
                              break;
                    }
               } 
               catch (Exception e)
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Thread.Sleep(2000);
                    MainMenuPrompt();
               }
               
          }

          // ****************************************************************
          // 
          // ****************************************************************
          public void OptionsMenuPrompt()
          {
               try
               {
                    int choice;
                    do
                    {
                         Console.Clear();
                         menuView.OptionsMenu();
                         choice = Convert.ToInt32(Console.ReadLine());
                    } while (choice > 3 || choice < 1);

                    switch (choice)
                    {
                         case 1: // Alerts and Notifications
                              break;
                         case 2: // Edit Information File
                              break;
                         case 3:// Back to Main Menu
                              MainMenuPrompt();
                              break;
                    }
               }
               catch (Exception e)
               {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Thread.Sleep(2000);
                    OptionsMenuPrompt();
               }
          }

     }
}
