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
	
	/// <summary>
	/// Contains information about a tracked support KPI for a specific customer.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("slaitem")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class SLAItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ApplicableWhenXml = "applicablewhenxml";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string FailureAfter = "failureafter";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningUser = "owninguser";
			public const string RelatedField = "relatedfield";
			public const string SequenceNumber = "sequencenumber";
			public const string SLAId = "slaid";
			public const string SLAItemId = "slaitemid";
			public const string Id = "slaitemid";
			public const string SLAItemIdUnique = "slaitemidunique";
			public const string SolutionId = "solutionid";
			public const string SuccessConditionsXml = "successconditionsxml";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string WarnAfter = "warnafter";
			public const string WorkflowId = "workflowid";
			public const string lk_slaitembase_createdby = "lk_slaitembase_createdby";
			public const string lk_slaitembase_createdonbehalfby = "lk_slaitembase_createdonbehalfby";
			public const string lk_slaitembase_modifiedby = "lk_slaitembase_modifiedby";
			public const string lk_slaitembase_modifiedonbehalfby = "lk_slaitembase_modifiedonbehalfby";
			public const string sla_slaitem_slaId = "sla_slaitem_slaId";
			public const string slaitembase_workflowid = "slaitembase_workflowid";
			public const string TransactionCurrency_SLAItem = "TransactionCurrency_SLAItem";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SLAItem() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "slaitem";
		
		public const int EntityTypeCode = 9751;
		
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
		/// Condition for SLA item
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicablewhenxml")]
		public string ApplicableWhenXml
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("applicablewhenxml");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ApplicableWhenXml");
				this.SetAttributeValue("applicablewhenxml", value);
				this.OnPropertyChanged("ApplicableWhenXml");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public object ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("componentstate");
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
		/// Type additional information to describe the SLA Item
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Exchange rate between the currency associated with the SLA Item record and the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Select how soon the success criteria must be met until the SLA item is considered failed and failure actions are initiated. The actual duration is based on the business hours as specified in the associated SLA record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failureafter")]
		public System.Nullable<int> FailureAfter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("failureafter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FailureAfter");
				this.SetAttributeValue("failureafter", value);
				this.OnPropertyChanged("FailureAfter");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
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
		/// Shows who created the record on behalf of another user.
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
		/// Type a descriptive name of the service level agreement (SLA) item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.
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
		/// Unique identifier of the user who owns the SLA Item record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Select the service level agreement (SLA) key performance indicator (KPI) that this SLA Item is created for.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedfield")]
		public string RelatedField
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("relatedfield");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelatedField");
				this.SetAttributeValue("relatedfield", value);
				this.OnPropertyChanged("RelatedField");
			}
		}
		
		/// <summary>
		/// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequencenumber")]
		public System.Nullable<int> SequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("sequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SequenceNumber");
				this.SetAttributeValue("sequencenumber", value);
				this.OnPropertyChanged("SequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier for SLA associated with SLA Item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		public Microsoft.Xrm.Sdk.EntityReference SLAId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SLAId");
				this.SetAttributeValue("slaid", value);
				this.OnPropertyChanged("SLAId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SLA Item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaitemid")]
		public System.Nullable<System.Guid> SLAItemId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("slaitemid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SLAItemId");
				this.SetAttributeValue("slaitemid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SLAItemId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaitemid")]
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
				this.SLAItemId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaitemidunique")]
		public System.Nullable<System.Guid> SLAItemIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("slaitemidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Condition for SLA item
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("successconditionsxml")]
		public string SuccessConditionsXml
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("successconditionsxml");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SuccessConditionsXml");
				this.SetAttributeValue("successconditionsxml", value);
				this.OnPropertyChanged("SuccessConditionsXml");
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the SLA Item record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
		}
		
		/// <summary>
		/// Version number of the SLA Item.
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
		/// Select how soon the success criteria must be met before warning actions are initiated. The actual duration is based on the business hours as specified in the associated SLA record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warnafter")]
		public System.Nullable<int> WarnAfter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("warnafter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WarnAfter");
				this.SetAttributeValue("warnafter", value);
				this.OnPropertyChanged("WarnAfter");
			}
		}
		
		/// <summary>
		/// Workflow associated with the SLA Item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
		public Microsoft.Xrm.Sdk.EntityReference WorkflowId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workflowid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WorkflowId");
				this.SetAttributeValue("workflowid", value);
				this.OnPropertyChanged("WorkflowId");
			}
		}
		
		/// <summary>
		/// 1:N SLAItem_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SLAItem_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> SLAItem_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("SLAItem_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SLAItem_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("SLAItem_SyncErrors", null, value);
				this.OnPropertyChanged("SLAItem_SyncErrors");
			}
		}
		
		/// <summary>
		/// N:1 lk_slaitembase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_createdby")]
		public XrmEbc.SystemUser lk_slaitembase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_slaitembase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_slaitembase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_createdonbehalfby")]
		public XrmEbc.SystemUser lk_slaitembase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_slaitembase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_slaitembase_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_slaitembase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_slaitembase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_slaitembase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_modifiedby")]
		public XrmEbc.SystemUser lk_slaitembase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_slaitembase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_slaitembase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_slaitembase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_slaitembase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_slaitembase_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_slaitembase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_slaitembase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 sla_slaitem_slaId
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_slaitem_slaId")]
		public XrmEbc.SLA sla_slaitem_slaId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SLA>("sla_slaitem_slaId", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sla_slaitem_slaId");
				this.SetRelatedEntity<XrmEbc.SLA>("sla_slaitem_slaId", null, value);
				this.OnPropertyChanged("sla_slaitem_slaId");
			}
		}
		
		/// <summary>
		/// N:1 slaitembase_workflowid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slaitembase_workflowid")]
		public XrmEbc.Workflow slaitembase_workflowid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Workflow>("slaitembase_workflowid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("slaitembase_workflowid");
				this.SetRelatedEntity<XrmEbc.Workflow>("slaitembase_workflowid", null, value);
				this.OnPropertyChanged("slaitembase_workflowid");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_SLAItem
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SLAItem")]
		public XrmEbc.TransactionCurrency TransactionCurrency_SLAItem
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.TransactionCurrency>("TransactionCurrency_SLAItem", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SLAItem(object anonymousType) : 
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
                        Attributes["slaitemid"] = base.Id;
                        break;
                    case "slaitemid":
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