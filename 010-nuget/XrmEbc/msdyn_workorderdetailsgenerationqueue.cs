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
	public enum msdyn_workorderdetailsgenerationqueueState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Pool for WO Generation
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_workorderdetailsgenerationqueue")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class msdyn_workorderdetailsgenerationqueue : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
			public const string msdyn_AgreementBookingDate = "msdyn_agreementbookingdate";
			public const string msdyn_Booking = "msdyn_booking";
			public const string msdyn_ExceptionMessage = "msdyn_exceptionmessage";
			public const string msdyn_ExceptionTrace = "msdyn_exceptiontrace";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_Processed = "msdyn_processed";
			public const string msdyn_SchDateOwnerId = "msdyn_schdateownerid";
			public const string msdyn_WorkOrderDetails = "msdyn_workorderdetails";
			public const string msdyn_workorderdetailsgenerationqueueId = "msdyn_workorderdetailsgenerationqueueid";
			public const string Id = "msdyn_workorderdetailsgenerationqueueid";
			public const string msdyn_WorkorderId = "msdyn_workorderid";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_msdyn_workorderdetailsgenerationqueue_createdby = "lk_msdyn_workorderdetailsgenerationqueue_createdby";
			public const string lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby = "lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby";
			public const string lk_msdyn_workorderdetailsgenerationqueue_modifiedby = "lk_msdyn_workorderdetailsgenerationqueue_modifiedby";
			public const string lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby = "lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby";
			public const string msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate = "msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementB" +
		"ookingDate";
			public const string organization_msdyn_workorderdetailsgenerationqueue = "organization_msdyn_workorderdetailsgenerationqueue";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_workorderdetailsgenerationqueue() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_workorderdetailsgenerationqueue";
		
		public const int EntityTypeCode = 10175;
		
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
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
		/// Unique identifier for Agreement Booking Date associated with Work Order Details Generation Queue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_agreementbookingdate")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_AgreementBookingDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_agreementbookingdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_AgreementBookingDate");
				this.SetAttributeValue("msdyn_agreementbookingdate", value);
				this.OnPropertyChanged("msdyn_AgreementBookingDate");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_booking")]
		public string msdyn_Booking
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_booking");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_Booking");
				this.SetAttributeValue("msdyn_booking", value);
				this.OnPropertyChanged("msdyn_Booking");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_exceptionmessage")]
		public string msdyn_ExceptionMessage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_exceptionmessage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_ExceptionMessage");
				this.SetAttributeValue("msdyn_exceptionmessage", value);
				this.OnPropertyChanged("msdyn_ExceptionMessage");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_exceptiontrace")]
		public string msdyn_ExceptionTrace
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_exceptiontrace");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_ExceptionTrace");
				this.SetAttributeValue("msdyn_exceptiontrace", value);
				this.OnPropertyChanged("msdyn_ExceptionTrace");
			}
		}
		
		/// <summary>
		/// Enter the name of the custom entity.
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_processed")]
		public System.Nullable<bool> msdyn_Processed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_processed");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_Processed");
				this.SetAttributeValue("msdyn_processed", value);
				this.OnPropertyChanged("msdyn_Processed");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_schdateownerid")]
		public string msdyn_SchDateOwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_schdateownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_SchDateOwnerId");
				this.SetAttributeValue("msdyn_schdateownerid", value);
				this.OnPropertyChanged("msdyn_SchDateOwnerId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderdetails")]
		public string msdyn_WorkOrderDetails
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_workorderdetails");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_WorkOrderDetails");
				this.SetAttributeValue("msdyn_workorderdetails", value);
				this.OnPropertyChanged("msdyn_WorkOrderDetails");
			}
		}
		
		/// <summary>
		/// Shows the entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderdetailsgenerationqueueid")]
		public System.Nullable<System.Guid> msdyn_workorderdetailsgenerationqueueId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_workorderdetailsgenerationqueueid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueueId");
				this.SetAttributeValue("msdyn_workorderdetailsgenerationqueueid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueueId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderdetailsgenerationqueueid")]
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
				this.msdyn_workorderdetailsgenerationqueueId = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_workorderid")]
		public string msdyn_WorkorderId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_workorderid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_WorkorderId");
				this.SetAttributeValue("msdyn_workorderid", value);
				this.OnPropertyChanged("msdyn_WorkorderId");
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
		/// Status of the Work Order Details Generation Queue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.msdyn_workorderdetailsgenerationqueueState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.msdyn_workorderdetailsgenerationqueueState)(System.Enum.ToObject(typeof(XrmEbc.msdyn_workorderdetailsgenerationqueueState), optionSet.Value)));
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
		/// Reason for the status of the Work Order Details Generation Queue
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
		/// 1:N msdyn_workorderdetailsgenerationqueue_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> msdyn_workorderdetailsgenerationqueue_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_workorderdetailsgenerationqueue_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_workorderdetailsgenerationqueue_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> msdyn_workorderdetailsgenerationqueue_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("msdyn_workorderdetailsgenerationqueue_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("msdyn_workorderdetailsgenerationqueue_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> msdyn_workorderdetailsgenerationqueue_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("msdyn_workorderdetailsgenerationqueue_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("msdyn_workorderdetailsgenerationqueue_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_workorderdetailsgenerationqueue_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_workorderdetailsgenerationqueue_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_workorderdetailsgenerationqueue_createdby")]
		public XrmEbc.SystemUser lk_msdyn_workorderdetailsgenerationqueue_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_workorderdetailsgenerationqueue_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_workorderdetailsgenerationqueue_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_workorderdetailsgenerationqueue_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_workorderdetailsgenerationqueue_modifiedby")]
		public XrmEbc.SystemUser lk_msdyn_workorderdetailsgenerationqueue_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_workorderdetailsgenerationqueue_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_workorderdetailsgenerationqueue_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_agreementbookingdate")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementB" +
			"ookingDate")]
		public XrmEbc.msdyn_agreementbookingdate msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementBookingDate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.msdyn_agreementbookingdate>("msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementB" +
						"ookingDate", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementB" +
						"ookingDate");
				this.SetRelatedEntity<XrmEbc.msdyn_agreementbookingdate>("msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementB" +
						"ookingDate", null, value);
				this.OnPropertyChanged("msdyn_msdyn_agreementbookingdate_msdyn_workorderdetailsgenerationqueue_AgreementB" +
						"ookingDate");
			}
		}
		
		/// <summary>
		/// N:1 organization_msdyn_workorderdetailsgenerationqueue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_workorderdetailsgenerationqueue")]
		public XrmEbc.Organization organization_msdyn_workorderdetailsgenerationqueue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("organization_msdyn_workorderdetailsgenerationqueue", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_workorderdetailsgenerationqueue(object anonymousType) : 
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
                        Attributes["msdyn_workorderdetailsgenerationqueueid"] = base.Id;
                        break;
                    case "msdyn_workorderdetailsgenerationqueueid":
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