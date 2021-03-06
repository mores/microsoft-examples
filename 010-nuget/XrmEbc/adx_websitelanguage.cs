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
	public enum adx_websitelanguageState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Languages supported and publishing status for the portal
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("adx_websitelanguage")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class adx_websitelanguage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string adx_name = "adx_name";
			public const string adx_PortalLanguageId = "adx_portallanguageid";
			public const string adx_PublishingState = "adx_publishingstate";
			public const string adx_WebsiteId = "adx_websiteid";
			public const string adx_websitelanguageId = "adx_websitelanguageid";
			public const string Id = "adx_websitelanguageid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
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
			public const string adx_adx_portallanguage_adx_websitelanguage = "adx_adx_portallanguage_adx_websitelanguage";
			public const string adx_adx_publishingstate_adx_websitelanguage_PublishingState = "adx_adx_publishingstate_adx_websitelanguage_PublishingState";
			public const string adx_adx_website_adx_websitelanguage = "adx_adx_website_adx_websitelanguage";
			public const string business_unit_adx_websitelanguage = "business_unit_adx_websitelanguage";
			public const string lk_adx_websitelanguage_createdby = "lk_adx_websitelanguage_createdby";
			public const string lk_adx_websitelanguage_createdonbehalfby = "lk_adx_websitelanguage_createdonbehalfby";
			public const string lk_adx_websitelanguage_modifiedby = "lk_adx_websitelanguage_modifiedby";
			public const string lk_adx_websitelanguage_modifiedonbehalfby = "lk_adx_websitelanguage_modifiedonbehalfby";
			public const string team_adx_websitelanguage = "team_adx_websitelanguage";
			public const string user_adx_websitelanguage = "user_adx_websitelanguage";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public adx_websitelanguage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "adx_websitelanguage";
		
		public const int EntityTypeCode = 10230;
		
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
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_name")]
		public string adx_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_name");
				this.SetAttributeValue("adx_name", value);
				this.OnPropertyChanged("adx_name");
			}
		}
		
		/// <summary>
		/// lookup to Portal Language - one of the 43 supported Dynamics 365 languages that this website/language instance will use
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_portallanguageid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_PortalLanguageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_portallanguageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PortalLanguageId");
				this.SetAttributeValue("adx_portallanguageid", value);
				this.OnPropertyChanged("adx_PortalLanguageId");
			}
		}
		
		/// <summary>
		/// Lookup to Publishing State - publishing state of this website/language instance (draft/published)
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_publishingstate")]
		public Microsoft.Xrm.Sdk.EntityReference adx_PublishingState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_publishingstate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_PublishingState");
				this.SetAttributeValue("adx_publishingstate", value);
				this.OnPropertyChanged("adx_PublishingState");
			}
		}
		
		/// <summary>
		/// Lookup to Website
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_websiteid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_WebsiteId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_websiteid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_WebsiteId");
				this.SetAttributeValue("adx_websiteid", value);
				this.OnPropertyChanged("adx_WebsiteId");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_websitelanguageid")]
		public System.Nullable<System.Guid> adx_websitelanguageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("adx_websitelanguageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguageId");
				this.SetAttributeValue("adx_websitelanguageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("adx_websitelanguageId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_websitelanguageid")]
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
				this.adx_websitelanguageId = value;
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
		/// Status of the Website Language
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.adx_websitelanguageState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.adx_websitelanguageState)(System.Enum.ToObject(typeof(XrmEbc.adx_websitelanguageState), optionSet.Value)));
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
		/// Reason for the status of the Website Language
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
		/// 1:N adx_adx_websitelanguage_adx_website_DefaultLanguage
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_adx_websitelanguage_adx_website_DefaultLanguage")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Adx_website> adx_adx_websitelanguage_adx_website_DefaultLanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Adx_website>("adx_adx_websitelanguage_adx_website_DefaultLanguage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_adx_websitelanguage_adx_website_DefaultLanguage");
				this.SetRelatedEntities<XrmEbc.Adx_website>("adx_adx_websitelanguage_adx_website_DefaultLanguage", null, value);
				this.OnPropertyChanged("adx_adx_websitelanguage_adx_website_DefaultLanguage");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> adx_websitelanguage_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("adx_websitelanguage_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("adx_websitelanguage_AsyncOperations", null, value);
				this.OnPropertyChanged("adx_websitelanguage_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_blog
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_blog")]
		public System.Collections.Generic.IEnumerable<XrmEbc.adx_blog> adx_websitelanguage_blog
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.adx_blog>("adx_websitelanguage_blog", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_blog");
				this.SetRelatedEntities<XrmEbc.adx_blog>("adx_websitelanguage_blog", null, value);
				this.OnPropertyChanged("adx_websitelanguage_blog");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> adx_websitelanguage_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("adx_websitelanguage_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("adx_websitelanguage_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("adx_websitelanguage_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_communityforum
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_communityforum")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Adx_communityforum> adx_websitelanguage_communityforum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Adx_communityforum>("adx_websitelanguage_communityforum", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_communityforum");
				this.SetRelatedEntities<XrmEbc.Adx_communityforum>("adx_websitelanguage_communityforum", null, value);
				this.OnPropertyChanged("adx_websitelanguage_communityforum");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_contentsnippet_contentsnippetlanguageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_contentsnippet_contentsnippetlanguageid")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Adx_contentsnippet> adx_websitelanguage_contentsnippet_contentsnippetlanguageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Adx_contentsnippet>("adx_websitelanguage_contentsnippet_contentsnippetlanguageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_contentsnippet_contentsnippetlanguageid");
				this.SetRelatedEntities<XrmEbc.Adx_contentsnippet>("adx_websitelanguage_contentsnippet_contentsnippetlanguageid", null, value);
				this.OnPropertyChanged("adx_websitelanguage_contentsnippet_contentsnippetlanguageid");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_ideaforum
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_ideaforum")]
		public System.Collections.Generic.IEnumerable<XrmEbc.adx_ideaforum> adx_websitelanguage_ideaforum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.adx_ideaforum>("adx_websitelanguage_ideaforum", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_ideaforum");
				this.SetRelatedEntities<XrmEbc.adx_ideaforum>("adx_websitelanguage_ideaforum", null, value);
				this.OnPropertyChanged("adx_websitelanguage_ideaforum");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> adx_websitelanguage_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("adx_websitelanguage_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("adx_websitelanguage_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("adx_websitelanguage_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> adx_websitelanguage_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("adx_websitelanguage_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("adx_websitelanguage_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("adx_websitelanguage_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> adx_websitelanguage_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("adx_websitelanguage_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("adx_websitelanguage_ProcessSession", null, value);
				this.OnPropertyChanged("adx_websitelanguage_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> adx_websitelanguage_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("adx_websitelanguage_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("adx_websitelanguage_SyncErrors", null, value);
				this.OnPropertyChanged("adx_websitelanguage_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> adx_websitelanguage_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("adx_websitelanguage_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("adx_websitelanguage_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("adx_websitelanguage_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_weblinkset
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_weblinkset")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Adx_weblinkset> adx_websitelanguage_weblinkset
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Adx_weblinkset>("adx_websitelanguage_weblinkset", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_weblinkset");
				this.SetRelatedEntities<XrmEbc.Adx_weblinkset>("adx_websitelanguage_weblinkset", null, value);
				this.OnPropertyChanged("adx_websitelanguage_weblinkset");
			}
		}
		
		/// <summary>
		/// 1:N adx_websitelanguage_webpage_webpagelanguageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_websitelanguage_webpage_webpagelanguageid")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Adx_webpage> adx_websitelanguage_webpage_webpagelanguageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Adx_webpage>("adx_websitelanguage_webpage_webpagelanguageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_websitelanguage_webpage_webpagelanguageid");
				this.SetRelatedEntities<XrmEbc.Adx_webpage>("adx_websitelanguage_webpage_webpagelanguageid", null, value);
				this.OnPropertyChanged("adx_websitelanguage_webpage_webpagelanguageid");
			}
		}
		
		/// <summary>
		/// N:1 adx_adx_portallanguage_adx_websitelanguage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_portallanguageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_adx_portallanguage_adx_websitelanguage")]
		public XrmEbc.adx_portallanguage adx_adx_portallanguage_adx_websitelanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.adx_portallanguage>("adx_adx_portallanguage_adx_websitelanguage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_adx_portallanguage_adx_websitelanguage");
				this.SetRelatedEntity<XrmEbc.adx_portallanguage>("adx_adx_portallanguage_adx_websitelanguage", null, value);
				this.OnPropertyChanged("adx_adx_portallanguage_adx_websitelanguage");
			}
		}
		
		/// <summary>
		/// N:1 adx_adx_publishingstate_adx_websitelanguage_PublishingState
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_publishingstate")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_adx_publishingstate_adx_websitelanguage_PublishingState")]
		public XrmEbc.Adx_publishingstate adx_adx_publishingstate_adx_websitelanguage_PublishingState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Adx_publishingstate>("adx_adx_publishingstate_adx_websitelanguage_PublishingState", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_adx_publishingstate_adx_websitelanguage_PublishingState");
				this.SetRelatedEntity<XrmEbc.Adx_publishingstate>("adx_adx_publishingstate_adx_websitelanguage_PublishingState", null, value);
				this.OnPropertyChanged("adx_adx_publishingstate_adx_websitelanguage_PublishingState");
			}
		}
		
		/// <summary>
		/// N:1 adx_adx_website_adx_websitelanguage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_websiteid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_adx_website_adx_websitelanguage")]
		public XrmEbc.Adx_website adx_adx_website_adx_websitelanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Adx_website>("adx_adx_website_adx_websitelanguage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_adx_website_adx_websitelanguage");
				this.SetRelatedEntity<XrmEbc.Adx_website>("adx_adx_website_adx_websitelanguage", null, value);
				this.OnPropertyChanged("adx_adx_website_adx_websitelanguage");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_adx_websitelanguage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_adx_websitelanguage")]
		public XrmEbc.BusinessUnit business_unit_adx_websitelanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BusinessUnit>("business_unit_adx_websitelanguage", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_websitelanguage_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_websitelanguage_createdby")]
		public XrmEbc.SystemUser lk_adx_websitelanguage_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_websitelanguage_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_websitelanguage_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_websitelanguage_createdonbehalfby")]
		public XrmEbc.SystemUser lk_adx_websitelanguage_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_websitelanguage_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_websitelanguage_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_adx_websitelanguage_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_adx_websitelanguage_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_websitelanguage_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_websitelanguage_modifiedby")]
		public XrmEbc.SystemUser lk_adx_websitelanguage_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_websitelanguage_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_websitelanguage_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_websitelanguage_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_adx_websitelanguage_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_websitelanguage_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_websitelanguage_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_adx_websitelanguage_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_adx_websitelanguage_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_adx_websitelanguage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_adx_websitelanguage")]
		public XrmEbc.Team team_adx_websitelanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Team>("team_adx_websitelanguage", null);
			}
		}
		
		/// <summary>
		/// N:1 user_adx_websitelanguage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_adx_websitelanguage")]
		public XrmEbc.SystemUser user_adx_websitelanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("user_adx_websitelanguage", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public adx_websitelanguage(object anonymousType) : 
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
                        Attributes["adx_websitelanguageid"] = base.Id;
                        break;
                    case "adx_websitelanguageid":
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