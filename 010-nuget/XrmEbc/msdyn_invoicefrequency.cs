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
	public enum msdyn_invoicefrequencyState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Setup entity for invoice schedules.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_invoicefrequency")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class msdyn_invoicefrequency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
			public const string msdyn_daysofrun = "msdyn_daysofrun";
			public const string msdyn_invoicefrequencyId = "msdyn_invoicefrequencyid";
			public const string Id = "msdyn_invoicefrequencyid";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_period = "msdyn_period";
			public const string msdyn_runspermonth = "msdyn_runspermonth";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_msdyn_invoicefrequency_createdby = "lk_msdyn_invoicefrequency_createdby";
			public const string lk_msdyn_invoicefrequency_createdonbehalfby = "lk_msdyn_invoicefrequency_createdonbehalfby";
			public const string lk_msdyn_invoicefrequency_modifiedby = "lk_msdyn_invoicefrequency_modifiedby";
			public const string lk_msdyn_invoicefrequency_modifiedonbehalfby = "lk_msdyn_invoicefrequency_modifiedonbehalfby";
			public const string organization_msdyn_invoicefrequency = "organization_msdyn_invoicefrequency";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_invoicefrequency() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_invoicefrequency";
		
		public const int EntityTypeCode = 10047;
		
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
		/// Describes how the run days per period interval are setup. As weekdays (Monday, Tuesday...) or day of period (1st, 2nd…) 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_daysofrun")]
		public object msdyn_daysofrun
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("msdyn_daysofrun");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_daysofrun");
				this.SetAttributeValue("msdyn_daysofrun", value);
				this.OnPropertyChanged("msdyn_daysofrun");
			}
		}
		
		/// <summary>
		/// Shows the entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_invoicefrequencyid")]
		public System.Nullable<System.Guid> msdyn_invoicefrequencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_invoicefrequencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequencyId");
				this.SetAttributeValue("msdyn_invoicefrequencyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_invoicefrequencyId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_invoicefrequencyid")]
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
				this.msdyn_invoicefrequencyId = value;
			}
		}
		
		/// <summary>
		/// Type the name of the custom entity.
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
		/// Select the period used for the setup of invoice frequency: supported values are Monthly, Weekly or Bi Weekly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_period")]
		public object msdyn_period
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("msdyn_period");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_period");
				this.SetAttributeValue("msdyn_period", value);
				this.OnPropertyChanged("msdyn_period");
			}
		}
		
		/// <summary>
		/// Select the number of times invoicing should run in a period.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_runspermonth")]
		public object msdyn_runspermonth
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("msdyn_runspermonth");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_runspermonth");
				this.SetAttributeValue("msdyn_runspermonth", value);
				this.OnPropertyChanged("msdyn_runspermonth");
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
		/// Status of the Invoice Frequency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.msdyn_invoicefrequencyState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.msdyn_invoicefrequencyState)(System.Enum.ToObject(typeof(XrmEbc.msdyn_invoicefrequencyState), optionSet.Value)));
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
		/// Reason for the status of the Invoice Frequency
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
		/// 1:N msdyn_invoicefrequency_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> msdyn_invoicefrequency_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_invoicefrequency_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_invoicefrequency_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> msdyn_invoicefrequency_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_invoicefrequency_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_invoicefrequency_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_invoicefrequency_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_invoicefrequency_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_DuplicateBaseRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_invoicefrequency_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_invoicefrequency_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_invoicefrequency_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_DuplicateMatchingRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_invoicefrequency_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> msdyn_invoicefrequency_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_invoicefrequency_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_invoicefrequency_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> msdyn_invoicefrequency_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_invoicefrequency_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_invoicefrequency_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> msdyn_invoicefrequency_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("msdyn_invoicefrequency_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("msdyn_invoicefrequency_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> msdyn_invoicefrequency_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("msdyn_invoicefrequency_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("msdyn_invoicefrequency_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_invoicefrequency_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_invoicefrequency_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> msdyn_invoicefrequency_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_invoicefrequency_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_invoicefrequency_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_invoicefrequency_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency")]
		public System.Collections.Generic.IEnumerable<XrmEbc.msdyn_invoicefrequencydetail> msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.msdyn_invoicefrequencydetail>("msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency");
				this.SetRelatedEntities<XrmEbc.msdyn_invoicefrequencydetail>("msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency", null, value);
				this.OnPropertyChanged("msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency")]
		public System.Collections.Generic.IEnumerable<XrmEbc.msdyn_projectparameter> msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.msdyn_projectparameter>("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency");
				this.SetRelatedEntities<XrmEbc.msdyn_projectparameter>("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency", null, value);
				this.OnPropertyChanged("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency")]
		public System.Collections.Generic.IEnumerable<XrmEbc.QuoteDetail> msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.QuoteDetail>("msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency");
				this.SetRelatedEntities<XrmEbc.QuoteDetail>("msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency", null, value);
				this.OnPropertyChanged("msdyn_msdyn_invoicefrequency_quotedetail_invoicefrequency");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SalesOrderDetail> msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SalesOrderDetail>("msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency");
				this.SetRelatedEntities<XrmEbc.SalesOrderDetail>("msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency", null, value);
				this.OnPropertyChanged("msdyn_msdyn_invoicefrequency_salesorderdetail_invoicefrequency");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_invoicefrequency_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_invoicefrequency_createdby")]
		public XrmEbc.SystemUser lk_msdyn_invoicefrequency_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_invoicefrequency_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_invoicefrequency_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_invoicefrequency_createdonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_invoicefrequency_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_invoicefrequency_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_invoicefrequency_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_invoicefrequency_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_invoicefrequency_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_invoicefrequency_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_invoicefrequency_modifiedby")]
		public XrmEbc.SystemUser lk_msdyn_invoicefrequency_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_invoicefrequency_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_invoicefrequency_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_invoicefrequency_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_invoicefrequency_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_invoicefrequency_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_invoicefrequency_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_invoicefrequency_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_invoicefrequency_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_msdyn_invoicefrequency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_invoicefrequency")]
		public XrmEbc.Organization organization_msdyn_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("organization_msdyn_invoicefrequency", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_invoicefrequency(object anonymousType) : 
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
                        Attributes["msdyn_invoicefrequencyid"] = base.Id;
                        break;
                    case "msdyn_invoicefrequencyid":
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