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

namespace LinkMe.Domain.Credits.Data
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
	internal partial class CreditsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCreditEntity(CreditEntity instance);
    partial void UpdateCreditEntity(CreditEntity instance);
    partial void DeleteCreditEntity(CreditEntity instance);
    partial void InsertCreditAllocationEntity(CreditAllocationEntity instance);
    partial void UpdateCreditAllocationEntity(CreditAllocationEntity instance);
    partial void DeleteCreditAllocationEntity(CreditAllocationEntity instance);
    partial void InsertCandidateAccessPurchaseEntity(CandidateAccessPurchaseEntity instance);
    partial void UpdateCandidateAccessPurchaseEntity(CandidateAccessPurchaseEntity instance);
    partial void DeleteCandidateAccessPurchaseEntity(CandidateAccessPurchaseEntity instance);
    #endregion
		
		public CreditsDataContext() : 
				base(global::LinkMe.Domain.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CreditsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CreditsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CreditsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CreditsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<CreditEntity> CreditEntities
		{
			get
			{
				return this.GetTable<CreditEntity>();
			}
		}
		
		internal System.Data.Linq.Table<CreditAllocationEntity> CreditAllocationEntities
		{
			get
			{
				return this.GetTable<CreditAllocationEntity>();
			}
		}
		
		internal System.Data.Linq.Table<CandidateAccessPurchaseEntity> CandidateAccessPurchaseEntities
		{
			get
			{
				return this.GetTable<CandidateAccessPurchaseEntity>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SplitGuids", IsComposable=true)]
		public IQueryable<SplitGuidsResult> SplitGuids([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string delimiter, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string input)
		{
			return this.CreateMethodCallQuery<SplitGuidsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), delimiter, input);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetCreditReport", IsComposable=true)]
		public IQueryable<GetCreditReportResult> GetCreditReport([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> ownerId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="UniqueIdentifier")] System.Nullable<System.Guid> creditId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> startDate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> endDate)
		{
			return this.CreateMethodCallQuery<GetCreditReportResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ownerId, creditId, startDate, endDate);
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Credit")]
	internal partial class CreditEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _name;
		
		private string _displayName;
		
		private string _description;
		
		private EntitySet<CreditAllocationEntity> _CreditAllocationEntities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndisplayNameChanging(string value);
    partial void OndisplayNameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public CreditEntity()
		{
			this._CreditAllocationEntities = new EntitySet<CreditAllocationEntity>(new Action<CreditAllocationEntity>(this.attach_CreditAllocationEntities), new Action<CreditAllocationEntity>(this.detach_CreditAllocationEntities));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_displayName", DbType="NVarChar(100) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CreditEntity_CreditAllocationEntity", Storage="_CreditAllocationEntities", ThisKey="id", OtherKey="creditId")]
		public EntitySet<CreditAllocationEntity> CreditAllocationEntities
		{
			get
			{
				return this._CreditAllocationEntities;
			}
			set
			{
				this._CreditAllocationEntities.Assign(value);
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
		
		private void attach_CreditAllocationEntities(CreditAllocationEntity entity)
		{
			this.SendPropertyChanging();
			entity.CreditEntity = this;
		}
		
		private void detach_CreditAllocationEntities(CreditAllocationEntity entity)
		{
			this.SendPropertyChanging();
			entity.CreditEntity = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CreditAllocation")]
	internal partial class CreditAllocationEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private System.Guid _ownerId;
		
		private System.Guid _creditId;
		
		private System.Nullable<System.DateTime> _expiryDate;
		
		private System.Nullable<int> _quantity;
		
		private System.Nullable<System.Guid> _referenceId;
		
		private System.Nullable<int> _initialQuantity;
		
		private System.DateTime _createdTime;
		
		private System.Nullable<System.DateTime> _deallocatedTime;
		
		private EntityRef<CreditEntity> _CreditEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnownerIdChanging(System.Guid value);
    partial void OnownerIdChanged();
    partial void OncreditIdChanging(System.Guid value);
    partial void OncreditIdChanged();
    partial void OnexpiryDateChanging(System.Nullable<System.DateTime> value);
    partial void OnexpiryDateChanged();
    partial void OnquantityChanging(System.Nullable<int> value);
    partial void OnquantityChanged();
    partial void OnreferenceIdChanging(System.Nullable<System.Guid> value);
    partial void OnreferenceIdChanged();
    partial void OninitialQuantityChanging(System.Nullable<int> value);
    partial void OninitialQuantityChanged();
    partial void OncreatedTimeChanging(System.DateTime value);
    partial void OncreatedTimeChanged();
    partial void OndeallocatedTimeChanging(System.Nullable<System.DateTime> value);
    partial void OndeallocatedTimeChanged();
    #endregion
		
		public CreditAllocationEntity()
		{
			this._CreditEntity = default(EntityRef<CreditEntity>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ownerId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid ownerId
		{
			get
			{
				return this._ownerId;
			}
			set
			{
				if ((this._ownerId != value))
				{
					this.OnownerIdChanging(value);
					this.SendPropertyChanging();
					this._ownerId = value;
					this.SendPropertyChanged("ownerId");
					this.OnownerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creditId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
					if (this._CreditEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncreditIdChanging(value);
					this.SendPropertyChanging();
					this._creditId = value;
					this.SendPropertyChanged("creditId");
					this.OncreditIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expiryDate", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> expiryDate
		{
			get
			{
				return this._expiryDate;
			}
			set
			{
				if ((this._expiryDate != value))
				{
					this.OnexpiryDateChanging(value);
					this.SendPropertyChanging();
					this._expiryDate = value;
					this.SendPropertyChanged("expiryDate");
					this.OnexpiryDateChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_referenceId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> referenceId
		{
			get
			{
				return this._referenceId;
			}
			set
			{
				if ((this._referenceId != value))
				{
					this.OnreferenceIdChanging(value);
					this.SendPropertyChanging();
					this._referenceId = value;
					this.SendPropertyChanged("referenceId");
					this.OnreferenceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_initialQuantity", DbType="Int", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<int> initialQuantity
		{
			get
			{
				return this._initialQuantity;
			}
			set
			{
				if ((this._initialQuantity != value))
				{
					this.OninitialQuantityChanging(value);
					this.SendPropertyChanging();
					this._initialQuantity = value;
					this.SendPropertyChanged("initialQuantity");
					this.OninitialQuantityChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deallocatedTime", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> deallocatedTime
		{
			get
			{
				return this._deallocatedTime;
			}
			set
			{
				if ((this._deallocatedTime != value))
				{
					this.OndeallocatedTimeChanging(value);
					this.SendPropertyChanging();
					this._deallocatedTime = value;
					this.SendPropertyChanged("deallocatedTime");
					this.OndeallocatedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CreditEntity_CreditAllocationEntity", Storage="_CreditEntity", ThisKey="creditId", OtherKey="id", IsForeignKey=true)]
		public CreditEntity CreditEntity
		{
			get
			{
				return this._CreditEntity.Entity;
			}
			set
			{
				CreditEntity previousValue = this._CreditEntity.Entity;
				if (((previousValue != value) 
							|| (this._CreditEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._CreditEntity.Entity = null;
						previousValue.CreditAllocationEntities.Remove(this);
					}
					this._CreditEntity.Entity = value;
					if ((value != null))
					{
						value.CreditAllocationEntities.Add(this);
						this._creditId = value.id;
					}
					else
					{
						this._creditId = default(System.Guid);
					}
					this.SendPropertyChanged("CreditEntity");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CandidateAccessPurchase")]
	internal partial class CandidateAccessPurchaseEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private System.DateTime _purchaseTime;
		
		private System.Guid _searcherId;
		
		private System.Nullable<System.Guid> _candidateId;
		
		private System.Nullable<System.Guid> _allocationId;
		
		private System.Nullable<System.Guid> _referenceId;
		
		private bool _adjustedAllocation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnpurchaseTimeChanging(System.DateTime value);
    partial void OnpurchaseTimeChanged();
    partial void OnsearcherIdChanging(System.Guid value);
    partial void OnsearcherIdChanged();
    partial void OncandidateIdChanging(System.Nullable<System.Guid> value);
    partial void OncandidateIdChanged();
    partial void OnallocationIdChanging(System.Nullable<System.Guid> value);
    partial void OnallocationIdChanged();
    partial void OnreferenceIdChanging(System.Nullable<System.Guid> value);
    partial void OnreferenceIdChanged();
    partial void OnadjustedAllocationChanging(bool value);
    partial void OnadjustedAllocationChanged();
    #endregion
		
		public CandidateAccessPurchaseEntity()
		{
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchaseTime", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime purchaseTime
		{
			get
			{
				return this._purchaseTime;
			}
			set
			{
				if ((this._purchaseTime != value))
				{
					this.OnpurchaseTimeChanging(value);
					this.SendPropertyChanging();
					this._purchaseTime = value;
					this.SendPropertyChanged("purchaseTime");
					this.OnpurchaseTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_searcherId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid searcherId
		{
			get
			{
				return this._searcherId;
			}
			set
			{
				if ((this._searcherId != value))
				{
					this.OnsearcherIdChanging(value);
					this.SendPropertyChanging();
					this._searcherId = value;
					this.SendPropertyChanged("searcherId");
					this.OnsearcherIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_candidateId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> candidateId
		{
			get
			{
				return this._candidateId;
			}
			set
			{
				if ((this._candidateId != value))
				{
					this.OncandidateIdChanging(value);
					this.SendPropertyChanging();
					this._candidateId = value;
					this.SendPropertyChanged("candidateId");
					this.OncandidateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_allocationId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> allocationId
		{
			get
			{
				return this._allocationId;
			}
			set
			{
				if ((this._allocationId != value))
				{
					this.OnallocationIdChanging(value);
					this.SendPropertyChanging();
					this._allocationId = value;
					this.SendPropertyChanged("allocationId");
					this.OnallocationIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_referenceId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> referenceId
		{
			get
			{
				return this._referenceId;
			}
			set
			{
				if ((this._referenceId != value))
				{
					this.OnreferenceIdChanging(value);
					this.SendPropertyChanging();
					this._referenceId = value;
					this.SendPropertyChanged("referenceId");
					this.OnreferenceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adjustedAllocation", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool adjustedAllocation
		{
			get
			{
				return this._adjustedAllocation;
			}
			set
			{
				if ((this._adjustedAllocation != value))
				{
					this.OnadjustedAllocationChanging(value);
					this.SendPropertyChanging();
					this._adjustedAllocation = value;
					this.SendPropertyChanged("adjustedAllocation");
					this.OnadjustedAllocationChanged();
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
	
	public partial class GetCreditReportResult
	{
		
		private System.Nullable<int> _opening;
		
		private System.Nullable<int> _added;
		
		private System.Nullable<int> _used;
		
		private System.Nullable<int> _expired;
		
		private System.Nullable<int> _deallocated;
		
		private System.Nullable<int> _closing;
		
		public GetCreditReportResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opening", DbType="Int")]
		public System.Nullable<int> opening
		{
			get
			{
				return this._opening;
			}
			set
			{
				if ((this._opening != value))
				{
					this._opening = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_added", DbType="Int")]
		public System.Nullable<int> added
		{
			get
			{
				return this._added;
			}
			set
			{
				if ((this._added != value))
				{
					this._added = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_used", DbType="Int")]
		public System.Nullable<int> used
		{
			get
			{
				return this._used;
			}
			set
			{
				if ((this._used != value))
				{
					this._used = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expired", DbType="Int")]
		public System.Nullable<int> expired
		{
			get
			{
				return this._expired;
			}
			set
			{
				if ((this._expired != value))
				{
					this._expired = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deallocated", DbType="Int")]
		public System.Nullable<int> deallocated
		{
			get
			{
				return this._deallocated;
			}
			set
			{
				if ((this._deallocated != value))
				{
					this._deallocated = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_closing", DbType="Int")]
		public System.Nullable<int> closing
		{
			get
			{
				return this._closing;
			}
			set
			{
				if ((this._closing != value))
				{
					this._closing = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
