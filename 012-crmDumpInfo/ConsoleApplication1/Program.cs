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

            Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest retrieveEntityRequest = new Microsoft.Xrm.Sdk.Messages.RetrieveEntityRequest();
            retrieveEntityRequest.RetrieveAsIfPublished = true;
            retrieveEntityRequest.LogicalName = "account";
            retrieveEntityRequest.EntityFilters = Microsoft.Xrm.Sdk.Metadata.EntityFilters.Attributes;

            Microsoft.Xrm.Sdk.Messages.RetrieveEntityResponse resp = (Microsoft.Xrm.Sdk.Messages.RetrieveEntityResponse)_orgService.Execute(retrieveEntityRequest);
            Microsoft.Xrm.Sdk.Metadata.EntityMetadata em = resp.EntityMetadata;
            foreach (Microsoft.Xrm.Sdk.Metadata.AttributeMetadata attributeType in em.Attributes)
            {
                if (attributeType.AttributeType != Microsoft.Xrm.Sdk.Metadata.AttributeTypeCode.Virtual)
                {
                    String schemaName = attributeType.SchemaName;
                    Guid id = attributeType.MetadataId.Value;
                    String type = attributeType.AttributeType.HasValue ? attributeType.AttributeType.Value.ToString() : string.Empty;
                    String name = attributeType.DisplayName.UserLocalizedLabel != null ? attributeType.DisplayName.UserLocalizedLabel.Label : string.Empty;
                    String logicalName = attributeType.LogicalName != null ? attributeType.LogicalName : string.Empty;

                    Console.WriteLine("Entity Field: " + schemaName + "\t" + id + "\t" + type + "\t" + name + "\t" + logicalName);

                }
            }

            // Retrieve Views
            Microsoft.Xrm.Sdk.Query.QueryExpression mySavedQuery = new Microsoft.Xrm.Sdk.Query.QueryExpression
            {
                ColumnSet = new Microsoft.Xrm.Sdk.Query.ColumnSet("savedqueryid", "name", "querytype", "isdefault", "returnedtypecode", "isquickfindquery", "fetchxml", "layoutxml"),
                EntityName = XrmEbc.SavedQuery.EntityLogicalName,
                Criteria = new Microsoft.Xrm.Sdk.Query.FilterExpression
                {
                    Conditions =
                    {
                        new Microsoft.Xrm.Sdk.Query.ConditionExpression
                        {
                         AttributeName = "querytype",
                            Operator = Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal,
                            Values = {0}
                        },
                        new Microsoft.Xrm.Sdk.Query.ConditionExpression
                        {
                            AttributeName = "returnedtypecode",
                            Operator = Microsoft.Xrm.Sdk.Query.ConditionOperator.Equal,
                            Values = { XrmEbc.Account.EntityTypeCode}
                        }
                    }
                }
            };

            Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest retrieveSavedQueriesRequest = new Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest { Query = mySavedQuery };
            Microsoft.Xrm.Sdk.Messages.RetrieveMultipleResponse retrieveSavedQueriesResponse = (Microsoft.Xrm.Sdk.Messages.RetrieveMultipleResponse)_orgService.Execute(retrieveSavedQueriesRequest);

            Microsoft.Xrm.Sdk.DataCollection<Microsoft.Xrm.Sdk.Entity> savedQueries = retrieveSavedQueriesResponse.EntityCollection.Entities;
            //Display the Retrieved views
            foreach (Microsoft.Xrm.Sdk.Entity ent in savedQueries)
            {
                XrmEbc.SavedQuery rsq = (XrmEbc.SavedQuery)ent;
                Console.WriteLine("{0} : {1} : {2} : {3} : {4} : {5}", rsq.SavedQueryId, rsq.Name, rsq.QueryType, rsq.IsDefault, rsq.ReturnedTypeCode, rsq.IsQuickFindQuery);
                Console.WriteLine("\t{0}", rsq.FetchXml );
                Console.WriteLine("\t{0}", rsq.LayoutXml);
            }       
        }
    }
}
