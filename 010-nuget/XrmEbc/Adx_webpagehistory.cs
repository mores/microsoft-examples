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
	public enum Adx_webpagehistoryState
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
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("adx_webpagehistory")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class Adx_webpagehistory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string Adx_ChangeDate = "adx_changedate";
			public const string adx_changedbyid = "adx_changedbyid";
			public const string Adx_Copy = "adx_copy";
			public const string Adx_DisplayDate = "adx_displaydate";
			public const string Adx_FieldsChanged = "adx_fieldschanged";
			public const string Adx_name = "adx_name";
			public const string Adx_PartialUrl = "adx_partialurl";
			public const string adx_publishingstateid = "adx_publishingstateid";
			public const string Adx_Summary = "adx_summary";
			public const string Adx_Title = "adx_title";
			public const string Adx_webpagehistoryId = "adx_webpagehistoryid";
			public const string Id = "adx_webpagehistoryid";
			public const string adx_webpageid = "adx_webpageid";
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
			public const string adx_changedcontact_webpagehistory = "adx_changedcontact_webpagehistory";
			public const string adx_publishingstate_webpagehistory = "adx_publishingstate_webpagehistory";
			public const string adx_webpage_webpagehistory = "adx_webpage_webpagehistory";
			public const string business_unit_adx_webpagehistory = "business_unit_adx_webpagehistory";
			public const string lk_adx_webpagehistory_createdby = "lk_adx_webpagehistory_createdby";
			public const string lk_adx_webpagehistory_createdonbehalfby = "lk_adx_webpagehistory_createdonbehalfby";
			public const string lk_adx_webpagehistory_modifiedby = "lk_adx_webpagehistory_modifiedby";
			public const string lk_adx_webpagehistory_modifiedonbehalfby = "lk_adx_webpagehistory_modifiedonbehalfby";
			public const string team_adx_webpagehistory = "team_adx_webpagehistory";
			public const string user_adx_webpagehistory = "user_adx_webpagehistory";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Adx_webpagehistory() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "adx_webpagehistory";
		
		public const int EntityTypeCode = 10226;
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_changedate")]
		public System.Nullable<System.DateTime> Adx_ChangeDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_changedate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_ChangeDate");
				this.SetAttributeValue("adx_changedate", value);
				this.OnPropertyChanged("Adx_ChangeDate");
			}
		}
		
		/// <summary>
		/// Unique identifier for Contact associated with Web Page History.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_changedbyid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_changedbyid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_changedbyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_changedbyid");
				this.SetAttributeValue("adx_changedbyid", value);
				this.OnPropertyChanged("adx_changedbyid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_copy")]
		public string Adx_Copy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_copy");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_Copy");
				this.SetAttributeValue("adx_copy", value);
				this.OnPropertyChanged("Adx_Copy");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_displaydate")]
		public System.Nullable<System.DateTime> Adx_DisplayDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("adx_displaydate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_DisplayDate");
				this.SetAttributeValue("adx_displaydate", value);
				this.OnPropertyChanged("Adx_DisplayDate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_fieldschanged")]
		public string Adx_FieldsChanged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_fieldschanged");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_FieldsChanged");
				this.SetAttributeValue("adx_fieldschanged", value);
				this.OnPropertyChanged("Adx_FieldsChanged");
			}
		}
		
		/// <summary>
		/// Type the name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_name")]
		public string Adx_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_name");
				this.SetAttributeValue("adx_name", value);
				this.OnPropertyChanged("Adx_name");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_partialurl")]
		public string Adx_PartialUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_partialurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_PartialUrl");
				this.SetAttributeValue("adx_partialurl", value);
				this.OnPropertyChanged("Adx_PartialUrl");
			}
		}
		
		/// <summary>
		/// Unique identifier for Publishing State associated with Web Page History.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_publishingstateid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_publishingstateid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_publishingstateid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_publishingstateid");
				this.SetAttributeValue("adx_publishingstateid", value);
				this.OnPropertyChanged("adx_publishingstateid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_summary")]
		public string Adx_Summary
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_summary");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_Summary");
				this.SetAttributeValue("adx_summary", value);
				this.OnPropertyChanged("Adx_Summary");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_title")]
		public string Adx_Title
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("adx_title");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_Title");
				this.SetAttributeValue("adx_title", value);
				this.OnPropertyChanged("Adx_Title");
			}
		}
		
		/// <summary>
		/// Shows the entity instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_webpagehistoryid")]
		public System.Nullable<System.Guid> Adx_webpagehistoryId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("adx_webpagehistoryid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Adx_webpagehistoryId");
				this.SetAttributeValue("adx_webpagehistoryid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("Adx_webpagehistoryId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_webpagehistoryid")]
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
				this.Adx_webpagehistoryId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier for Web Page associated with Web Page History.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_webpageid")]
		public Microsoft.Xrm.Sdk.EntityReference adx_webpageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("adx_webpageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpageid");
				this.SetAttributeValue("adx_webpageid", value);
				this.OnPropertyChanged("adx_webpageid");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows who created the record on behalf of another user.
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
		/// Shows who last updated the record.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Enter the user who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
		/// Shows the business unit that owns the record.
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
		/// Status of the Web Page History
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.Adx_webpagehistoryState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.Adx_webpagehistoryState)(System.Enum.ToObject(typeof(XrmEbc.Adx_webpagehistoryState), optionSet.Value)));
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
		/// Select the webpage history's status.
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
		/// 1:N adx_webpagehistory_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> adx_webpagehistory_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("adx_webpagehistory_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("adx_webpagehistory_AsyncOperations", null, value);
				this.OnPropertyChanged("adx_webpagehistory_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N adx_webpagehistory_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> adx_webpagehistory_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("adx_webpagehistory_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("adx_webpagehistory_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("adx_webpagehistory_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N adx_webpagehistory_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> adx_webpagehistory_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("adx_webpagehistory_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("adx_webpagehistory_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("adx_webpagehistory_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N adx_webpagehistory_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> adx_webpagehistory_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("adx_webpagehistory_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("adx_webpagehistory_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("adx_webpagehistory_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N adx_webpagehistory_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> adx_webpagehistory_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("adx_webpagehistory_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("adx_webpagehistory_ProcessSession", null, value);
				this.OnPropertyChanged("adx_webpagehistory_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N adx_webpagehistory_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> adx_webpagehistory_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("adx_webpagehistory_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("adx_webpagehistory_SyncErrors", null, value);
				this.OnPropertyChanged("adx_webpagehistory_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N adx_webpagehistory_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpagehistory_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> adx_webpagehistory_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("adx_webpagehistory_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpagehistory_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("adx_webpagehistory_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("adx_webpagehistory_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 adx_changedcontact_webpagehistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_changedbyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_changedcontact_webpagehistory")]
		public XrmEbc.Contact adx_changedcontact_webpagehistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Contact>("adx_changedcontact_webpagehistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_changedcontact_webpagehistory");
				this.SetRelatedEntity<XrmEbc.Contact>("adx_changedcontact_webpagehistory", null, value);
				this.OnPropertyChanged("adx_changedcontact_webpagehistory");
			}
		}
		
		/// <summary>
		/// N:1 adx_publishingstate_webpagehistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_publishingstateid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_publishingstate_webpagehistory")]
		public XrmEbc.Adx_publishingstate adx_publishingstate_webpagehistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Adx_publishingstate>("adx_publishingstate_webpagehistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_publishingstate_webpagehistory");
				this.SetRelatedEntity<XrmEbc.Adx_publishingstate>("adx_publishingstate_webpagehistory", null, value);
				this.OnPropertyChanged("adx_publishingstate_webpagehistory");
			}
		}
		
		/// <summary>
		/// N:1 adx_webpage_webpagehistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("adx_webpageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_webpage_webpagehistory")]
		public XrmEbc.Adx_webpage adx_webpage_webpagehistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Adx_webpage>("adx_webpage_webpagehistory", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_webpage_webpagehistory");
				this.SetRelatedEntity<XrmEbc.Adx_webpage>("adx_webpage_webpagehistory", null, value);
				this.OnPropertyChanged("adx_webpage_webpagehistory");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_adx_webpagehistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_adx_webpagehistory")]
		public XrmEbc.BusinessUnit business_unit_adx_webpagehistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BusinessUnit>("business_unit_adx_webpagehistory", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_webpagehistory_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_webpagehistory_createdby")]
		public XrmEbc.SystemUser lk_adx_webpagehistory_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_webpagehistory_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_webpagehistory_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_webpagehistory_createdonbehalfby")]
		public XrmEbc.SystemUser lk_adx_webpagehistory_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_webpagehistory_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_webpagehistory_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_adx_webpagehistory_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_adx_webpagehistory_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_webpagehistory_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_webpagehistory_modifiedby")]
		public XrmEbc.SystemUser lk_adx_webpagehistory_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_webpagehistory_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_adx_webpagehistory_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_webpagehistory_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_adx_webpagehistory_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_adx_webpagehistory_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_webpagehistory_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_adx_webpagehistory_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_adx_webpagehistory_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 team_adx_webpagehistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_adx_webpagehistory")]
		public XrmEbc.Team team_adx_webpagehistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Team>("team_adx_webpagehistory", null);
			}
		}
		
		/// <summary>
		/// N:1 user_adx_webpagehistory
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_adx_webpagehistory")]
		public XrmEbc.SystemUser user_adx_webpagehistory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("user_adx_webpagehistory", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Adx_webpagehistory(object anonymousType) : 
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
                        Attributes["adx_webpagehistoryid"] = base.Id;
                        break;
                    case "adx_webpagehistoryid":
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