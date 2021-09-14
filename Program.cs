using CryptoAlertApp.Model;
using System;

namespace CryptoAlertApp
{
     class Program
     {
          static void Main(string[] args)
          {
               UrlReader urlReader = new UrlReader();

               urlReader.GetAllStringInnerHtml("https://blog.coinbase.com/", "//body","/h3");
          }
     }
}
