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

            String _customEntityName = "custom_entity";

            Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest retrieveEntityRequest = new Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest();
            retrieveEntityRequest.RetrieveAsIfPublished = true;
            retrieveEntityRequest.LogicalName = _customEntityName;
            retrieveEntityRequest.EntityFilters = Microsoft.Xrm.Sdk.Metadata.EntityFilters.Attributes;

            //English - United States
            int _languageCode = 1033;

            try
            {
                Microsoft.Xrm.Sdk.Messages.RetrieveEntityResponse retrieveEntityResponse = (Microsoft.Xrm.Sdk.Messages.RetrieveEntityResponse)_orgService.Execute(retrieveEntityRequest);
            }
            catch (System.ServiceModel.FaultException faultException)
            {

                if (faultException.Message.Contains("Could not find an entity with specified entity name"))
                {
                    Console.WriteLine("Good to create the custom entity");

                    Microsoft.Xrm.Sdk.Messages.CreateEntityRequest createrequest = new Microsoft.Xrm.Sdk.Messages.CreateEntityRequest
                    {

                        //Define the entity
                        Entity = new Microsoft.Xrm.Sdk.Metadata.EntityMetadata
                        {
                            SchemaName = _customEntityName,
                            DisplayName = new Microsoft.Xrm.Sdk.Label("Bank Account", _languageCode),
                            DisplayCollectionName = new Microsoft.Xrm.Sdk.Label("Bank Accounts", _languageCode),
                            Description = new Microsoft.Xrm.Sdk.Label("An entity to store information about customer bank accounts", _languageCode),
                            OwnershipType = Microsoft.Xrm.Sdk.Metadata.OwnershipTypes.UserOwned,
                            IsActivity = false,

                        },

                        // Define the primary attribute for the entity
                        PrimaryAttribute = new Microsoft.Xrm.Sdk.Metadata.StringAttributeMetadata
                        {
                            SchemaName = "new_accountname",
                            RequiredLevel = new Microsoft.Xrm.Sdk.Metadata.AttributeRequiredLevelManagedProperty(Microsoft.Xrm.Sdk.Metadata.AttributeRequiredLevel.None),
                            MaxLength = 100,
                            FormatName = Microsoft.Xrm.Sdk.Metadata.StringFormatName.Text,
                            DisplayName = new Microsoft.Xrm.Sdk.Label("Account Name", _languageCode),
                            Description = new Microsoft.Xrm.Sdk.Label("The primary attribute for the Bank Account entity.", _languageCode)
                        }

                    };
                    Microsoft.Xrm.Sdk.Messages.CreateEntityResponse createEntityResponse = (Microsoft.Xrm.Sdk.Messages.CreateEntityResponse)_orgService.Execute(createrequest);
                    Console.WriteLine("The bank account entity has been created.");
                    dumpResults(createEntityResponse.Results);

                    Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest publishRequest = new Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest();
                    Microsoft.Crm.Sdk.Messages.PublishAllXmlResponse publishAllXmlResponse = (Microsoft.Crm.Sdk.Messages.PublishAllXmlResponse)_orgService.Execute(publishRequest);
                    Console.WriteLine("Published changes:");
                    dumpResults(publishAllXmlResponse.Results);
                }
                else
                {
                    Console.WriteLine("Exception: " + faultException.Message);
                }
            }
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
