using CryptoAlertApp.Controller;
using CryptoAlertApp.Model;
using System;
using System.Collections.Generic;

namespace CryptoAlertApp
{
     class Program
     {
          static void Main(string[] args) { 
               
               //Init.Run();
               
                                  
               CoinbaseAnalytics coinbaseAnalytics = new CoinbaseAnalytics();
               coinbaseAnalytics.AlertFilter();
               
          }
     }
}
