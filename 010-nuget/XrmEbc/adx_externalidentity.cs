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
	public enum adx_externalidentityState
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
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("adx_externalidentity")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class adx_externalidentity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string adx_contactid = "adx_contactid";
			public const string adx_externalidentityId = "adx_externalidentityid";
			public const string Id = "adx_externalidentityid";
			public const string adx_identityprovidername = "adx_identityprovidername";
			public const string adx_username = "adx_username";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string adx_contact_externalidentity = "adx_contact_externalidentity";
			public const string lk_adx_externalidentity_createdby = "lk_adx_externalidentity_createdby";
			public const string lk_adx_externalidentity_createdonbehalfby = "lk_adx_externalidentity_createdonbehalfby";
			public const string lk_adx_externalidentity_modifiedby = "lk_adx_externalidentity_modifiedby";
			public const string lk_adx_externalidentity_modifiedonbehalfby = "lk_adx_externalidentity_modifiedonbehalfby";
			public const string organization_adx_externalidentity = "organization_adx_externalidentity";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public adx_externalidentity() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "adx_externalidentity";
		
		public const int EntityTypeCode = 10248;
		
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
		/// Unique identifier for Contact associated with External Identity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_contactid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_contactid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_contactid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_contactid");
				this.SetAttributeValue("adx_contactid", value);
				this.OnPropertyChanged("adx_contactid");
			}
		}
		
		/// <summary>
		/// Shows the entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_externalidentityid")]
		public System.Nullable<System.Guid> adx_externalidentityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("adx_externalidentityid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentityId");
				this.SetAttributeValue("adx_externalidentityid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("adx_externalidentityId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_externalidentityid")]
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
				this.adx_externalidentityId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_identityprovidername")]
		public string adx_identityprovidername
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_identityprovidername");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_identityprovidername");
				this.SetAttributeValue("adx_identityprovidername", value);
				this.OnPropertyChanged("adx_identityprovidername");
			}
		}
		
		/// <summary>
		/// Shows the name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_username")]
		public string adx_username
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_username");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_username");
				this.SetAttributeValue("adx_username", value);
				this.OnPropertyChanged("adx_username");
			}
		}
		
		/// <summary>
		/// Shows the user who created the record.
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
		/// Shows the date and time when the record was created.
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
		/// Shows the delegate user who created the record.
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
		/// Shows the sequence number of the import that created this record.
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
		/// Shows the user who modified the record.
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
		/// Shows the date and time when the record was modified.
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
		/// Shows the delegate user who modified the record.
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
		/// Shows the organization.
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
		/// Shows the date and time that the record was migrated.
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
		/// Shows whether the external identity is active or inactive. Inactive records are read-only and can't be edited unless they are reactivated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.adx_externalidentityState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.adx_externalidentityState)(System.Enum.ToObject(typeof(XrmEbc.adx_externalidentityState), optionSet.Value)));
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
		/// Select the external identity's status.
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
		/// Shows the time zone code that was in use when the record was created.
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
		/// 1:N adx_externalidentity_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> adx_externalidentity_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("adx_externalidentity_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("adx_externalidentity_AsyncOperations", null, value);
				this.OnPropertyChanged("adx_externalidentity_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N adx_externalidentity_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> adx_externalidentity_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("adx_externalidentity_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("adx_externalidentity_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("adx_externalidentity_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N adx_externalidentity_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> adx_externalidentity_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("adx_externalidentity_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("adx_externalidentity_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("adx_externalidentity_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N adx_externalidentity_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> adx_externalidentity_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("adx_externalidentity_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("adx_externalidentity_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("adx_externalidentity_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N adx_externalidentity_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> adx_externalidentity_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("adx_externalidentity_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("adx_externalidentity_ProcessSession", null, value);
				this.OnPropertyChanged("adx_externalidentity_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N adx_externalidentity_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> adx_externalidentity_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("adx_externalidentity_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("adx_externalidentity_SyncErrors", null, value);
				this.OnPropertyChanged("adx_externalidentity_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N adx_externalidentity_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_externalidentity_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> adx_externalidentity_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("adx_externalidentity_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_externalidentity_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("adx_externalidentity_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("adx_externalidentity_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 adx_contact_externalidentity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_contactid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_contact_externalidentity")]
		public XrmEbc.Contact adx_contact_externalidentity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Contact>("adx_contact_externalidentity", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_contact_externalidentity");
				this.SetRelatedEntity<XrmEbc.Contact>("adx_contact_externalidentity", null, value);
				this.OnPropertyChanged("adx_contact_externalidentity");
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_externalidentity_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_externalidentity_createdby")]
		public XrmEbc.SystemUser lk_adx_externalidentity_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_externalidentity_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_externalidentity_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_externalidentity_createdonbehalfby")]
		public XrmEbc.SystemUser lk_adx_externalidentity_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_externalidentity_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_externalidentity_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_adx_externalidentity_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_adx_externalidentity_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_externalidentity_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_externalidentity_modifiedby")]
		public XrmEbc.SystemUser lk_adx_externalidentity_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_externalidentity_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_externalidentity_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_externalidentity_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_adx_externalidentity_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_externalidentity_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_externalidentity_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_adx_externalidentity_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_adx_externalidentity_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_adx_externalidentity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_adx_externalidentity")]
		public XrmEbc.Organization organization_adx_externalidentity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("organization_adx_externalidentity", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public adx_externalidentity(object anonymousType) : 
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
                        Attributes["adx_externalidentityid"] = base.Id;
                        break;
                    case "adx_externalidentityid":
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