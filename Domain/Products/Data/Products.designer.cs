﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinkMe.Domain.Products.Data
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
	public partial class ProductsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProductCreditAdjustmentEntity(ProductCreditAdjustmentEntity instance);
    partial void UpdateProductCreditAdjustmentEntity(ProductCreditAdjustmentEntity instance);
    partial void DeleteProductCreditAdjustmentEntity(ProductCreditAdjustmentEntity instance);
    partial void InsertProductEntity(ProductEntity instance);
    partial void UpdateProductEntity(ProductEntity instance);
    partial void DeleteProductEntity(ProductEntity instance);
    #endregion
		
		public ProductsDataContext() : 
				base(global::LinkMe.Domain.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProductsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<ProductCreditAdjustmentEntity> ProductCreditAdjustmentEntities
		{
			get
			{
				return this.GetTable<ProductCreditAdjustmentEntity>();
			}
		}
		
		internal System.Data.Linq.Table<ProductEntity> ProductEntities
		{
			get
			{
				return this.GetTable<ProductEntity>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SplitGuids", IsComposable=true)]
		public IQueryable<SplitGuidsResult> SplitGuids([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string delimiter, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string input)
		{
			return this.CreateMethodCallQuery<SplitGuidsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), delimiter, input);
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductCreditAdjustment")]
	internal partial class ProductCreditAdjustmentEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _productId;
		
		private System.Guid _creditId;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<long> _duration;
		
		private EntityRef<ProductEntity> _ProductEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnproductIdChanging(System.Guid value);
    partial void OnproductIdChanged();
    partial void OncreditIdChanging(System.Guid value);
    partial void OncreditIdChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OndurationChanging(System.Nullable<long> value);
    partial void OndurationChanged();
    #endregion
		
		public ProductCreditAdjustmentEntity()
		{
			this._ProductEntity = default(EntityRef<ProductEntity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid productId
		{
			get
			{
				return this._productId;
			}
			set
			{
				if ((this._productId != value))
				{
					if (this._ProductEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnproductIdChanging(value);
					this.SendPropertyChanging();
					this._productId = value;
					this.SendPropertyChanged("productId");
					this.OnproductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creditId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid creditId
		{
			get
			{
				return this._creditId;
			}
			set
			{
				if ((this._creditId != value))
				{
					this.OncreditIdChanging(value);
					this.SendPropertyChanging();
					this._creditId = value;
					this.SendPropertyChanged("creditId");
					this.OncreditIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_duration", DbType="BigInt", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<long> duration
		{
			get
			{
				return this._duration;
			}
			set
			{
				if ((this._duration != value))
				{
					this.OndurationChanging(value);
					this.SendPropertyChanging();
					this._duration = value;
					this.SendPropertyChanged("duration");
					this.OndurationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_ProductCreditAdjustmentEntity", Storage="_ProductEntity", ThisKey="productId", OtherKey="id", IsForeignKey=true)]
		public ProductEntity ProductEntity
		{
			get
			{
				return this._ProductEntity.Entity;
			}
			set
			{
				ProductEntity previousValue = this._ProductEntity.Entity;
				if (((previousValue != value) 
							|| (this._ProductEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProductEntity.Entity = null;
						previousValue.ProductCreditAdjustmentEntities.Remove(this);
					}
					this._ProductEntity.Entity = value;
					if ((value != null))
					{
						value.ProductCreditAdjustmentEntities.Add(this);
						this._productId = value.id;
					}
					else
					{
						this._productId = default(System.Guid);
					}
					this.SendPropertyChanged("ProductEntity");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	internal partial class ProductEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _name;
		
		private bool _enabled;
		
		private int _userTypes;
		
		private decimal _price;
		
		private int _currency;
		
		private string _description;
		
		private EntitySet<ProductCreditAdjustmentEntity> _ProductCreditAdjustmentEntities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnenabledChanging(bool value);
    partial void OnenabledChanged();
    partial void OnuserTypesChanging(int value);
    partial void OnuserTypesChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OncurrencyChanging(int value);
    partial void OncurrencyChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public ProductEntity()
		{
			this._ProductCreditAdjustmentEntities = new EntitySet<ProductCreditAdjustmentEntity>(new Action<ProductCreditAdjustmentEntity>(this.attach_ProductCreditAdjustmentEntities), new Action<ProductCreditAdjustmentEntity>(this.detach_ProductCreditAdjustmentEntities));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_enabled", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool enabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if ((this._enabled != value))
				{
					this.OnenabledChanging(value);
					this.SendPropertyChanging();
					this._enabled = value;
					this.SendPropertyChanged("enabled");
					this.OnenabledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userTypes", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int userTypes
		{
			get
			{
				return this._userTypes;
			}
			set
			{
				if ((this._userTypes != value))
				{
					this.OnuserTypesChanging(value);
					this.SendPropertyChanging();
					this._userTypes = value;
					this.SendPropertyChanged("userTypes");
					this.OnuserTypesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(18,2) NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currency", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int currency
		{
			get
			{
				return this._currency;
			}
			set
			{
				if ((this._currency != value))
				{
					this.OncurrencyChanging(value);
					this.SendPropertyChanging();
					this._currency = value;
					this.SendPropertyChanged("currency");
					this.OncurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(200) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_ProductCreditAdjustmentEntity", Storage="_ProductCreditAdjustmentEntities", ThisKey="id", OtherKey="productId")]
		public EntitySet<ProductCreditAdjustmentEntity> ProductCreditAdjustmentEntities
		{
			get
			{
				return this._ProductCreditAdjustmentEntities;
			}
			set
			{
				this._ProductCreditAdjustmentEntities.Assign(value);
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
		
		private void attach_ProductCreditAdjustmentEntities(ProductCreditAdjustmentEntity entity)
		{
			this.SendPropertyChanging();
			entity.ProductEntity = this;
		}
		
		private void detach_ProductCreditAdjustmentEntities(ProductCreditAdjustmentEntity entity)
		{
			this.SendPropertyChanging();
			entity.ProductEntity = null;
		}
	}
	
	public partial class SplitGuidsResult
	{
		
		private System.Nullable<System.Guid> _value;
		
		public SplitGuidsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this._value = value;
				}
			}
		}
	}
}
#pragma warning restore 1591