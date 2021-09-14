using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace CryptoAlertApp.Model
{
     public class UrlReader
     {
          private string GetSourceFromURL(string url)
          {
               using (WebClient client = new WebClient())
               {
                    client.Headers.Add("User-Agent: Other");
                    string htmlCode = client.DownloadString(url);

                    return htmlCode;
               }
          }

          //
          // Example:
          // url = www.blog.coinbase.com | node = //a | attribute = href
          public List<string> GetAllStringNodes(string url, string node, string attribute)
          {
               List<string> response = new List<string>();
               HtmlDocument htmlDoc = new HtmlDocument();
               htmlDoc.LoadHtml(GetSourceFromURL(url));

               var result = htmlDoc.DocumentNode.SelectNodes(node);

               foreach (var x in result)
               {    
                    response.Add(x.Attributes[attribute].Value);
               }

               return response;
          }

          //
          // Gets the text between the start and end tags of the object.
          // Example:
          // url = www.blog.coinbase.com | node = //body | attribute = /h1
          public void GetAllStringInnerHtml(string url, string node, string tag)
          {
               List<string> response = new List<string>();
               HtmlDocument htmlDoc = new HtmlDocument();
               htmlDoc.LoadHtml(GetSourceFromURL(url));

               var result = htmlDoc.DocumentNode.SelectNodes(node + tag);

               foreach (var x in result)
               {
                    //response.Add(x.InnerText);
                    Console.WriteLine(x.InnerText);
               }

               //return response;
          }
     }
}
