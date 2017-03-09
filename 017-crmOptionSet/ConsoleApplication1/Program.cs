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
        static Microsoft.Xrm.Sdk.IOrganizationService _orgService;

        static void Main(string[] args)
        {
            String url = "";
            String user = "";
            String password = "";

            Console.WriteLine("Hello, World!");
            String connectionString = "Url=" + url + "; Username=" + user + "; Password=" + password + "; authtype=Office365";
            Microsoft.Xrm.Tooling.Connector.CrmServiceClient conn = new Microsoft.Xrm.Tooling.Connector.CrmServiceClient(connectionString);
            _orgService = (Microsoft.Xrm.Sdk.IOrganizationService)conn.OrganizationWebProxyClient != null ? (Microsoft.Xrm.Sdk.IOrganizationService)conn.OrganizationWebProxyClient : (Microsoft.Xrm.Sdk.IOrganizationService)conn.OrganizationServiceProxy;
            Guid userid = ((Microsoft.Crm.Sdk.Messages.WhoAmIResponse)_orgService.Execute(new Microsoft.Crm.Sdk.Messages.WhoAmIRequest())).UserId;
            Console.WriteLine("GUID {0}.", userid);
            XrmEbc.SystemUser systemUser = (XrmEbc.SystemUser)_orgService.Retrieve("systemuser", userid, new Microsoft.Xrm.Sdk.Query.ColumnSet(new string[] { "firstname", "lastname" }));
            Console.WriteLine("Logged on user is {0} {1}.", systemUser.FirstName, systemUser.LastName);

            Microsoft.Crm.Sdk.Messages.RetrieveVersionRequest versionRequest = new Microsoft.Crm.Sdk.Messages.RetrieveVersionRequest();
            Microsoft.Crm.Sdk.Messages.RetrieveVersionResponse versionResponse = (Microsoft.Crm.Sdk.Messages.RetrieveVersionResponse)_orgService.Execute(versionRequest);
            Console.WriteLine("Microsoft Dynamics CRM version {0}.", versionResponse.Version);

            Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest objRetrieveAttributeRequest = new Microsoft.Xrm.Sdk.Messages.RetrieveAttributeRequest();
            objRetrieveAttributeRequest.EntityLogicalName = "account";
            objRetrieveAttributeRequest.LogicalName = "customertypecode";

            // Execute the request       
            Microsoft.Xrm.Sdk.Messages.RetrieveAttributeResponse retrieveAttributeResponse = (Microsoft.Xrm.Sdk.Messages.RetrieveAttributeResponse)_orgService.Execute(objRetrieveAttributeRequest);

            Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata retrievedPicklistAttributeMetadata = (Microsoft.Xrm.Sdk.Metadata.PicklistAttributeMetadata)retrieveAttributeResponse.AttributeMetadata;
            Microsoft.Xrm.Sdk.Metadata.OptionMetadataCollection optionList = retrievedPicklistAttributeMetadata.OptionSet.Options;
            foreach(Microsoft.Xrm.Sdk.Metadata.OptionMetadata optionMetadata in optionList )
            {
                int value = (int)optionMetadata.Value;
                Console.WriteLine("Option: " + optionMetadata.Label.UserLocalizedLabel.Label.ToString() + " " + value );
                Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest deleteRequest = new Microsoft.Xrm.Sdk.Messages.DeleteOptionValueRequest
                {
                    AttributeLogicalName = "customertypecode",
                    EntityLogicalName = "account",
                    Value = value
                };
                Microsoft.Xrm.Sdk.Messages.DeleteOptionValueResponse deleteOptionValueResponse = (Microsoft.Xrm.Sdk.Messages.DeleteOptionValueResponse)_orgService.Execute(deleteRequest);
            }

            addOption("Commercial", 1);
            addOption("Government", 2);
            addOption("Industrial", 3);
            addOption("Institutional", 4);
            addOption("Low Income", 5);
            addOption("Non Profit", 6);

            Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest publishRequest = new Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest();
            Microsoft.Crm.Sdk.Messages.PublishAllXmlResponse publishAllXmlResponse = (Microsoft.Crm.Sdk.Messages.PublishAllXmlResponse)_orgService.Execute(publishRequest);
            Console.WriteLine("Published changes:");
            dumpResults(publishAllXmlResponse.Results);

        }

        static void addOption( String label, int value )
        {
            Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest insertStatusValueRequest = new Microsoft.Xrm.Sdk.Messages.InsertStatusValueRequest
            {
                AttributeLogicalName = "customertypecode",
                EntityLogicalName = XrmEbc.Account.EntityLogicalName,
                Label = new Microsoft.Xrm.Sdk.Label(label, 1033),
                Value = value
            };

            Microsoft.Xrm.Sdk.Messages.InsertStatusValueResponse insertStatusValueResponse = (Microsoft.Xrm.Sdk.Messages.InsertStatusValueResponse)_orgService.Execute(insertStatusValueRequest);
            Console.WriteLine("inserted");
            dumpResults(insertStatusValueResponse.Results);
        }

        static void dumpResults(Microsoft.Xrm.Sdk.ParameterCollection parameterCollection)
        {
            using (var sequenceEnum = parameterCollection.GetEnumerator())
            {
                while (sequenceEnum.MoveNext())
                {
                    Console.WriteLine("\tKey: " + sequenceEnum.Current.Key);
                    Console.WriteLine("\tValue: " + sequenceEnum.Current.Value);
                }
            }
        }
    }
}
