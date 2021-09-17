using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlertApp.View
{
     public class MenuView
     {
          public void MainMenu()
          {
               StaticMessage.DisplayTitle();
               string title = @"
                    1. Run DecrypTorApp
                    2. Options
                    3. Credits
                    4. Exit
               ";
               Console.WriteLine(title);
          }

          public void OptionsMenu()
          {
               StaticMessage.DisplayTitle();
               string title = @"
                    1. Alerts and Notifications
                    2. Edit Information File
                    3. Back to Main Menu
               ";
               Console.WriteLine(title);
          }
     }
}
