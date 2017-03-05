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
	public enum msdyn_projectpricelistState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_projectpricelist")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class msdyn_projectpricelist : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_description = "msdyn_description";
			public const string msdyn_PriceList = "msdyn_pricelist";
			public const string msdyn_Project = "msdyn_project";
			public const string msdyn_projectpricelistId = "msdyn_projectpricelistid";
			public const string Id = "msdyn_projectpricelistid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_msdyn_projectpricelist = "business_unit_msdyn_projectpricelist";
			public const string lk_msdyn_projectpricelist_createdby = "lk_msdyn_projectpricelist_createdby";
			public const string lk_msdyn_projectpricelist_createdonbehalfby = "lk_msdyn_projectpricelist_createdonbehalfby";
			public const string lk_msdyn_projectpricelist_modifiedby = "lk_msdyn_projectpricelist_modifiedby";
			public const string lk_msdyn_projectpricelist_modifiedonbehalfby = "lk_msdyn_projectpricelist_modifiedonbehalfby";
			public const string msdyn_msdyn_project_msdyn_projectpricelist_Project = "msdyn_msdyn_project_msdyn_projectpricelist_Project";
			public const string msdyn_pricelevel_msdyn_projectpricelist_PriceList = "msdyn_pricelevel_msdyn_projectpricelist_PriceList";
			public const string team_msdyn_projectpricelist = "team_msdyn_projectpricelist";
			public const string user_msdyn_projectpricelist = "user_msdyn_projectpricelist";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_projectpricelist() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_projectpricelist";
		
		public const int EntityTypeCode = 10068;
		
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
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_description")]
		public string msdyn_description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_description");
				this.SetAttributeValue("msdyn_description", value);
				this.OnPropertyChanged("msdyn_description");
			}
		}
		
		/// <summary>
		/// Shows the name of the project price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_pricelist")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_PriceList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_pricelist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_PriceList");
				this.SetAttributeValue("msdyn_pricelist", value);
				this.OnPropertyChanged("msdyn_PriceList");
			}
		}
		
		/// <summary>
		/// Shows the project for the project price list.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_project")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_Project
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_project");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_Project");
				this.SetAttributeValue("msdyn_project", value);
				this.OnPropertyChanged("msdyn_Project");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectpricelistid")]
		public System.Nullable<System.Guid> msdyn_projectpricelistId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_projectpricelistid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelistId");
				this.SetAttributeValue("msdyn_projectpricelistid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_projectpricelistId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectpricelistid")]
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
				this.msdyn_projectpricelistId = value;
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
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Project Price List
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.msdyn_projectpricelistState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.msdyn_projectpricelistState)(System.Enum.ToObject(typeof(XrmEbc.msdyn_projectpricelistState), optionSet.Value)));
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
		/// Reason for the status of the Project Price List
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
		/// 1:N msdyn_projectpricelist_Annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_Annotations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Annotation> msdyn_projectpricelist_Annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Annotation>("msdyn_projectpricelist_Annotations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_Annotations");
				this.SetRelatedEntities<XrmEbc.Annotation>("msdyn_projectpricelist_Annotations", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_Annotations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> msdyn_projectpricelist_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_projectpricelist_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_projectpricelist_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> msdyn_projectpricelist_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_projectpricelist_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_projectpricelist_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_projectpricelist_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectpricelist_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_DuplicateBaseRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectpricelist_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_projectpricelist_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectpricelist_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_DuplicateMatchingRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectpricelist_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> msdyn_projectpricelist_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_projectpricelist_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_projectpricelist_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> msdyn_projectpricelist_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_projectpricelist_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_projectpricelist_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> msdyn_projectpricelist_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("msdyn_projectpricelist_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("msdyn_projectpricelist_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> msdyn_projectpricelist_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("msdyn_projectpricelist_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("msdyn_projectpricelist_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectpricelist_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectpricelist_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> msdyn_projectpricelist_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_projectpricelist_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectpricelist_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_projectpricelist_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_projectpricelist_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_msdyn_projectpricelist
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_projectpricelist")]
		public XrmEbc.BusinessUnit business_unit_msdyn_projectpricelist
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BusinessUnit>("business_unit_msdyn_projectpricelist", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectpricelist_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectpricelist_createdby")]
		public XrmEbc.SystemUser lk_msdyn_projectpricelist_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectpricelist_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectpricelist_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectpricelist_createdonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_projectpricelist_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectpricelist_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_projectpricelist_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectpricelist_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_projectpricelist_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectpricelist_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectpricelist_modifiedby")]
		public XrmEbc.SystemUser lk_msdyn_projectpricelist_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectpricelist_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectpricelist_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectpricelist_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_projectpricelist_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectpricelist_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_projectpricelist_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectpricelist_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_projectpricelist_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_msdyn_project_msdyn_projectpricelist_Project
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_project")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_project_msdyn_projectpricelist_Project")]
		public XrmEbc.msdyn_project msdyn_msdyn_project_msdyn_projectpricelist_Project
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.msdyn_project>("msdyn_msdyn_project_msdyn_projectpricelist_Project", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_project_msdyn_projectpricelist_Project");
				this.SetRelatedEntity<XrmEbc.msdyn_project>("msdyn_msdyn_project_msdyn_projectpricelist_Project", null, value);
				this.OnPropertyChanged("msdyn_msdyn_project_msdyn_projectpricelist_Project");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_pricelevel_msdyn_projectpricelist_PriceList
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_pricelist")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_pricelevel_msdyn_projectpricelist_PriceList")]
		public XrmEbc.PriceLevel msdyn_pricelevel_msdyn_projectpricelist_PriceList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.PriceLevel>("msdyn_pricelevel_msdyn_projectpricelist_PriceList", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_pricelevel_msdyn_projectpricelist_PriceList");
				this.SetRelatedEntity<XrmEbc.PriceLevel>("msdyn_pricelevel_msdyn_projectpricelist_PriceList", null, value);
				this.OnPropertyChanged("msdyn_pricelevel_msdyn_projectpricelist_PriceList");
			}
		}
		
		/// <summary>
		/// N:1 team_msdyn_projectpricelist
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_projectpricelist")]
		public XrmEbc.Team team_msdyn_projectpricelist
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Team>("team_msdyn_projectpricelist", null);
			}
		}
		
		/// <summary>
		/// N:1 user_msdyn_projectpricelist
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_projectpricelist")]
		public XrmEbc.SystemUser user_msdyn_projectpricelist
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("user_msdyn_projectpricelist", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_projectpricelist(object anonymousType) : 
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
                        Attributes["msdyn_projectpricelistid"] = base.Id;
                        break;
                    case "msdyn_projectpricelistid":
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