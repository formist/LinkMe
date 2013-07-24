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

namespace LinkMe.Domain.Industries.Data
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
	public partial class IndustriesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIndustryEntity(IndustryEntity instance);
    partial void UpdateIndustryEntity(IndustryEntity instance);
    partial void DeleteIndustryEntity(IndustryEntity instance);
    partial void InsertIndustryAliasEntity(IndustryAliasEntity instance);
    partial void UpdateIndustryAliasEntity(IndustryAliasEntity instance);
    partial void DeleteIndustryAliasEntity(IndustryAliasEntity instance);
    #endregion
		
		public IndustriesDataContext() : 
				base(global::LinkMe.Domain.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IndustriesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IndustriesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IndustriesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IndustriesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<IndustryEntity> IndustryEntities
		{
			get
			{
				return this.GetTable<IndustryEntity>();
			}
		}
		
		internal System.Data.Linq.Table<IndustryAliasEntity> IndustryAliasEntities
		{
			get
			{
				return this.GetTable<IndustryAliasEntity>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Industry")]
	internal partial class IndustryEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _displayName;
		
		private string _keywordExpression;
		
		private string _shortDisplayName;
		
		private string _urlName;
		
		private EntitySet<IndustryAliasEntity> _IndustryAliasEntities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OndisplayNameChanging(string value);
    partial void OndisplayNameChanged();
    partial void OnkeywordExpressionChanging(string value);
    partial void OnkeywordExpressionChanged();
    partial void OnshortDisplayNameChanging(string value);
    partial void OnshortDisplayNameChanged();
    partial void OnurlNameChanging(string value);
    partial void OnurlNameChanged();
    #endregion
		
		public IndustryEntity()
		{
			this._IndustryAliasEntities = new EntitySet<IndustryAliasEntity>(new Action<IndustryAliasEntity>(this.attach_IndustryAliasEntities), new Action<IndustryAliasEntity>(this.detach_IndustryAliasEntities));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_displayName", DbType="NVarChar(200) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string displayName
		{
			get
			{
				return this._displayName;
			}
			set
			{
				if ((this._displayName != value))
				{
					this.OndisplayNameChanging(value);
					this.SendPropertyChanging();
					this._displayName = value;
					this.SendPropertyChanged("displayName");
					this.OndisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keywordExpression", DbType="NVarChar(1000)", UpdateCheck=UpdateCheck.Never)]
		public string keywordExpression
		{
			get
			{
				return this._keywordExpression;
			}
			set
			{
				if ((this._keywordExpression != value))
				{
					this.OnkeywordExpressionChanging(value);
					this.SendPropertyChanging();
					this._keywordExpression = value;
					this.SendPropertyChanged("keywordExpression");
					this.OnkeywordExpressionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_shortDisplayName", DbType="NVarChar(200) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string shortDisplayName
		{
			get
			{
				return this._shortDisplayName;
			}
			set
			{
				if ((this._shortDisplayName != value))
				{
					this.OnshortDisplayNameChanging(value);
					this.SendPropertyChanging();
					this._shortDisplayName = value;
					this.SendPropertyChanged("shortDisplayName");
					this.OnshortDisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_urlName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string urlName
		{
			get
			{
				return this._urlName;
			}
			set
			{
				if ((this._urlName != value))
				{
					this.OnurlNameChanging(value);
					this.SendPropertyChanging();
					this._urlName = value;
					this.SendPropertyChanged("urlName");
					this.OnurlNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IndustryEntity_IndustryAliasEntity", Storage="_IndustryAliasEntities", ThisKey="id", OtherKey="industryId")]
		public EntitySet<IndustryAliasEntity> IndustryAliasEntities
		{
			get
			{
				return this._IndustryAliasEntities;
			}
			set
			{
				this._IndustryAliasEntities.Assign(value);
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
		
		private void attach_IndustryAliasEntities(IndustryAliasEntity entity)
		{
			this.SendPropertyChanging();
			entity.IndustryEntity = this;
		}
		
		private void detach_IndustryAliasEntities(IndustryAliasEntity entity)
		{
			this.SendPropertyChanging();
			entity.IndustryEntity = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.IndustryAlias")]
	internal partial class IndustryAliasEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private System.Guid _industryId;
		
		private string _displayName;
		
		private string _urlName;
		
		private EntityRef<IndustryEntity> _IndustryEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnindustryIdChanging(System.Guid value);
    partial void OnindustryIdChanged();
    partial void OndisplayNameChanging(string value);
    partial void OndisplayNameChanged();
    partial void OnurlNameChanging(string value);
    partial void OnurlNameChanged();
    #endregion
		
		public IndustryAliasEntity()
		{
			this._IndustryEntity = default(EntityRef<IndustryEntity>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_industryId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid industryId
		{
			get
			{
				return this._industryId;
			}
			set
			{
				if ((this._industryId != value))
				{
					if (this._IndustryEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnindustryIdChanging(value);
					this.SendPropertyChanging();
					this._industryId = value;
					this.SendPropertyChanged("industryId");
					this.OnindustryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_displayName", DbType="VarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string displayName
		{
			get
			{
				return this._displayName;
			}
			set
			{
				if ((this._displayName != value))
				{
					this.OndisplayNameChanging(value);
					this.SendPropertyChanging();
					this._displayName = value;
					this.SendPropertyChanged("displayName");
					this.OndisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_urlName", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
		public string urlName
		{
			get
			{
				return this._urlName;
			}
			set
			{
				if ((this._urlName != value))
				{
					this.OnurlNameChanging(value);
					this.SendPropertyChanging();
					this._urlName = value;
					this.SendPropertyChanged("urlName");
					this.OnurlNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="IndustryEntity_IndustryAliasEntity", Storage="_IndustryEntity", ThisKey="industryId", OtherKey="id", IsForeignKey=true)]
		public IndustryEntity IndustryEntity
		{
			get
			{
				return this._IndustryEntity.Entity;
			}
			set
			{
				IndustryEntity previousValue = this._IndustryEntity.Entity;
				if (((previousValue != value) 
							|| (this._IndustryEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._IndustryEntity.Entity = null;
						previousValue.IndustryAliasEntities.Remove(this);
					}
					this._IndustryEntity.Entity = value;
					if ((value != null))
					{
						value.IndustryAliasEntities.Add(this);
						this._industryId = value.id;
					}
					else
					{
						this._industryId = default(System.Guid);
					}
					this.SendPropertyChanged("IndustryEntity");
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
