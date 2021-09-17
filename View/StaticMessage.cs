using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlertApp.View
{
     class StaticMessage
     {
          public static void DisplayTitle()
          {
               string title = @"
                _   _      _           _    _ _                       
               | | | |    (_)         | |  | (_)                      
               | |_| | ___ _ _ __ ___ | |  | |_ _ __  ____            
               |  _  |/ _ \ | '_ ` _ \| |/\| | | '_ \|_  /            
               | | | |  __/ | | | | | \  /\  / | | | |/ /             
               \_| |_/\___|_|_| |_| |_|\/  \/|_|_| |_/___|            
                                                                 
                                                                 
     ______                           _              ___              
     |  _  \                         | |            / _ \             
     | | | |___  ___ _ __ _   _ _ __ | |_ ___  _ __/ /_\ \_ __  _ __  
     | | | / _ \/ __| '__| | | | '_ \| __/ _ \| '__|  _  | '_ \| '_ \ 
     | |/ /  __/ (__| |  | |_| | |_) | || (_) | |  | | | | |_) | |_) |
     |___/ \___|\___|_|   \__, | .__/ \__\___/|_|  \_| |_/ .__/| .__/ 
                           __/ | |                       | |   | |    
                          |___/|_|                       |_|   |_|    
                                             
                                                  by HeimWinz.com
               ";

               Console.WriteLine(title);
          }
     }
}
