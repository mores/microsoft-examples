using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * First do this:
 * 010-nuget
 */

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "";
            String user = "";
            String password = "";

            Console.WriteLine("Hello, World!");
            String connectionString = "Url=" + url + "; Username=" + user + "; Password=" + password + "; authtype=Office365";
            Microsoft.Xrm.Tooling.Connector.CrmServiceClient conn = new Microsoft.Xrm.Tooling.Connector.CrmServiceClient(connectionString);
            Microsoft.Xrm.Sdk.IOrganizationService _orgService = (Microsoft.Xrm.Sdk.IOrganizationService)conn.OrganizationWebProxyClient != null ? (Microsoft.Xrm.Sdk.IOrganizationService)conn.OrganizationWebProxyClient : (Microsoft.Xrm.Sdk.IOrganizationService)conn.OrganizationServiceProxy;
            Guid userid = ((Microsoft.Crm.Sdk.Messages.WhoAmIResponse)_orgService.Execute(new Microsoft.Crm.Sdk.Messages.WhoAmIRequest())).UserId;
            Console.WriteLine("GUID {0}.", userid);
            XrmEbc.SystemUser systemUser = (XrmEbc.SystemUser)_orgService.Retrieve("systemuser", userid, new Microsoft.Xrm.Sdk.Query.ColumnSet(new string[] { "firstname", "lastname" }));
            Console.WriteLine("Logged on user is {0} {1}.", systemUser.FirstName, systemUser.LastName);

            Microsoft.Crm.Sdk.Messages.RetrieveVersionRequest versionRequest = new Microsoft.Crm.Sdk.Messages.RetrieveVersionRequest();
            Microsoft.Crm.Sdk.Messages.RetrieveVersionResponse versionResponse = (Microsoft.Crm.Sdk.Messages.RetrieveVersionResponse)_orgService.Execute(versionRequest);
            Console.WriteLine("Microsoft Dynamics CRM version {0}.", versionResponse.Version);
        }
    }
}
