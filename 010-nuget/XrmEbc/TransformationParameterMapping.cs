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
	/// In a data map, defines parameters for a transformation.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("transformationparametermapping")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class TransformationParameterMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Data = "data";
			public const string DataTypeCode = "datatypecode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ParameterArrayIndex = "parameterarrayindex";
			public const string ParameterSequence = "parametersequence";
			public const string ParameterTypeCode = "parametertypecode";
			public const string TransformationMappingId = "transformationmappingid";
			public const string TransformationParameterMappingId = "transformationparametermappingid";
			public const string Id = "transformationparametermappingid";
			public const string lk_transformationparametermapping_createdby = "lk_transformationparametermapping_createdby";
			public const string lk_transformationparametermapping_createdonbehalfby = "lk_transformationparametermapping_createdonbehalfby";
			public const string lk_transformationparametermapping_modifiedby = "lk_transformationparametermapping_modifiedby";
			public const string lk_transformationparametermapping_modifiedonbehalfby = "lk_transformationparametermapping_modifiedonbehalfby";
			public const string TransformationParameterMapping_TransformationMapping = "TransformationParameterMapping_TransformationMapping";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TransformationParameterMapping() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "transformationparametermapping";
		
		public const int EntityTypeCode = 4427;
		
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
		/// Unique identifier of the user who created the parameter mapping.
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
		/// Date and time when the transformation parameter mapping was created.
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
		/// Unique identifier of the delegate user who created the transformationparametermapping.
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
		/// Transformation data for transformation parameter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("data")]
		public string Data
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("data");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Data");
				this.SetAttributeValue("data", value);
				this.OnPropertyChanged("Data");
			}
		}
		
		/// <summary>
		/// Data type of the transformation parameter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datatypecode")]
		public object DataTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("datatypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DataTypeCode");
				this.SetAttributeValue("datatypecode", value);
				this.OnPropertyChanged("DataTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the transformation parameter mapping.
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
		/// Date and time when the transformation parameter mapping was last modified.
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
		/// Unique identifier of the delegate user who last modified the transformationparametermapping.
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
		/// Index of the array if the input parameter is an array.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parameterarrayindex")]
		public System.Nullable<int> ParameterArrayIndex
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("parameterarrayindex");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParameterArrayIndex");
				this.SetAttributeValue("parameterarrayindex", value);
				this.OnPropertyChanged("ParameterArrayIndex");
			}
		}
		
		/// <summary>
		/// Parameter sequence number.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parametersequence")]
		public System.Nullable<int> ParameterSequence
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("parametersequence");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParameterSequence");
				this.SetAttributeValue("parametersequence", value);
				this.OnPropertyChanged("ParameterSequence");
			}
		}
		
		/// <summary>
		/// Type of transformation parameter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parametertypecode")]
		public object ParameterTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("parametertypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParameterTypeCode");
				this.SetAttributeValue("parametertypecode", value);
				this.OnPropertyChanged("ParameterTypeCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the transformation with which the parameter is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationmappingid")]
		public Microsoft.Xrm.Sdk.EntityReference TransformationMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transformationmappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransformationMappingId");
				this.SetAttributeValue("transformationmappingid", value);
				this.OnPropertyChanged("TransformationMappingId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the transformation parameter mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationparametermappingid")]
		public System.Nullable<System.Guid> TransformationParameterMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("transformationparametermappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransformationParameterMappingId");
				this.SetAttributeValue("transformationparametermappingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TransformationParameterMappingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationparametermappingid")]
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
				this.TransformationParameterMappingId = value;
			}
		}
		
		/// <summary>
		/// 1:N LookUpMapping_TransformationParameterMapping
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("LookUpMapping_TransformationParameterMapping")]
		public System.Collections.Generic.IEnumerable<XrmEbc.LookUpMapping> LookUpMapping_TransformationParameterMapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.LookUpMapping>("LookUpMapping_TransformationParameterMapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LookUpMapping_TransformationParameterMapping");
				this.SetRelatedEntities<XrmEbc.LookUpMapping>("LookUpMapping_TransformationParameterMapping", null, value);
				this.OnPropertyChanged("LookUpMapping_TransformationParameterMapping");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_transformationparametermapping
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transformationparametermapping")]
		public System.Collections.Generic.IEnumerable<XrmEbc.UserEntityInstanceData> userentityinstancedata_transformationparametermapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<XrmEbc.UserEntityInstanceData>("userentityinstancedata_transformationparametermapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_transformationparametermapping");
				this.SetRelatedEntities<XrmEbc.UserEntityInstanceData>("userentityinstancedata_transformationparametermapping", null, value);
				this.OnPropertyChanged("userentityinstancedata_transformationparametermapping");
			}
		}
		
		/// <summary>
		/// N:1 lk_transformationparametermapping_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdby")]
		public XrmEbc.SystemUser lk_transformationparametermapping_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_transformationparametermapping_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_transformationparametermapping_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdonbehalfby")]
		public XrmEbc.SystemUser lk_transformationparametermapping_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_transformationparametermapping_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_transformationparametermapping_createdonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_transformationparametermapping_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_transformationparametermapping_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_transformationparametermapping_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedby")]
		public XrmEbc.SystemUser lk_transformationparametermapping_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_transformationparametermapping_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_transformationparametermapping_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedonbehalfby")]
		public XrmEbc.SystemUser lk_transformationparametermapping_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SystemUser>("lk_transformationparametermapping_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_transformationparametermapping_modifiedonbehalfby");
				this.SetRelatedEntity<XrmEbc.SystemUser>("lk_transformationparametermapping_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_transformationparametermapping_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 TransformationParameterMapping_TransformationMapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationmappingid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransformationParameterMapping_TransformationMapping")]
		public XrmEbc.TransformationMapping TransformationParameterMapping_TransformationMapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.TransformationMapping>("TransformationParameterMapping_TransformationMapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransformationParameterMapping_TransformationMapping");
				this.SetRelatedEntity<XrmEbc.TransformationMapping>("TransformationParameterMapping_TransformationMapping", null, value);
				this.OnPropertyChanged("TransformationParameterMapping_TransformationMapping");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TransformationParameterMapping(object anonymousType) : 
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
                        Attributes["transformationparametermappingid"] = base.Id;
                        break;
                    case "transformationparametermappingid":
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