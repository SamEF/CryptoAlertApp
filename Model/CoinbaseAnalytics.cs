using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoAlertApp.Model
{
     public class CoinbaseAnalytics
     {
          private UrlReader urlReader;

          public CoinbaseAnalytics()
          {
               this.urlReader = new UrlReader();
          }

          private List<string> GetLatestNews()
          {
               return urlReader.GetAllStringInnerHtml("https://blog.coinbase.com/latest", "//div", "/h3");
          }

          private List<string> GetTrendingNews()
          {
               return urlReader.GetAllStringInnerHtml("https://blog.coinbase.com/trending", "//div", "/h3");
          }

          public void AlertFilter()
          {
               try
               {
                    List<string> latestNews = GetLatestNews();
                    List<string> alreadyAlerted = new List<string>();
                    const Int32 BufferSize = 128;

                    using (var fileStream = File.OpenRead("C:\\Users\\Sami\\source\\repos\\CryptoAlertApp\\Model\\CoinbaseNewsTitleDump.txt"))
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                    {
                         String line;
                         while ((line = streamReader.ReadLine()) != null)
                         {
                              alreadyAlerted.Add(line);
                         }
                    }
                   
                    
                    foreach (var x in latestNews)
                    {
                         if ((x.Contains("available") || x.Contains("launching")) && !alreadyAlerted.Contains(x))
                         {
                              Console.WriteLine(x);
                              File.AppendAllText("C:\\Users\\Sami\\source\\repos\\CryptoAlertApp\\Model\\CoinbaseNewsTitleDump.txt", DateTime.Now + x + Environment.NewLine);
                         }
                              
                    }
                    
               }
               catch(Exception e)
               {
                    Console.WriteLine(e);
               }
          }
     }
}
