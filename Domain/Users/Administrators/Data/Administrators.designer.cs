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

namespace LinkMe.Domain.Users.Administrators.Data
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
	public partial class AdministratorsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdministratorEntity(AdministratorEntity instance);
    partial void UpdateAdministratorEntity(AdministratorEntity instance);
    partial void DeleteAdministratorEntity(AdministratorEntity instance);
    partial void InsertRegisteredUserEntity(RegisteredUserEntity instance);
    partial void UpdateRegisteredUserEntity(RegisteredUserEntity instance);
    partial void DeleteRegisteredUserEntity(RegisteredUserEntity instance);
    #endregion
		
		public AdministratorsDataContext() : 
				base(global::LinkMe.Domain.Users.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AdministratorsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdministratorsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdministratorsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdministratorsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<AdministratorEntity> AdministratorEntities
		{
			get
			{
				return this.GetTable<AdministratorEntity>();
			}
		}
		
		internal System.Data.Linq.Table<RegisteredUserEntity> RegisteredUserEntities
		{
			get
			{
				return this.GetTable<RegisteredUserEntity>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SplitGuids", IsComposable=true)]
		public IQueryable<SplitGuidsResult> SplitGuids([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string delimiter, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string input)
		{
			return this.CreateMethodCallQuery<SplitGuidsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), delimiter, input);
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Administrator")]
	internal partial class AdministratorEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private EntityRef<RegisteredUserEntity> _RegisteredUserEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    #endregion
		
		public AdministratorEntity()
		{
			this._RegisteredUserEntity = default(EntityRef<RegisteredUserEntity>);
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
					if (this._RegisteredUserEntity.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RegisteredUserEntity_AdministratorEntity", Storage="_RegisteredUserEntity", ThisKey="id", OtherKey="id", IsForeignKey=true)]
		public RegisteredUserEntity RegisteredUserEntity
		{
			get
			{
				return this._RegisteredUserEntity.Entity;
			}
			set
			{
				RegisteredUserEntity previousValue = this._RegisteredUserEntity.Entity;
				if (((previousValue != value) 
							|| (this._RegisteredUserEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RegisteredUserEntity.Entity = null;
						previousValue.AdministratorEntity = null;
					}
					this._RegisteredUserEntity.Entity = value;
					if ((value != null))
					{
						value.AdministratorEntity = this;
						this._id = value.id;
					}
					else
					{
						this._id = default(System.Guid);
					}
					this.SendPropertyChanged("RegisteredUserEntity");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RegisteredUser")]
	internal partial class RegisteredUserEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private string _loginId;
		
		private System.DateTime _createdTime;
		
		private string _emailAddress;
		
		private string _firstName;
		
		private string _lastName;
		
		private short _flags;
		
		private string _passwordHash;
		
		private bool _emailAddressVerified;
		
		private string _secondaryEmailAddress;
		
		private System.Nullable<bool> _secondaryEmailAddressVerified;
		
		private EntityRef<AdministratorEntity> _AdministratorEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnloginIdChanging(string value);
    partial void OnloginIdChanged();
    partial void OncreatedTimeChanging(System.DateTime value);
    partial void OncreatedTimeChanged();
    partial void OnemailAddressChanging(string value);
    partial void OnemailAddressChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnflagsChanging(short value);
    partial void OnflagsChanged();
    partial void OnpasswordHashChanging(string value);
    partial void OnpasswordHashChanged();
    partial void OnemailAddressVerifiedChanging(bool value);
    partial void OnemailAddressVerifiedChanged();
    partial void OnsecondaryEmailAddressChanging(string value);
    partial void OnsecondaryEmailAddressChanged();
    partial void OnsecondaryEmailAddressVerifiedChanging(System.Nullable<bool> value);
    partial void OnsecondaryEmailAddressVerifiedChanged();
    #endregion
		
		public RegisteredUserEntity()
		{
			this._AdministratorEntity = default(EntityRef<AdministratorEntity>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loginId", DbType="NVarChar(320)", UpdateCheck=UpdateCheck.Never)]
		public string loginId
		{
			get
			{
				return this._loginId;
			}
			set
			{
				if ((this._loginId != value))
				{
					this.OnloginIdChanging(value);
					this.SendPropertyChanging();
					this._loginId = value;
					this.SendPropertyChanged("loginId");
					this.OnloginIdChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailAddress", DbType="NVarChar(320) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string emailAddress
		{
			get
			{
				return this._emailAddress;
			}
			set
			{
				if ((this._emailAddress != value))
				{
					this.OnemailAddressChanging(value);
					this.SendPropertyChanging();
					this._emailAddress = value;
					this.SendPropertyChanged("emailAddress");
					this.OnemailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="NVarChar(30) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="NVarChar(30) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_flags", DbType="SmallInt NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public short flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				if ((this._flags != value))
				{
					this.OnflagsChanging(value);
					this.SendPropertyChanging();
					this._flags = value;
					this.SendPropertyChanged("flags");
					this.OnflagsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passwordHash", DbType="Char(24)", UpdateCheck=UpdateCheck.Never)]
		public string passwordHash
		{
			get
			{
				return this._passwordHash;
			}
			set
			{
				if ((this._passwordHash != value))
				{
					this.OnpasswordHashChanging(value);
					this.SendPropertyChanging();
					this._passwordHash = value;
					this.SendPropertyChanged("passwordHash");
					this.OnpasswordHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_emailAddressVerified", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool emailAddressVerified
		{
			get
			{
				return this._emailAddressVerified;
			}
			set
			{
				if ((this._emailAddressVerified != value))
				{
					this.OnemailAddressVerifiedChanging(value);
					this.SendPropertyChanging();
					this._emailAddressVerified = value;
					this.SendPropertyChanged("emailAddressVerified");
					this.OnemailAddressVerifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_secondaryEmailAddress", DbType="NVarChar(320)", UpdateCheck=UpdateCheck.Never)]
		public string secondaryEmailAddress
		{
			get
			{
				return this._secondaryEmailAddress;
			}
			set
			{
				if ((this._secondaryEmailAddress != value))
				{
					this.OnsecondaryEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._secondaryEmailAddress = value;
					this.SendPropertyChanged("secondaryEmailAddress");
					this.OnsecondaryEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_secondaryEmailAddressVerified", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<bool> secondaryEmailAddressVerified
		{
			get
			{
				return this._secondaryEmailAddressVerified;
			}
			set
			{
				if ((this._secondaryEmailAddressVerified != value))
				{
					this.OnsecondaryEmailAddressVerifiedChanging(value);
					this.SendPropertyChanging();
					this._secondaryEmailAddressVerified = value;
					this.SendPropertyChanged("secondaryEmailAddressVerified");
					this.OnsecondaryEmailAddressVerifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RegisteredUserEntity_AdministratorEntity", Storage="_AdministratorEntity", ThisKey="id", OtherKey="id", IsUnique=true, IsForeignKey=false)]
		public AdministratorEntity AdministratorEntity
		{
			get
			{
				return this._AdministratorEntity.Entity;
			}
			set
			{
				AdministratorEntity previousValue = this._AdministratorEntity.Entity;
				if (((previousValue != value) 
							|| (this._AdministratorEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._AdministratorEntity.Entity = null;
						previousValue.RegisteredUserEntity = null;
					}
					this._AdministratorEntity.Entity = value;
					if ((value != null))
					{
						value.RegisteredUserEntity = this;
					}
					this.SendPropertyChanged("AdministratorEntity");
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
}
#pragma warning restore 1591
