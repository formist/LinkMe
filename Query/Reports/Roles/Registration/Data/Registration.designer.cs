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

namespace LinkMe.Query.Reports.Roles.Registration.Data
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
	public partial class RegistrationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertJoinReferralEntity(JoinReferralEntity instance);
    partial void UpdateJoinReferralEntity(JoinReferralEntity instance);
    partial void DeleteJoinReferralEntity(JoinReferralEntity instance);
    partial void InsertRegisteredUserEntity(RegisteredUserEntity instance);
    partial void UpdateRegisteredUserEntity(RegisteredUserEntity instance);
    partial void DeleteRegisteredUserEntity(RegisteredUserEntity instance);
    #endregion
		
		public RegistrationDataContext() : 
				base(global::LinkMe.Query.Reports.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<JoinReferralEntity> JoinReferralEntities
		{
			get
			{
				return this.GetTable<JoinReferralEntity>();
			}
		}
		
		internal System.Data.Linq.Table<RegisteredUserEntity> RegisteredUserEntities
		{
			get
			{
				return this.GetTable<RegisteredUserEntity>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.JoinReferral")]
	internal partial class JoinReferralEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _userId;
		
		private string _promotionCode;
		
		private string _refererUrl;
		
		private string _referralCode;
		
		private EntityRef<RegisteredUserEntity> _RegisteredUserEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(System.Guid value);
    partial void OnuserIdChanged();
    partial void OnpromotionCodeChanging(string value);
    partial void OnpromotionCodeChanged();
    partial void OnrefererUrlChanging(string value);
    partial void OnrefererUrlChanged();
    partial void OnreferralCodeChanging(string value);
    partial void OnreferralCodeChanged();
    #endregion
		
		public JoinReferralEntity()
		{
			this._RegisteredUserEntity = default(EntityRef<RegisteredUserEntity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					if (this._RegisteredUserEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_promotionCode", DbType="VarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string promotionCode
		{
			get
			{
				return this._promotionCode;
			}
			set
			{
				if ((this._promotionCode != value))
				{
					this.OnpromotionCodeChanging(value);
					this.SendPropertyChanging();
					this._promotionCode = value;
					this.SendPropertyChanged("promotionCode");
					this.OnpromotionCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_refererUrl", DbType="NVarChar(1000)", UpdateCheck=UpdateCheck.Never)]
		public string refererUrl
		{
			get
			{
				return this._refererUrl;
			}
			set
			{
				if ((this._refererUrl != value))
				{
					this.OnrefererUrlChanging(value);
					this.SendPropertyChanging();
					this._refererUrl = value;
					this.SendPropertyChanged("refererUrl");
					this.OnrefererUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_referralCode", DbType="VarChar(30)", UpdateCheck=UpdateCheck.Never)]
		public string referralCode
		{
			get
			{
				return this._referralCode;
			}
			set
			{
				if ((this._referralCode != value))
				{
					this.OnreferralCodeChanging(value);
					this.SendPropertyChanging();
					this._referralCode = value;
					this.SendPropertyChanged("referralCode");
					this.OnreferralCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RegisteredUserEntity_JoinReferralEntity", Storage="_RegisteredUserEntity", ThisKey="userId", OtherKey="id", IsForeignKey=true)]
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
						previousValue.JoinReferralEntity = null;
					}
					this._RegisteredUserEntity.Entity = value;
					if ((value != null))
					{
						value.JoinReferralEntity = this;
						this._userId = value.id;
					}
					else
					{
						this._userId = default(System.Guid);
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
		
		private EntityRef<JoinReferralEntity> _JoinReferralEntity;
		
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
			this._JoinReferralEntity = default(EntityRef<JoinReferralEntity>);
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RegisteredUserEntity_JoinReferralEntity", Storage="_JoinReferralEntity", ThisKey="id", OtherKey="userId", IsUnique=true, IsForeignKey=false)]
		public JoinReferralEntity JoinReferralEntity
		{
			get
			{
				return this._JoinReferralEntity.Entity;
			}
			set
			{
				JoinReferralEntity previousValue = this._JoinReferralEntity.Entity;
				if (((previousValue != value) 
							|| (this._JoinReferralEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._JoinReferralEntity.Entity = null;
						previousValue.RegisteredUserEntity = null;
					}
					this._JoinReferralEntity.Entity = value;
					if ((value != null))
					{
						value.RegisteredUserEntity = this;
					}
					this.SendPropertyChanged("JoinReferralEntity");
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