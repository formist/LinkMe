﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinkMe.Domain.Roles.Communications.Campaigns.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LinkMe")]
	public partial class CampaignsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCampaignTemplateEntity(CampaignTemplateEntity instance);
    partial void UpdateCampaignTemplateEntity(CampaignTemplateEntity instance);
    partial void DeleteCampaignTemplateEntity(CampaignTemplateEntity instance);
    partial void InsertCampaignCriteriaEntity(CampaignCriteriaEntity instance);
    partial void UpdateCampaignCriteriaEntity(CampaignCriteriaEntity instance);
    partial void DeleteCampaignCriteriaEntity(CampaignCriteriaEntity instance);
    partial void InsertCampaignCriteriaSetEntity(CampaignCriteriaSetEntity instance);
    partial void UpdateCampaignCriteriaSetEntity(CampaignCriteriaSetEntity instance);
    partial void DeleteCampaignCriteriaSetEntity(CampaignCriteriaSetEntity instance);
    partial void InsertCampaignEntity(CampaignEntity instance);
    partial void UpdateCampaignEntity(CampaignEntity instance);
    partial void DeleteCampaignEntity(CampaignEntity instance);
    #endregion
		
		public CampaignsDataContext() : 
				base(global::LinkMe.Domain.Roles.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CampaignsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CampaignsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CampaignsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CampaignsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<CampaignTemplateEntity> CampaignTemplateEntities
		{
			get
			{
				return this.GetTable<CampaignTemplateEntity>();
			}
		}
		
		internal System.Data.Linq.Table<CampaignCriteriaEntity> CampaignCriteriaEntities
		{
			get
			{
				return this.GetTable<CampaignCriteriaEntity>();
			}
		}
		
		internal System.Data.Linq.Table<CampaignCriteriaSetEntity> CampaignCriteriaSetEntities
		{
			get
			{
				return this.GetTable<CampaignCriteriaSetEntity>();
			}
		}
		
		internal System.Data.Linq.Table<CampaignEntity> CampaignEntities
		{
			get
			{
				return this.GetTable<CampaignEntity>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CampaignTemplate")]
	internal partial class CampaignTemplateEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _subject;
		
		private string _body;
		
		private EntityRef<CampaignEntity> _CampaignEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnsubjectChanging(string value);
    partial void OnsubjectChanged();
    partial void OnbodyChanging(string value);
    partial void OnbodyChanged();
    #endregion
		
		public CampaignTemplateEntity()
		{
			this._CampaignEntity = default(EntityRef<CampaignEntity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					if (this._CampaignEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string subject
		{
			get
			{
				return this._subject;
			}
			set
			{
				if ((this._subject != value))
				{
					this.OnsubjectChanging(value);
					this.SendPropertyChanging();
					this._subject = value;
					this.SendPropertyChanged("subject");
					this.OnsubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string body
		{
			get
			{
				return this._body;
			}
			set
			{
				if ((this._body != value))
				{
					this.OnbodyChanging(value);
					this.SendPropertyChanging();
					this._body = value;
					this.SendPropertyChanged("body");
					this.OnbodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CampaignEntity_CampaignTemplateEntity", Storage="_CampaignEntity", ThisKey="id", OtherKey="id", IsForeignKey=true)]
		public CampaignEntity CampaignEntity
		{
			get
			{
				return this._CampaignEntity.Entity;
			}
			set
			{
				CampaignEntity previousValue = this._CampaignEntity.Entity;
				if (((previousValue != value) 
							|| (this._CampaignEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CampaignEntity.Entity = null;
						previousValue.CampaignTemplateEntity = null;
					}
					this._CampaignEntity.Entity = value;
					if ((value != null))
					{
						value.CampaignTemplateEntity = this;
						this._id = value.id;
					}
					else
					{
						this._id = default(System.Guid);
					}
					this.SendPropertyChanged("CampaignEntity");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CampaignCriteria")]
	internal partial class CampaignCriteriaEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _name;
		
		private object _value;
		
		private EntityRef<CampaignCriteriaSetEntity> _CampaignCriteriaSetEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnvalueChanging(object value);
    partial void OnvalueChanged();
    #endregion
		
		public CampaignCriteriaEntity()
		{
			this._CampaignCriteriaSetEntity = default(EntityRef<CampaignCriteriaSetEntity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					if (this._CampaignCriteriaSetEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Variant", UpdateCheck=UpdateCheck.Never)]
		public object value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CampaignCriteriaSetEntity_CampaignCriteriaEntity", Storage="_CampaignCriteriaSetEntity", ThisKey="id", OtherKey="id", IsForeignKey=true)]
		public CampaignCriteriaSetEntity CampaignCriteriaSetEntity
		{
			get
			{
				return this._CampaignCriteriaSetEntity.Entity;
			}
			set
			{
				CampaignCriteriaSetEntity previousValue = this._CampaignCriteriaSetEntity.Entity;
				if (((previousValue != value) 
							|| (this._CampaignCriteriaSetEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CampaignCriteriaSetEntity.Entity = null;
						previousValue.CampaignCriteriaEntities.Remove(this);
					}
					this._CampaignCriteriaSetEntity.Entity = value;
					if ((value != null))
					{
						value.CampaignCriteriaEntities.Add(this);
						this._id = value.id;
					}
					else
					{
						this._id = default(System.Guid);
					}
					this.SendPropertyChanged("CampaignCriteriaSetEntity");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CampaignCriteriaSet")]
	internal partial class CampaignCriteriaSetEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private System.Guid _campaignId;
		
		private EntitySet<CampaignCriteriaEntity> _CampaignCriteriaEntities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OncampaignIdChanging(System.Guid value);
    partial void OncampaignIdChanged();
    #endregion
		
		public CampaignCriteriaSetEntity()
		{
			this._CampaignCriteriaEntities = new EntitySet<CampaignCriteriaEntity>(new Action<CampaignCriteriaEntity>(this.attach_CampaignCriteriaEntities), new Action<CampaignCriteriaEntity>(this.detach_CampaignCriteriaEntities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_campaignId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid campaignId
		{
			get
			{
				return this._campaignId;
			}
			set
			{
				if ((this._campaignId != value))
				{
					this.OncampaignIdChanging(value);
					this.SendPropertyChanging();
					this._campaignId = value;
					this.SendPropertyChanged("campaignId");
					this.OncampaignIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CampaignCriteriaSetEntity_CampaignCriteriaEntity", Storage="_CampaignCriteriaEntities", ThisKey="id", OtherKey="id")]
		public EntitySet<CampaignCriteriaEntity> CampaignCriteriaEntities
		{
			get
			{
				return this._CampaignCriteriaEntities;
			}
			set
			{
				this._CampaignCriteriaEntities.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_CampaignCriteriaEntities(CampaignCriteriaEntity entity)
		{
			this.SendPropertyChanging();
			entity.CampaignCriteriaSetEntity = this;
		}
		
		private void detach_CampaignCriteriaEntities(CampaignCriteriaEntity entity)
		{
			this.SendPropertyChanging();
			entity.CampaignCriteriaSetEntity = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Campaign")]
	internal partial class CampaignEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _name;
		
		private System.DateTime _createdTime;
		
		private System.Guid _createdBy;
		
		private int _status;
		
		private int _category;
		
		private string _query;
		
		private System.Nullable<System.Guid> _communicationCategoryId;
		
		private System.Nullable<System.Guid> _communicationDefinitionId;
		
		private EntityRef<CampaignTemplateEntity> _CampaignTemplateEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncreatedTimeChanging(System.DateTime value);
    partial void OncreatedTimeChanged();
    partial void OncreatedByChanging(System.Guid value);
    partial void OncreatedByChanged();
    partial void OnstatusChanging(int value);
    partial void OnstatusChanged();
    partial void OncategoryChanging(int value);
    partial void OncategoryChanged();
    partial void OnqueryChanging(string value);
    partial void OnqueryChanged();
    partial void OncommunicationCategoryIdChanging(System.Nullable<System.Guid> value);
    partial void OncommunicationCategoryIdChanged();
    partial void OncommunicationDefinitionIdChanging(System.Nullable<System.Guid> value);
    partial void OncommunicationDefinitionIdChanged();
    #endregion
		
		public CampaignEntity()
		{
			this._CampaignTemplateEntity = default(EntityRef<CampaignTemplateEntity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createdTime", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime createdTime
		{
			get
			{
				return this._createdTime;
			}
			set
			{
				if ((this._createdTime != value))
				{
					this.OncreatedTimeChanging(value);
					this.SendPropertyChanging();
					this._createdTime = value;
					this.SendPropertyChanged("createdTime");
					this.OncreatedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createdBy", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid createdBy
		{
			get
			{
				return this._createdBy;
			}
			set
			{
				if ((this._createdBy != value))
				{
					this.OncreatedByChanging(value);
					this.SendPropertyChanging();
					this._createdBy = value;
					this.SendPropertyChanged("createdBy");
					this.OncreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_query", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string query
		{
			get
			{
				return this._query;
			}
			set
			{
				if ((this._query != value))
				{
					this.OnqueryChanging(value);
					this.SendPropertyChanging();
					this._query = value;
					this.SendPropertyChanged("query");
					this.OnqueryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_communicationCategoryId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> communicationCategoryId
		{
			get
			{
				return this._communicationCategoryId;
			}
			set
			{
				if ((this._communicationCategoryId != value))
				{
					this.OncommunicationCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._communicationCategoryId = value;
					this.SendPropertyChanged("communicationCategoryId");
					this.OncommunicationCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_communicationDefinitionId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> communicationDefinitionId
		{
			get
			{
				return this._communicationDefinitionId;
			}
			set
			{
				if ((this._communicationDefinitionId != value))
				{
					this.OncommunicationDefinitionIdChanging(value);
					this.SendPropertyChanging();
					this._communicationDefinitionId = value;
					this.SendPropertyChanged("communicationDefinitionId");
					this.OncommunicationDefinitionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CampaignEntity_CampaignTemplateEntity", Storage="_CampaignTemplateEntity", ThisKey="id", OtherKey="id", IsUnique=true, IsForeignKey=false)]
		public CampaignTemplateEntity CampaignTemplateEntity
		{
			get
			{
				return this._CampaignTemplateEntity.Entity;
			}
			set
			{
				CampaignTemplateEntity previousValue = this._CampaignTemplateEntity.Entity;
				if (((previousValue != value) 
							|| (this._CampaignTemplateEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CampaignTemplateEntity.Entity = null;
						previousValue.CampaignEntity = null;
					}
					this._CampaignTemplateEntity.Entity = value;
					if ((value != null))
					{
						value.CampaignEntity = this;
					}
					this.SendPropertyChanged("CampaignTemplateEntity");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
