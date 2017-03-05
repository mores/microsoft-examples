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
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("textanalyticsentitymapping")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.2.1.8586")]
	public partial class TextAnalyticsEntityMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string AdvancedSimilarityRuleId = "advancedsimilarityruleid";
			public const string ComponentState = "componentstate";
			public const string Entity = "entity";
			public const string EntityDisplayName = "entitydisplayname";
			public const string EntityPickList = "entitypicklist";
			public const string Field = "field";
			public const string FieldDisplayName = "fielddisplayname";
			public const string FieldPickList = "fieldpicklist";
			public const string IsManaged = "ismanaged";
			public const string IsTextMatchMapping = "istextmatchmapping";
			public const string KnowledgeSearchModelId = "knowledgesearchmodelid";
			public const string ModelType = "modeltype";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string RelationshipName = "relationshipname";
			public const string SimilarityRuleId = "similarityruleid";
			public const string SolutionId = "solutionid";
			public const string TextAnalyticsEntityMappingId = "textanalyticsentitymappingid";
			public const string Id = "textanalyticsentitymappingid";
			public const string TextAnalyticsEntityMappingIdUnique = "textanalyticsentitymappingidunique";
			public const string TopicModelConfigurationId = "topicmodelconfigurationid";
			public const string advancedsimilarityrule_textanalyticsentitymapping = "advancedsimilarityrule_textanalyticsentitymapping";
			public const string knowledgesearchmodel_textanalyticsentitymapping = "knowledgesearchmodel_textanalyticsentitymapping";
			public const string organization_textanalyticsentitymapping = "organization_textanalyticsentitymapping";
			public const string similarityrule_textanalyticsentitymapping = "similarityrule_textanalyticsentitymapping";
			public const string topicmodelconfiguration_textanalyticsentitymapping = "topicmodelconfiguration_textanalyticsentitymapping";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TextAnalyticsEntityMapping() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "textanalyticsentitymapping";
		
		public const int EntityTypeCode = 9945;
		
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
		/// Advanced Similarity RuleId associated with entity mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedsimilarityruleid")]
		public Microsoft.Xrm.Sdk.EntityReference AdvancedSimilarityRuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("advancedsimilarityruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AdvancedSimilarityRuleId");
				this.SetAttributeValue("advancedsimilarityruleid", value);
				this.OnPropertyChanged("AdvancedSimilarityRuleId");
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
		/// Entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entity")]
		public string Entity
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entity");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Entity");
				this.SetAttributeValue("entity", value);
				this.OnPropertyChanged("Entity");
			}
		}
		
		/// <summary>
		/// Entity Display Name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitydisplayname")]
		public string EntityDisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entitydisplayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityDisplayName");
				this.SetAttributeValue("entitydisplayname", value);
				this.OnPropertyChanged("EntityDisplayName");
			}
		}
		
		/// <summary>
		/// Select Entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitypicklist")]
		public string EntityPickList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entitypicklist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityPickList");
				this.SetAttributeValue("entitypicklist", value);
				this.OnPropertyChanged("EntityPickList");
			}
		}
		
		/// <summary>
		/// Field
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("field")]
		public string Field
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("field");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Field");
				this.SetAttributeValue("field", value);
				this.OnPropertyChanged("Field");
			}
		}
		
		/// <summary>
		/// Field Display Name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fielddisplayname")]
		public string FieldDisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("fielddisplayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FieldDisplayName");
				this.SetAttributeValue("fielddisplayname", value);
				this.OnPropertyChanged("FieldDisplayName");
			}
		}
		
		/// <summary>
		/// Select Field
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpicklist")]
		public object FieldPickList
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("fieldpicklist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FieldPickList");
				this.SetAttributeValue("fieldpicklist", value);
				this.OnPropertyChanged("FieldPickList");
			}
		}
		
		/// <summary>
		/// Is Manageed
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
		/// Specify if the mapping is for text match or exact match
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istextmatchmapping")]
		public System.Nullable<bool> IsTextMatchMapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("istextmatchmapping");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsTextMatchMapping");
				this.SetAttributeValue("istextmatchmapping", value);
				this.OnPropertyChanged("IsTextMatchMapping");
			}
		}
		
		/// <summary>
		/// Knowledge Search Model associated with entity mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgesearchmodelid")]
		public Microsoft.Xrm.Sdk.EntityReference KnowledgeSearchModelId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("knowledgesearchmodelid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeSearchModelId");
				this.SetAttributeValue("knowledgesearchmodelid", value);
				this.OnPropertyChanged("KnowledgeSearchModelId");
			}
		}
		
		/// <summary>
		/// Model Type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modeltype")]
		public System.Nullable<int> ModelType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("modeltype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModelType");
				this.SetAttributeValue("modeltype", value);
				this.OnPropertyChanged("ModelType");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization associated with the Text Analytics Entity Mapping.
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
		/// Date and time when the record was created.
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
		/// Relationship Name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshipname")]
		public string RelationshipName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("relationshipname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RelationshipName");
				this.SetAttributeValue("relationshipname", value);
				this.OnPropertyChanged("RelationshipName");
			}
		}
		
		/// <summary>
		/// Similarity Rule associated with entity mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("similarityruleid")]
		public Microsoft.Xrm.Sdk.EntityReference SimilarityRuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("similarityruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SimilarityRuleId");
				this.SetAttributeValue("similarityruleid", value);
				this.OnPropertyChanged("SimilarityRuleId");
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("textanalyticsentitymappingid")]
		public System.Nullable<System.Guid> TextAnalyticsEntityMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("textanalyticsentitymappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TextAnalyticsEntityMappingId");
				this.SetAttributeValue("textanalyticsentitymappingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TextAnalyticsEntityMappingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("textanalyticsentitymappingid")]
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
				this.TextAnalyticsEntityMappingId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the Text Analytics Entity Mapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("textanalyticsentitymappingidunique")]
		public System.Nullable<System.Guid> TextAnalyticsEntityMappingIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("textanalyticsentitymappingidunique");
			}
		}
		
		/// <summary>
		/// Topic Model Configuration associated with entity mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelconfigurationid")]
		public Microsoft.Xrm.Sdk.EntityReference TopicModelConfigurationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("topicmodelconfigurationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TopicModelConfigurationId");
				this.SetAttributeValue("topicmodelconfigurationid", value);
				this.OnPropertyChanged("TopicModelConfigurationId");
			}
		}
		
		/// <summary>
		/// N:1 advancedsimilarityrule_textanalyticsentitymapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedsimilarityruleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("advancedsimilarityrule_textanalyticsentitymapping")]
		public XrmEbc.AdvancedSimilarityRule advancedsimilarityrule_textanalyticsentitymapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.AdvancedSimilarityRule>("advancedsimilarityrule_textanalyticsentitymapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("advancedsimilarityrule_textanalyticsentitymapping");
				this.SetRelatedEntity<XrmEbc.AdvancedSimilarityRule>("advancedsimilarityrule_textanalyticsentitymapping", null, value);
				this.OnPropertyChanged("advancedsimilarityrule_textanalyticsentitymapping");
			}
		}
		
		/// <summary>
		/// N:1 knowledgesearchmodel_textanalyticsentitymapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgesearchmodelid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("knowledgesearchmodel_textanalyticsentitymapping")]
		public XrmEbc.KnowledgeSearchModel knowledgesearchmodel_textanalyticsentitymapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.KnowledgeSearchModel>("knowledgesearchmodel_textanalyticsentitymapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("knowledgesearchmodel_textanalyticsentitymapping");
				this.SetRelatedEntity<XrmEbc.KnowledgeSearchModel>("knowledgesearchmodel_textanalyticsentitymapping", null, value);
				this.OnPropertyChanged("knowledgesearchmodel_textanalyticsentitymapping");
			}
		}
		
		/// <summary>
		/// N:1 organization_textanalyticsentitymapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_textanalyticsentitymapping")]
		public XrmEbc.Organization organization_textanalyticsentitymapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.Organization>("organization_textanalyticsentitymapping", null);
			}
		}
		
		/// <summary>
		/// N:1 similarityrule_textanalyticsentitymapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("similarityruleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("similarityrule_textanalyticsentitymapping")]
		public XrmEbc.SimilarityRule similarityrule_textanalyticsentitymapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.SimilarityRule>("similarityrule_textanalyticsentitymapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("similarityrule_textanalyticsentitymapping");
				this.SetRelatedEntity<XrmEbc.SimilarityRule>("similarityrule_textanalyticsentitymapping", null, value);
				this.OnPropertyChanged("similarityrule_textanalyticsentitymapping");
			}
		}
		
		/// <summary>
		/// N:1 topicmodelconfiguration_textanalyticsentitymapping
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("topicmodelconfigurationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("topicmodelconfiguration_textanalyticsentitymapping")]
		public XrmEbc.TopicModelConfiguration topicmodelconfiguration_textanalyticsentitymapping
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<XrmEbc.TopicModelConfiguration>("topicmodelconfiguration_textanalyticsentitymapping", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("topicmodelconfiguration_textanalyticsentitymapping");
				this.SetRelatedEntity<XrmEbc.TopicModelConfiguration>("topicmodelconfiguration_textanalyticsentitymapping", null, value);
				this.OnPropertyChanged("topicmodelconfiguration_textanalyticsentitymapping");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TextAnalyticsEntityMapping(object anonymousType) : 
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
                        Attributes["textanalyticsentitymappingid"] = base.Id;
                        break;
                    case "textanalyticsentitymappingid":
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