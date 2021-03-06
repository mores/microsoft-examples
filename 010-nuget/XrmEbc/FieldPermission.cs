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
	/// Group of privileges used to categorize users to provide appropriate access to secured columns.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fieldpermission")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class FieldPermission : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string AttributeLogicalName = "attributelogicalname";
			public const string CanCreate = "cancreate";
			public const string CanRead = "canread";
			public const string CanUpdate = "canupdate";
			public const string ComponentState = "componentstate";
			public const string EntityName = "entityname";
			public const string FieldPermissionId = "fieldpermissionid";
			public const string Id = "fieldpermissionid";
			public const string FieldPermissionIdUnique = "fieldpermissionidunique";
			public const string FieldSecurityProfileId = "fieldsecurityprofileid";
			public const string IsManaged = "ismanaged";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
			public const string lk_fieldpermission_fieldsecurityprofileid = "lk_fieldpermission_fieldsecurityprofileid";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public FieldPermission() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "fieldpermission";
		
		public const int EntityTypeCode = 1201;
		
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
		/// Attribute Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributelogicalname")]
		public string AttributeLogicalName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("attributelogicalname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AttributeLogicalName");
				this.SetAttributeValue("attributelogicalname", value);
				this.OnPropertyChanged("AttributeLogicalName");
			}
		}
		
		/// <summary>
		/// Can this Profile create the attribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cancreate")]
		public object CanCreate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("cancreate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanCreate");
				this.SetAttributeValue("cancreate", value);
				this.OnPropertyChanged("CanCreate");
			}
		}
		
		/// <summary>
		/// Can this Profile read the attribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canread")]
		public object CanRead
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("canread");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanRead");
				this.SetAttributeValue("canread", value);
				this.OnPropertyChanged("CanRead");
			}
		}
		
		/// <summary>
		/// Can this Profile update the attribute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canupdate")]
		public object CanUpdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("canupdate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CanUpdate");
				this.SetAttributeValue("canupdate", value);
				this.OnPropertyChanged("CanUpdate");
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
		/// Entity name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityname")]
		public string EntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityName");
				this.SetAttributeValue("entityname", value);
				this.OnPropertyChanged("EntityName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Field Permission.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpermissionid")]
		public System.Nullable<System.Guid> FieldPermissionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldpermissionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FieldPermissionId");
				this.SetAttributeValue("fieldpermissionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("FieldPermissionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpermissionid")]
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
				this.FieldPermissionId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpermissionidunique")]
		public System.Nullable<System.Guid> FieldPermissionIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldpermissionidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of profile to which this privilege belongs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
		public Microsoft.Xrm.Sdk.EntityReference FieldSecurityProfileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("fieldsecurityprofileid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FieldSecurityProfileId");
				this.SetAttributeValue("fieldsecurityprofileid", value);
				this.OnPropertyChanged("FieldSecurityProfileId");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
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
		/// 
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
		/// 1:N FieldPermission_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FieldPermission_SyncErrors")]
		public System.Collections.Generic.IEnumerable<XrmEbc.SyncError> FieldPermission_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.SyncError>("FieldPermission_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FieldPermission_SyncErrors");
				this.SetRelatedEntities<XrmEbc.SyncError>("FieldPermission_SyncErrors", null, value);
				this.OnPropertyChanged("FieldPermission_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_fieldpermission
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fieldpermission")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> userentityinstancedata_fieldpermission
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("userentityinstancedata_fieldpermission", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_fieldpermission");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("userentityinstancedata_fieldpermission", null, value);
				this.OnPropertyChanged("userentityinstancedata_fieldpermission");
			}
		}
		
		/// <summary>
		/// N:1 lk_fieldpermission_fieldsecurityprofileid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldpermission_fieldsecurityprofileid")]
		public XrmEbc.FieldSecurityProfile lk_fieldpermission_fieldsecurityprofileid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.FieldSecurityProfile>("lk_fieldpermission_fieldsecurityprofileid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_fieldpermission_fieldsecurityprofileid");
				this.SetRelatedEntity<XrmEbc.FieldSecurityProfile>("lk_fieldpermission_fieldsecurityprofileid", null, value);
				this.OnPropertyChanged("lk_fieldpermission_fieldsecurityprofileid");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public FieldPermission(object anonymousType) : 
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
                        Attributes["fieldpermissionid"] = base.Id;
                        break;
                    case "fieldpermissionid":
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