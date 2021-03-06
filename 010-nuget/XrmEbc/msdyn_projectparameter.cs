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
	public enum msdyn_projectparameterState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// List of settings that determine the behavior of the project-based service solution.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_projectparameter")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class msdyn_projectparameter : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
			public const string msdyn_Allowskillupdatebyresource = "msdyn_allowskillupdatebyresource";
			public const string msdyn_defaultorganizationalunit = "msdyn_defaultorganizationalunit";
			public const string msdyn_defaultWorkTemplate = "msdyn_defaultworktemplate";
			public const string msdyn_description = "msdyn_description";
			public const string msdyn_invoicefrequency = "msdyn_invoicefrequency";
			public const string msdyn_projectmanagerrole = "msdyn_projectmanagerrole";
			public const string msdyn_projectparameterId = "msdyn_projectparameterid";
			public const string Id = "msdyn_projectparameterid";
			public const string msdyn_Projectresourcerequirementsvisibletore = "msdyn_projectresourcerequirementsvisibletore";
			public const string msdyn_resourceallocationmode = "msdyn_resourceallocationmode";
			public const string msdyn_teammemberrole = "msdyn_teammemberrole";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_msdyn_projectparameter_createdby = "lk_msdyn_projectparameter_createdby";
			public const string lk_msdyn_projectparameter_createdonbehalfby = "lk_msdyn_projectparameter_createdonbehalfby";
			public const string lk_msdyn_projectparameter_modifiedby = "lk_msdyn_projectparameter_modifiedby";
			public const string lk_msdyn_projectparameter_modifiedonbehalfby = "lk_msdyn_projectparameter_modifiedonbehalfby";
			public const string msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole = "msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole";
			public const string msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole = "msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole";
			public const string msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency = "msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency";
			public const string msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate = "msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate";
			public const string msdyn_projectparameter_defaultorganizationalunit = "msdyn_projectparameter_defaultorganizationalunit";
			public const string organization_msdyn_projectparameter = "organization_msdyn_projectparameter";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_projectparameter() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_projectparameter";
		
		public const int EntityTypeCode = 10066;
		
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
		/// Allow resources to update their skills via the Project Finder Mobile app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_allowskillupdatebyresource")]
		public System.Nullable<bool> msdyn_Allowskillupdatebyresource
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_allowskillupdatebyresource");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_Allowskillupdatebyresource");
				this.SetAttributeValue("msdyn_allowskillupdatebyresource", value);
				this.OnPropertyChanged("msdyn_Allowskillupdatebyresource");
			}
		}
		
		/// <summary>
		/// Select the default organizational unit that will be used for new resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_defaultorganizationalunit")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_defaultorganizationalunit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_defaultorganizationalunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_defaultorganizationalunit");
				this.SetAttributeValue("msdyn_defaultorganizationalunit", value);
				this.OnPropertyChanged("msdyn_defaultorganizationalunit");
			}
		}
		
		/// <summary>
		/// Select the default work template for new projects.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_defaultworktemplate")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_defaultWorkTemplate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_defaultworktemplate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_defaultWorkTemplate");
				this.SetAttributeValue("msdyn_defaultworktemplate", value);
				this.OnPropertyChanged("msdyn_defaultWorkTemplate");
			}
		}
		
		/// <summary>
		/// Type the name of the project parameters.
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
		/// Select the default frequency for generating invoices.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_invoicefrequency")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_invoicefrequency");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_invoicefrequency");
				this.SetAttributeValue("msdyn_invoicefrequency", value);
				this.OnPropertyChanged("msdyn_invoicefrequency");
			}
		}
		
		/// <summary>
		/// Shows the default role to be used when a project manager is added to the project team.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectmanagerrole")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_projectmanagerrole
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_projectmanagerrole");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectmanagerrole");
				this.SetAttributeValue("msdyn_projectmanagerrole", value);
				this.OnPropertyChanged("msdyn_projectmanagerrole");
			}
		}
		
		/// <summary>
		/// Shows the entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectparameterid")]
		public System.Nullable<System.Guid> msdyn_projectparameterId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_projectparameterid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameterId");
				this.SetAttributeValue("msdyn_projectparameterid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_projectparameterId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectparameterid")]
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
				this.msdyn_projectparameterId = value;
			}
		}
		
		/// <summary>
		/// Select whether project resource requirements are visible to resources.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectresourcerequirementsvisibletore")]
		public System.Nullable<bool> msdyn_Projectresourcerequirementsvisibletore
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_projectresourcerequirementsvisibletore");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_Projectresourcerequirementsvisibletore");
				this.SetAttributeValue("msdyn_projectresourcerequirementsvisibletore", value);
				this.OnPropertyChanged("msdyn_Projectresourcerequirementsvisibletore");
			}
		}
		
		/// <summary>
		/// Select the default method for allocating resources to projects.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourceallocationmode")]
		public object msdyn_resourceallocationmode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("msdyn_resourceallocationmode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourceallocationmode");
				this.SetAttributeValue("msdyn_resourceallocationmode", value);
				this.OnPropertyChanged("msdyn_resourceallocationmode");
			}
		}
		
		/// <summary>
		/// Shows the default role to be used when a team member is added to the project team.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_teammemberrole")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_teammemberrole
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_teammemberrole");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_teammemberrole");
				this.SetAttributeValue("msdyn_teammemberrole", value);
				this.OnPropertyChanged("msdyn_teammemberrole");
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
		/// Status of the Project Parameter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<XrmEbc.msdyn_projectparameterState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((XrmEbc.msdyn_projectparameterState)(System.Enum.ToObject(typeof(XrmEbc.msdyn_projectparameterState), optionSet.Value)));
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
		/// Reason for the status of the Project Parameter
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
		/// 1:N msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter")]
		public System.Collections.Generic.IEnumerable<XrmEbc.msdyn_projectparameterpricelist> msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.msdyn_projectparameterpricelist>("msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter");
				this.SetRelatedEntities<XrmEbc.msdyn_projectparameterpricelist>("msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter", null, value);
				this.OnPropertyChanged("msdyn_msdyn_projectparameter_msdyn_projectparameterpricelist_ProjectParameter");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_Annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_Annotations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.Annotation> msdyn_projectparameter_Annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.Annotation>("msdyn_projectparameter_Annotations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_Annotations");
				this.SetRelatedEntities<XrmEbc.Annotation>("msdyn_projectparameter_Annotations", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_Annotations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<XrmEbc.AsyncOperation> msdyn_projectparameter_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_projectparameter_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_AsyncOperations");
				this.SetRelatedEntities<XrmEbc.AsyncOperation>("msdyn_projectparameter_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<XrmEbc.BulkDeleteFailure> msdyn_projectparameter_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_projectparameter_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_BulkDeleteFailures");
				this.SetRelatedEntities<XrmEbc.BulkDeleteFailure>("msdyn_projectparameter_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_projectparameter_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectparameter_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_DuplicateBaseRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectparameter_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<XrmEbc.DuplicateRecord> msdyn_projectparameter_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectparameter_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_DuplicateMatchingRecord");
				this.SetRelatedEntities<XrmEbc.DuplicateRecord>("msdyn_projectparameter_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<XrmEbc.MailboxTrackingFolder> msdyn_projectparameter_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_projectparameter_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_MailboxTrackingFolders");
				this.SetRelatedEntities<XrmEbc.MailboxTrackingFolder>("msdyn_projectparameter_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<XrmEbc.PrincipalObjectAttributeAccess> msdyn_projectparameter_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_projectparameter_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<XrmEbc.PrincipalObjectAttributeAccess>("msdyn_projectparameter_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_ProcessSession")]
		public System.Collections.Generic.IEnumerable<XrmEbc.ProcessSession> msdyn_projectparameter_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.ProcessSession>("msdyn_projectparameter_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_ProcessSession");
				this.SetRelatedEntities<XrmEbc.ProcessSession>("msdyn_projectparameter_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> msdyn_projectparameter_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("msdyn_projectparameter_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("msdyn_projectparameter_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_projectparameter_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> msdyn_projectparameter_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_projectparameter_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_UserEntityInstanceDatas");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("msdyn_projectparameter_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectparameter_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectparameter_createdby")]
		public XrmEbc.SystemUser lk_msdyn_projectparameter_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectparameter_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectparameter_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectparameter_createdonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_projectparameter_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectparameter_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_projectparameter_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectparameter_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_projectparameter_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectparameter_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectparameter_modifiedby")]
		public XrmEbc.SystemUser lk_msdyn_projectparameter_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectparameter_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_projectparameter_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_projectparameter_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_msdyn_projectparameter_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectparameter_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_projectparameter_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_msdyn_projectparameter_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_projectparameter_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_projectmanagerrole")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole")]
		public XrmEbc.BookableResourceCategory msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BookableResourceCategory>("msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole");
				this.SetRelatedEntity<XrmEbc.BookableResourceCategory>("msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole", null, value);
				this.OnPropertyChanged("msdyn_bookableresourcecategory_msdyn_projectparameter_projectmanagerrole");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_teammemberrole")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole")]
		public XrmEbc.BookableResourceCategory msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.BookableResourceCategory>("msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole");
				this.SetRelatedEntity<XrmEbc.BookableResourceCategory>("msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole", null, value);
				this.OnPropertyChanged("msdyn_bookableresourcecategory_msdyn_projectparameter_teammemberrole");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_invoicefrequency")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency")]
		public XrmEbc.msdyn_invoicefrequency msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.msdyn_invoicefrequency>("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency");
				this.SetRelatedEntity<XrmEbc.msdyn_invoicefrequency>("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency", null, value);
				this.OnPropertyChanged("msdyn_msdyn_invoicefrequency_msdyn_projectparameter_invoicefrequency");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_defaultworktemplate")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate")]
		public XrmEbc.msdyn_workhourtemplate msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.msdyn_workhourtemplate>("msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate");
				this.SetRelatedEntity<XrmEbc.msdyn_workhourtemplate>("msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate", null, value);
				this.OnPropertyChanged("msdyn_msdyn_workhourtemplate_msdyn_projectparameter_defaultWorkTemplate");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_projectparameter_defaultorganizationalunit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_defaultorganizationalunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_projectparameter_defaultorganizationalunit")]
		public XrmEbc.msdyn_organizationalunit msdyn_projectparameter_defaultorganizationalunit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.msdyn_organizationalunit>("msdyn_projectparameter_defaultorganizationalunit", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_projectparameter_defaultorganizationalunit");
				this.SetRelatedEntity<XrmEbc.msdyn_organizationalunit>("msdyn_projectparameter_defaultorganizationalunit", null, value);
				this.OnPropertyChanged("msdyn_projectparameter_defaultorganizationalunit");
			}
		}
		
		/// <summary>
		/// N:1 organization_msdyn_projectparameter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_projectparameter")]
		public XrmEbc.Organization organization_msdyn_projectparameter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("organization_msdyn_projectparameter", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_projectparameter(object anonymousType) : 
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
                        Attributes["msdyn_projectparameterid"] = base.Id;
                        break;
                    case "msdyn_projectparameterid":
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