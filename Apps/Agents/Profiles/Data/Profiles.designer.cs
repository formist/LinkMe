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

namespace LinkMe.Apps.Agents.Profiles.Data
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
	public partial class ProfilesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployerProfileEntity(EmployerProfileEntity instance);
    partial void UpdateEmployerProfileEntity(EmployerProfileEntity instance);
    partial void DeleteEmployerProfileEntity(EmployerProfileEntity instance);
    partial void InsertMemberProfileEntity(MemberProfileEntity instance);
    partial void UpdateMemberProfileEntity(MemberProfileEntity instance);
    partial void DeleteMemberProfileEntity(MemberProfileEntity instance);
    partial void InsertAnonymousUserProfileEntity(AnonymousUserProfileEntity instance);
    partial void UpdateAnonymousUserProfileEntity(AnonymousUserProfileEntity instance);
    partial void DeleteAnonymousUserProfileEntity(AnonymousUserProfileEntity instance);
    #endregion
		
		public ProfilesDataContext() : 
				base(global::LinkMe.Apps.Agents.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProfilesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProfilesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProfilesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProfilesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<EmployerProfileEntity> EmployerProfileEntities
		{
			get
			{
				return this.GetTable<EmployerProfileEntity>();
			}
		}
		
		internal System.Data.Linq.Table<MemberProfileEntity> MemberProfileEntities
		{
			get
			{
				return this.GetTable<MemberProfileEntity>();
			}
		}
		
		internal System.Data.Linq.Table<AnonymousUserProfileEntity> AnonymousUserProfileEntities
		{
			get
			{
				return this.GetTable<AnonymousUserProfileEntity>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployerProfile")]
	internal partial class EmployerProfileEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _employerId;
		
		private bool _hideCreditReminder;
		
		private bool _hideBulkCreditReminder;
		
		private bool _hideUpdatedTermsReminder;
		
		private System.Nullable<System.DateTime> _updatedTermsReminderTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnemployerIdChanging(System.Guid value);
    partial void OnemployerIdChanged();
    partial void OnhideCreditReminderChanging(bool value);
    partial void OnhideCreditReminderChanged();
    partial void OnhideBulkCreditReminderChanging(bool value);
    partial void OnhideBulkCreditReminderChanged();
    partial void OnhideUpdatedTermsReminderChanging(bool value);
    partial void OnhideUpdatedTermsReminderChanged();
    partial void OnupdatedTermsReminderTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnupdatedTermsReminderTimeChanged();
    #endregion
		
		public EmployerProfileEntity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employerId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid employerId
		{
			get
			{
				return this._employerId;
			}
			set
			{
				if ((this._employerId != value))
				{
					this.OnemployerIdChanging(value);
					this.SendPropertyChanging();
					this._employerId = value;
					this.SendPropertyChanged("employerId");
					this.OnemployerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hideCreditReminder", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool hideCreditReminder
		{
			get
			{
				return this._hideCreditReminder;
			}
			set
			{
				if ((this._hideCreditReminder != value))
				{
					this.OnhideCreditReminderChanging(value);
					this.SendPropertyChanging();
					this._hideCreditReminder = value;
					this.SendPropertyChanged("hideCreditReminder");
					this.OnhideCreditReminderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hideBulkCreditReminder", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool hideBulkCreditReminder
		{
			get
			{
				return this._hideBulkCreditReminder;
			}
			set
			{
				if ((this._hideBulkCreditReminder != value))
				{
					this.OnhideBulkCreditReminderChanging(value);
					this.SendPropertyChanging();
					this._hideBulkCreditReminder = value;
					this.SendPropertyChanged("hideBulkCreditReminder");
					this.OnhideBulkCreditReminderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hideUpdatedTermsReminder", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool hideUpdatedTermsReminder
		{
			get
			{
				return this._hideUpdatedTermsReminder;
			}
			set
			{
				if ((this._hideUpdatedTermsReminder != value))
				{
					this.OnhideUpdatedTermsReminderChanging(value);
					this.SendPropertyChanging();
					this._hideUpdatedTermsReminder = value;
					this.SendPropertyChanged("hideUpdatedTermsReminder");
					this.OnhideUpdatedTermsReminderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updatedTermsReminderTime", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> updatedTermsReminderTime
		{
			get
			{
				return this._updatedTermsReminderTime;
			}
			set
			{
				if ((this._updatedTermsReminderTime != value))
				{
					this.OnupdatedTermsReminderTimeChanging(value);
					this.SendPropertyChanging();
					this._updatedTermsReminderTime = value;
					this.SendPropertyChanged("updatedTermsReminderTime");
					this.OnupdatedTermsReminderTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MemberProfile")]
	internal partial class MemberProfileEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _memberId;
		
		private System.Nullable<System.DateTime> _updateProfileReminderTime;
		
		private bool _hideUpdateProfileReminder;
		
		private bool _hideUpdatedTermsReminder;
		
		private System.Nullable<System.DateTime> _updatedTermsReminderTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmemberIdChanging(System.Guid value);
    partial void OnmemberIdChanged();
    partial void OnupdateProfileReminderTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnupdateProfileReminderTimeChanged();
    partial void OnhideUpdateProfileReminderChanging(bool value);
    partial void OnhideUpdateProfileReminderChanged();
    partial void OnhideUpdatedTermsReminderChanging(bool value);
    partial void OnhideUpdatedTermsReminderChanged();
    partial void OnupdatedTermsReminderTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnupdatedTermsReminderTimeChanged();
    #endregion
		
		public MemberProfileEntity()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_memberId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid memberId
		{
			get
			{
				return this._memberId;
			}
			set
			{
				if ((this._memberId != value))
				{
					this.OnmemberIdChanging(value);
					this.SendPropertyChanging();
					this._memberId = value;
					this.SendPropertyChanged("memberId");
					this.OnmemberIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updateProfileReminderTime", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> updateProfileReminderTime
		{
			get
			{
				return this._updateProfileReminderTime;
			}
			set
			{
				if ((this._updateProfileReminderTime != value))
				{
					this.OnupdateProfileReminderTimeChanging(value);
					this.SendPropertyChanging();
					this._updateProfileReminderTime = value;
					this.SendPropertyChanged("updateProfileReminderTime");
					this.OnupdateProfileReminderTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hideUpdateProfileReminder", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool hideUpdateProfileReminder
		{
			get
			{
				return this._hideUpdateProfileReminder;
			}
			set
			{
				if ((this._hideUpdateProfileReminder != value))
				{
					this.OnhideUpdateProfileReminderChanging(value);
					this.SendPropertyChanging();
					this._hideUpdateProfileReminder = value;
					this.SendPropertyChanged("hideUpdateProfileReminder");
					this.OnhideUpdateProfileReminderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hideUpdatedTermsReminder", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool hideUpdatedTermsReminder
		{
			get
			{
				return this._hideUpdatedTermsReminder;
			}
			set
			{
				if ((this._hideUpdatedTermsReminder != value))
				{
					this.OnhideUpdatedTermsReminderChanging(value);
					this.SendPropertyChanging();
					this._hideUpdatedTermsReminder = value;
					this.SendPropertyChanged("hideUpdatedTermsReminder");
					this.OnhideUpdatedTermsReminderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updatedTermsReminderTime", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTime> updatedTermsReminderTime
		{
			get
			{
				return this._updatedTermsReminderTime;
			}
			set
			{
				if ((this._updatedTermsReminderTime != value))
				{
					this.OnupdatedTermsReminderTimeChanging(value);
					this.SendPropertyChanging();
					this._updatedTermsReminderTime = value;
					this.SendPropertyChanged("updatedTermsReminderTime");
					this.OnupdatedTermsReminderTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AnonymousUserProfile")]
	internal partial class AnonymousUserProfileEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _userId;
		
		private int _userType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(System.Guid value);
    partial void OnuserIdChanged();
    partial void OnuserTypeChanging(int value);
    partial void OnuserTypeChanged();
    #endregion
		
		public AnonymousUserProfileEntity()
		{
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
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userType", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int userType
		{
			get
			{
				return this._userType;
			}
			set
			{
				if ((this._userType != value))
				{
					this.OnuserTypeChanging(value);
					this.SendPropertyChanging();
					this._userType = value;
					this.SendPropertyChanged("userType");
					this.OnuserTypeChanged();
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
