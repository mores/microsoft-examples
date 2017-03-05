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
	public enum msdyn_requirementresourcecategoryState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Requirement Resource Category
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_requirementresourcecategory")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class msdyn_requirementresourcecategory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
			public const string msdyn_isprimary = "msdyn_isprimary";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_requirementresourcecategoryId = "msdyn_requirementresourcecategoryid";
			public const string Id = "msdyn_requirementresourcecategoryid";
			public const string msdyn_ResourceCategory = "msdyn_resourcecategory";
			public const string msdyn_ResourceRequirement = "msdyn_resourcerequirement";
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
			public const string business_unit_msdyn_requirementresourcecategory = "business_unit_msdyn_requirementresourcecategory";
			public const string lk_msdyn_requirementresourcecategory_createdby = "lk_msdyn_requirementresourcecategory_createdby";
			public const string lk_msdyn_requirementresourcecategory_createdonbehalfby = "lk_msdyn_requirementresourcecategory_createdonbehalfby";
			public const string lk_msdyn_requirementresourcecategory_modifiedby = "lk_msdyn_requirementresourcecategory_modifiedby";
			public const string lk_msdyn_requirementresourcecategory_modifiedonbehalfby = "lk_msdyn_requirementresourcecategory_modifiedonbehalfby";
			public const string msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory = "msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory";
			public const string msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement = "msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement";
			public const string team_msdyn_requirementresourcecategory = "team_msdyn_requirementresourcecategory";
			public const string user_msdyn_requirementresourcecategory = "user_msdyn_requirementresourcecategory";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_requirementresourcecategory() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_requirementresourcecategory";
		
		public const int EntityTypeCode = 10015;
		
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
		/// Yes if resource category requirement is primary. If it's primary then it can't be deleted
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isprimary")]
		public System.Nullable<bool> msdyn_isprimary
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isprimary");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_isprimary");
				this.SetAttributeValue("msdyn_isprimary", value);
				this.OnPropertyChanged("msdyn_isprimary");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_name")]
		public string msdyn_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_name");
				this.SetAttributeValue("msdyn_name", value);
				this.OnPropertyChanged("msdyn_name");
			}
		}
		
		/// <summary>
		/// A unique identifier for an entity instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_requirementresourcecategoryid")]
		public System.Nullable<System.Guid> msdyn_requirementresourcecategoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_requirementresourcecategoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategoryId");
				this.SetAttributeValue("msdyn_requirementresourcecategoryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_requirementresourcecategoryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_requirementresourcecategoryid")]
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
				this.msdyn_requirementresourcecategoryId = value;
			}
		}
		
		/// <summary>
		/// Resource Category
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcecategory")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ResourceCategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_resourcecategory");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_ResourceCategory");
				this.SetAttributeValue("msdyn_resourcecategory", value);
				this.OnPropertyChanged("msdyn_ResourceCategory");
			}
		}
		
		/// <summary>
		/// Resource Requirement
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcerequirement")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_ResourceRequirement
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_resourcerequirement");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_ResourceRequirement");
				this.SetAttributeValue("msdyn_resourcerequirement", value);
				this.OnPropertyChanged("msdyn_ResourceRequirement");
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
		/// Status of the Requirement Resource Category
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.msdyn_requirementresourcecategoryState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.msdyn_requirementresourcecategoryState)(System.Enum.ToObject(typeof(XrmEbc.msdyn_requirementresourcecategoryState), optionSet.Value)));
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
		/// Reason for the status of the Requirement Resource Category
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
		/// 1:N msdyn_requirementresourcecategory_Annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_Annotations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Annotation> msdyn_requirementresourcecategory_Annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Annotation>("msdyn_requirementresourcecategory_Annotations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_Annotations");
				this.SetRelatedEntities<XrmEbc.Annotation>("msdyn_requirementresourcecategory_Annotations", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_Annotations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> msdyn_requirementresourcecategory_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_requirementresourcecategory_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_requirementresourcecategory_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> msdyn_requirementresourcecategory_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_requirementresourcecategory_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_requirementresourcecategory_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_requirementresourcecategory_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_requirementresourcecategory_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_DuplicateBaseRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_requirementresourcecategory_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_requirementresourcecategory_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_requirementresourcecategory_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_DuplicateMatchingRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_requirementresourcecategory_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> msdyn_requirementresourcecategory_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_requirementresourcecategory_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_requirementresourcecategory_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> msdyn_requirementresourcecategory_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("msdyn_requirementresourcecategory_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("msdyn_requirementresourcecategory_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> msdyn_requirementresourcecategory_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("msdyn_requirementresourcecategory_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("msdyn_requirementresourcecategory_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_requirementresourcecategory_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_requirementresourcecategory_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> msdyn_requirementresourcecategory_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_requirementresourcecategory_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_requirementresourcecategory_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_requirementresourcecategory_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_requirementresourcecategory_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_msdyn_requirementresourcecategory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_requirementresourcecategory")]
		public XrmEbc.BusinessUnit business_unit_msdyn_requirementresourcecategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BusinessUnit>("business_unit_msdyn_requirementresourcecategory", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_requirementresourcecategory_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_requirementresourcecategory_createdby")]
		public XrmEbc.SystemUser lk_msdyn_requirementresourcecategory_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_requirementresourcecategory_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_requirementresourcecategory_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_requirementresourcecategory_createdonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_requirementresourcecategory_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_requirementresourcecategory_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_requirementresourcecategory_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_requirementresourcecategory_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_requirementresourcecategory_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_requirementresourcecategory_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_requirementresourcecategory_modifiedby")]
		public XrmEbc.SystemUser lk_msdyn_requirementresourcecategory_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_requirementresourcecategory_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_requirementresourcecategory_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_requirementresourcecategory_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_requirementresourcecategory_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_requirementresourcecategory_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_requirementresourcecategory_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_requirementresourcecategory_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_requirementresourcecategory_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcecategory")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory")]
		public XrmEbc.BookableResourceCategory msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BookableResourceCategory>("msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory");
				this.SetRelatedEntity<XrmEbc.BookableResourceCategory>("msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory", null, value);
				this.OnPropertyChanged("msdyn_bookableresourcecategory_requirementresourcecategory_ResourceCategory");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcerequirement")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement")]
		public XrmEbc.msdyn_resourcerequirement msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.msdyn_resourcerequirement>("msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement");
				this.SetRelatedEntity<XrmEbc.msdyn_resourcerequirement>("msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirement_requirementresourcecategory_resourcerequirement");
			}
		}
		
		/// <summary>
		/// N:1 team_msdyn_requirementresourcecategory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_requirementresourcecategory")]
		public XrmEbc.Team team_msdyn_requirementresourcecategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Team>("team_msdyn_requirementresourcecategory", null);
			}
		}
		
		/// <summary>
		/// N:1 user_msdyn_requirementresourcecategory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_requirementresourcecategory")]
		public XrmEbc.SystemUser user_msdyn_requirementresourcecategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("user_msdyn_requirementresourcecategory", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_requirementresourcecategory(object anonymousType) : 
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
                        Attributes["msdyn_requirementresourcecategoryid"] = base.Id;
                        break;
                    case "msdyn_requirementresourcecategoryid":
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