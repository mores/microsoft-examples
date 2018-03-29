/*
 * http://www.thesharepointguide.com/access-office-365-using-a-console-application/
 * 
 * nuget:
 *   AppForSharePointOnlineWebToolkit
 */

using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftSharePointClientWebConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri siteUri = new Uri("<enter url of sharepoint site here>");
            string realm = TokenHelper.GetRealmFromTargetUrl(siteUri);
            Console.WriteLine("...");
            Console.WriteLine(realm);

            string accessToken = TokenHelper.GetAppOnlyAccessToken(TokenHelper.SharePointPrincipal, siteUri.Authority, realm).AccessToken;
            Console.WriteLine("...");
            Console.WriteLine(accessToken);
            Console.WriteLine("...");

            using (var clientContext = TokenHelper.GetClientContextWithAccessToken(siteUri.ToString(), accessToken))
            {
                Web currentWeb = clientContext.Web;
                clientContext.Load(currentWeb, w => w.Title, w => w.Description);
                clientContext.ExecuteQuery();
                Console.WriteLine(currentWeb.Title);
                Console.WriteLine(currentWeb.Description);
            }
            
            Console.WriteLine("...");
            Console.ReadLine();
        }
    }
}
