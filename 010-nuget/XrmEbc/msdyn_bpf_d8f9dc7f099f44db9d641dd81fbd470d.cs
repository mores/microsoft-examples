//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XrmEbc
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public enum msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470dState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Base entity for process Invoice Process
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ActiveStageId = "activestageid";
			public const string ActiveStageStartedOn = "activestagestartedon";
			public const string bpf_Duration = "bpf_duration";
			public const string bpf_invoiceid = "bpf_invoiceid";
			public const string bpf_name = "bpf_name";
			public const string BusinessProcessFlowInstanceId = "businessprocessflowinstanceid";
			public const string Id = "businessprocessflowinstanceid";
			public const string CompletedOn = "completedon";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessId = "processid";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TraversedPath = "traversedpath";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d = "bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d";
			public const string lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid = "lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid";
			public const string lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby = "lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby";
			public const string lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby = "lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby";
			public const string lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby = "lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby";
			public const string lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby = "lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby";
			public const string lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid = "lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid";
			public const string organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d = "organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d";
		
		public const int EntityTypeCode = 10098;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the active stage for the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		public Microsoft.Xrm.Sdk.EntityReference ActiveStageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activestageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageId");
				this.SetAttributeValue("activestageid", value);
				this.OnPropertyChanged("ActiveStageId");
			}
		}
		
		/// <summary>
		/// Date and time when current active stage is started
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestagestartedon")]
		public System.Nullable<System.DateTime> ActiveStageStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("activestagestartedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageStartedOn");
				this.SetAttributeValue("activestagestartedon", value);
				this.OnPropertyChanged("ActiveStageStartedOn");
			}
		}
		
		/// <summary>
		/// Duration of Business Process Flow
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_duration")]
		public System.Nullable<int> bpf_Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("bpf_duration");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_invoiceid")]
		public Microsoft.Xrm.Sdk.EntityReference bpf_invoiceid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bpf_invoiceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_invoiceid");
				this.SetAttributeValue("bpf_invoiceid", value);
				this.OnPropertyChanged("bpf_invoiceid");
			}
		}
		
		/// <summary>
		/// Description
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_name")]
		public string bpf_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("bpf_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_name");
				this.SetAttributeValue("bpf_name", value);
				this.OnPropertyChanged("bpf_name");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
		public System.Nullable<System.Guid> BusinessProcessFlowInstanceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessprocessflowinstanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessProcessFlowInstanceId");
				this.SetAttributeValue("businessprocessflowinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BusinessProcessFlowInstanceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.BusinessProcessFlowInstanceId = value;
			}
		}
		
		/// <summary>
		/// Date and time when Business Process Flow instance is completed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
		public System.Nullable<System.DateTime> CompletedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CompletedOn");
				this.SetAttributeValue("completedon", value);
				this.OnPropertyChanged("CompletedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public Microsoft.Xrm.Sdk.EntityReference ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Status of the Invoice Process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470dState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470dState)(System.Enum.ToObject(typeof(XrmEbc.msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470dState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("statecode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value.Value))));
				}
				this.OnPropertyChanged("statecode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Invoice Process
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public object statuscode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Comma delimited string of process stage ids that represent visited stages of the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs")]
		public System.Collections.Generic.IEnumerable<XrmEbc.WorkflowLog> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.WorkflowLog>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs");
				this.SetRelatedEntities<XrmEbc.WorkflowLog>("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs", null, value);
				this.OnPropertyChanged("msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_WorkflowLogs");
			}
		}
		
		/// <summary>
		/// N:1 bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bpf_invoiceid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d")]
		public XrmEbc.Invoice bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Invoice>("bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d");
				this.SetRelatedEntity<XrmEbc.Invoice>("bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d", null, value);
				this.OnPropertyChanged("bpf_invoice_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid")]
		public XrmEbc.ProcessStage lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.ProcessStage>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid");
				this.SetRelatedEntity<XrmEbc.ProcessStage>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_activestageid");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby")]
		public XrmEbc.SystemUser lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby")]
		public XrmEbc.SystemUser lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid")]
		public XrmEbc.Workflow lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Workflow>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid");
				this.SetRelatedEntity<XrmEbc.Workflow>("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid", null, value);
				this.OnPropertyChanged("lk_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_processid");
			}
		}
		
		/// <summary>
		/// N:1 organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d")]
		public XrmEbc.Organization organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["businessprocessflowinstanceid"] = base.Id;
                        break;
                    case "businessprocessflowinstanceid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}