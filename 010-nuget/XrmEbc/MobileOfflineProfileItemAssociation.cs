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
	/// Information on relationships to be used to follow related entity's records for mobile offline profile item.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("mobileofflineprofileitemassociation")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class MobileOfflineProfileItemAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string IntroducedVersion = "introducedversion";
			public const string IsManaged = "ismanaged";
			public const string IsValidated = "isvalidated";
			public const string MobileOfflineProfileItemAssociationId = "mobileofflineprofileitemassociationid";
			public const string Id = "mobileofflineprofileitemassociationid";
			public const string MobileOfflineProfileItemAssociationIdUnique = "mobileofflineprofileitemassociationidunique";
			public const string MobileOfflineProfileItemId = "mobileofflineprofileitemid";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ProcessId = "processid";
			public const string ProfileItemAssociationEntityFilter = "profileitemassociationentityfilter";
			public const string PublishedOn = "publishedon";
			public const string RelationshipData = "relationshipdata";
			public const string RelationshipDisplayName = "relationshipdisplayname";
			public const string RelationshipId = "relationshipid";
			public const string RelationshipName = "relationshipname";
			public const string SelectedRelationShipsSchema = "selectedrelationshipsschema";
			public const string SolutionId = "solutionid";
			public const string StageId = "stageid";
			public const string TraversedPath = "traversedpath";
			public const string VersionNumber = "versionnumber";
			public const string lk_MobileOfflineProfileItemAssociation_createdby = "lk_MobileOfflineProfileItemAssociation_createdby";
			public const string lk_mobileofflineprofileitemassociation_createdonbehalfby = "lk_mobileofflineprofileitemassociation_createdonbehalfby";
			public const string lk_mobileofflineprofileitemassociation_modifiedby = "lk_mobileofflineprofileitemassociation_modifiedby";
			public const string lk_mobileofflineprofileitemassociation_modifiedonbehalfby = "lk_mobileofflineprofileitemassociation_modifiedonbehalfby";
			public const string MobileOfflineProfileItem_MobileOfflineProfileItemAssociation = "MobileOfflineProfileItem_MobileOfflineProfileItemAssociation";
			public const string MobileOfflineProfileItemAssociation_organization = "MobileOfflineProfileItemAssociation_organization";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MobileOfflineProfileItemAssociation() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "mobileofflineprofileitemassociation";
		
		public const int EntityTypeCode = 9868;
		
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
		/// Version in which the Mobile offline Profile Item Association is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
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
		/// Information about whether profile item association is validated or not
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidated")]
		public System.Nullable<bool> IsValidated
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvalidated");
			}
		}
		
		/// <summary>
		/// Unique identifier of the mobile offline profile item associaition.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemassociationid")]
		public System.Nullable<System.Guid> MobileOfflineProfileItemAssociationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("mobileofflineprofileitemassociationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileItemAssociationId");
				this.SetAttributeValue("mobileofflineprofileitemassociationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("MobileOfflineProfileItemAssociationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemassociationid")]
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
				this.MobileOfflineProfileItemAssociationId = value;
			}
		}
		
		/// <summary>
		/// For Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemassociationidunique")]
		public System.Nullable<System.Guid> MobileOfflineProfileItemAssociationIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("mobileofflineprofileitemassociationidunique");
			}
		}
		
		/// <summary>
		/// Id of the parent profile item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemid")]
		public Microsoft.Xrm.Sdk.EntityReference MobileOfflineProfileItemId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("mobileofflineprofileitemid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileItemId");
				this.SetAttributeValue("mobileofflineprofileitemid", value);
				this.OnPropertyChanged("MobileOfflineProfileItemId");
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
		/// Shows who updated the record on behalf of another user.
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
		/// Enter the name of the mobile offline profile item association.
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
		/// Unique identifier of the organization associated with the Mobile Offline Profile Item Association.
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
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public System.Nullable<System.Guid> ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
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
		/// Profile item association entity filter criteria.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profileitemassociationentityfilter")]
		public string ProfileItemAssociationEntityFilter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("profileitemassociationentityfilter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileItemAssociationEntityFilter");
				this.SetAttributeValue("profileitemassociationentityfilter", value);
				this.OnPropertyChanged("ProfileItemAssociationEntityFilter");
			}
		}
		
		/// <summary>
		/// Displays the last published date time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
		public System.Nullable<System.DateTime> PublishedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon");
			}
		}
		
		/// <summary>
		/// Internal Use Only
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipdata")]
		public string RelationshipData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("relationshipdata");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipData");
				this.SetAttributeValue("relationshipdata", value);
				this.OnPropertyChanged("RelationshipData");
			}
		}
		
		/// <summary>
		/// Entity relationship schema name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipdisplayname")]
		public string RelationshipDisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("relationshipdisplayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipDisplayName");
				this.SetAttributeValue("relationshipdisplayname", value);
				this.OnPropertyChanged("RelationshipDisplayName");
			}
		}
		
		/// <summary>
		/// Shows the relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipid")]
		public System.Nullable<System.Guid> RelationshipId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("relationshipid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipId");
				this.SetAttributeValue("relationshipid", value);
				this.OnPropertyChanged("RelationshipId");
			}
		}
		
		/// <summary>
		/// Display name of entity relationship
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipname")]
		public string RelationshipName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("relationshipname");
			}
		}
		
		/// <summary>
		/// List of relationships of entity selected in parent profile item
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("selectedrelationshipsschema")]
		public object SelectedRelationShipsSchema
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("selectedrelationshipsschema");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SelectedRelationShipsSchema");
				this.SetAttributeValue("selectedrelationshipsschema", value);
				this.OnPropertyChanged("SelectedRelationShipsSchema");
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
		/// Shows the ID of the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
		public System.Nullable<System.Guid> StageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageId");
				this.SetAttributeValue("stageid", value);
				this.OnPropertyChanged("StageId");
			}
		}
		
		/// <summary>
		/// For internal use only.
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
		/// Version number of the Mobile Offline profileitemassociation.
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
		/// N:1 lk_MobileOfflineProfileItemAssociation_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_MobileOfflineProfileItemAssociation_createdby")]
		public XrmEbc.SystemUser lk_MobileOfflineProfileItemAssociation_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_MobileOfflineProfileItemAssociation_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitemassociation_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitemassociation_createdonbehalfby")]
		public XrmEbc.SystemUser lk_mobileofflineprofileitemassociation_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_mobileofflineprofileitemassociation_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_mobileofflineprofileitemassociation_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_mobileofflineprofileitemassociation_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_mobileofflineprofileitemassociation_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitemassociation_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitemassociation_modifiedby")]
		public XrmEbc.SystemUser lk_mobileofflineprofileitemassociation_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_mobileofflineprofileitemassociation_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_mobileofflineprofileitemassociation_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mobileofflineprofileitemassociation_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_mobileofflineprofileitemassociation_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_mobileofflineprofileitemassociation_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_mobileofflineprofileitemassociation_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_mobileofflineprofileitemassociation_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_mobileofflineprofileitemassociation_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 MobileOfflineProfileItem_MobileOfflineProfileItemAssociation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileofflineprofileitemid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation")]
		public XrmEbc.MobileOfflineProfileItem MobileOfflineProfileItem_MobileOfflineProfileItemAssociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.MobileOfflineProfileItem>("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation");
				this.SetRelatedEntity<XrmEbc.MobileOfflineProfileItem>("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation", null, value);
				this.OnPropertyChanged("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation");
			}
		}
		
		/// <summary>
		/// N:1 MobileOfflineProfileItemAssociation_organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MobileOfflineProfileItemAssociation_organization")]
		public XrmEbc.Organization MobileOfflineProfileItemAssociation_organization
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("MobileOfflineProfileItemAssociation_organization", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MobileOfflineProfileItemAssociation(object anonymousType) : 
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
                        Attributes["mobileofflineprofileitemassociationid"] = base.Id;
                        break;
                    case "mobileofflineprofileitemassociationid":
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