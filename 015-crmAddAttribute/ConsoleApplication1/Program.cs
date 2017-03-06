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

            String schemaName = "customer_id_integer";

            Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest retrieveEntityRequest = new Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest();
            retrieveEntityRequest.RetrieveAsIfPublished = true;
            retrieveEntityRequest.LogicalName = "account";
            retrieveEntityRequest.EntityFilters = Microsoft.Xrm.Sdk.Metadata.EntityFilters.Attributes;

            Microsoft.Xrm.Sdk.Messages.RetrieveEntityResponse retrieveEntityResponse = (Microsoft.Xrm.Sdk.Messages.RetrieveEntityResponse)_orgService.Execute(retrieveEntityRequest);
            Microsoft.Xrm.Sdk.Metadata.EntityMetadata entityMetadata = retrieveEntityResponse.EntityMetadata;
            foreach (Microsoft.Xrm.Sdk.Metadata.AttributeMetadata attributeMetadata in entityMetadata.Attributes)
            {
                if (attributeMetadata.AttributeType != Microsoft.Xrm.Sdk.Metadata.AttributeTypeCode.Virtual)
                {
                    if( schemaName == attributeMetadata.SchemaName )
                    {
                        Console.WriteLine("Field already exists");
                        Environment.Exit(0);
                    }
                }
            }

            //English - United States
            int _languageCode = 1033;

            // Create a integer attribute	
            Microsoft.Xrm.Sdk.Metadata.IntegerAttributeMetadata integerAttribute = new Microsoft.Xrm.Sdk.Metadata.IntegerAttributeMetadata
            {
                // Set base properties
                SchemaName = schemaName,
                DisplayName = new Microsoft.Xrm.Sdk.Label("Customer Id", _languageCode),
                RequiredLevel = new Microsoft.Xrm.Sdk.Metadata.AttributeRequiredLevelManagedProperty(Microsoft.Xrm.Sdk.Metadata.AttributeRequiredLevel.None),
                Description = new Microsoft.Xrm.Sdk.Label("Integer Attribute", _languageCode),
                // Set extended properties
                Format = Microsoft.Xrm.Sdk.Metadata.IntegerFormat.None,
                MaxValue = 2147483647,
                MinValue = 0
            };

            Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest createAttributeRequest = new Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest
            {
                EntityName = "account",
                Attribute = integerAttribute
            };

            Microsoft.Xrm.Sdk.Messages.CreateAttributeResponse createAttributeResponse = (Microsoft.Xrm.Sdk.Messages.CreateAttributeResponse)_orgService.Execute(createAttributeRequest);
            Console.WriteLine("Attribute created:");
            dumpResults(createAttributeResponse.Results);

            Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest publishRequest = new Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest();
            Microsoft.Crm.Sdk.Messages.PublishAllXmlResponse publishAllXmlResponse = (Microsoft.Crm.Sdk.Messages.PublishAllXmlResponse)_orgService.Execute(publishRequest);
            Console.WriteLine("Published changes:");
            dumpResults(publishAllXmlResponse.Results);
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
