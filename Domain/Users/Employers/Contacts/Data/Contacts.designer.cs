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

namespace LinkMe.Domain.Users.Employers.Contacts.Data
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
	public partial class ContactsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployerMemberAttachmentEntity(EmployerMemberAttachmentEntity instance);
    partial void UpdateEmployerMemberAttachmentEntity(EmployerMemberAttachmentEntity instance);
    partial void DeleteEmployerMemberAttachmentEntity(EmployerMemberAttachmentEntity instance);
    partial void InsertEmployerMemberMessageAttachmentEntity(EmployerMemberMessageAttachmentEntity instance);
    partial void UpdateEmployerMemberMessageAttachmentEntity(EmployerMemberMessageAttachmentEntity instance);
    partial void DeleteEmployerMemberMessageAttachmentEntity(EmployerMemberMessageAttachmentEntity instance);
    partial void InsertEmployerMemberMessageEntity(EmployerMemberMessageEntity instance);
    partial void UpdateEmployerMemberMessageEntity(EmployerMemberMessageEntity instance);
    partial void DeleteEmployerMemberMessageEntity(EmployerMemberMessageEntity instance);
    #endregion
		
		public ContactsDataContext() : 
				base(global::LinkMe.Domain.Users.Properties.Settings.Default.LinkMeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ContactsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ContactsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		internal System.Data.Linq.Table<EmployerMemberAttachmentEntity> EmployerMemberAttachmentEntities
		{
			get
			{
				return this.GetTable<EmployerMemberAttachmentEntity>();
			}
		}
		
		internal System.Data.Linq.Table<EmployerMemberMessageAttachmentEntity> EmployerMemberMessageAttachmentEntities
		{
			get
			{
				return this.GetTable<EmployerMemberMessageAttachmentEntity>();
			}
		}
		
		internal System.Data.Linq.Table<EmployerMemberMessageEntity> EmployerMemberMessageEntities
		{
			get
			{
				return this.GetTable<EmployerMemberMessageEntity>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SplitGuids", IsComposable=true)]
		public IQueryable<SplitGuidsResult> SplitGuids([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string delimiter, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(MAX)")] string input)
		{
			return this.CreateMethodCallQuery<SplitGuidsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), delimiter, input);
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployerMemberAttachment")]
	internal partial class EmployerMemberAttachmentEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private System.DateTime _uploadedTime;
		
		private System.Guid _employerId;
		
		private System.Guid _fileReferenceId;
		
		private EntitySet<EmployerMemberMessageAttachmentEntity> _EmployerMemberMessageAttachmentEntities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OnuploadedTimeChanging(System.DateTime value);
    partial void OnuploadedTimeChanged();
    partial void OnemployerIdChanging(System.Guid value);
    partial void OnemployerIdChanged();
    partial void OnfileReferenceIdChanging(System.Guid value);
    partial void OnfileReferenceIdChanged();
    #endregion
		
		public EmployerMemberAttachmentEntity()
		{
			this._EmployerMemberMessageAttachmentEntities = new EntitySet<EmployerMemberMessageAttachmentEntity>(new Action<EmployerMemberMessageAttachmentEntity>(this.attach_EmployerMemberMessageAttachmentEntities), new Action<EmployerMemberMessageAttachmentEntity>(this.detach_EmployerMemberMessageAttachmentEntities));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uploadedTime", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime uploadedTime
		{
			get
			{
				return this._uploadedTime;
			}
			set
			{
				if ((this._uploadedTime != value))
				{
					this.OnuploadedTimeChanging(value);
					this.SendPropertyChanging();
					this._uploadedTime = value;
					this.SendPropertyChanged("uploadedTime");
					this.OnuploadedTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employerId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fileReferenceId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.Guid fileReferenceId
		{
			get
			{
				return this._fileReferenceId;
			}
			set
			{
				if ((this._fileReferenceId != value))
				{
					this.OnfileReferenceIdChanging(value);
					this.SendPropertyChanging();
					this._fileReferenceId = value;
					this.SendPropertyChanged("fileReferenceId");
					this.OnfileReferenceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployerMemberAttachmentEntity_EmployerMemberMessageAttachmentEntity", Storage="_EmployerMemberMessageAttachmentEntities", ThisKey="id", OtherKey="attachmentId")]
		public EntitySet<EmployerMemberMessageAttachmentEntity> EmployerMemberMessageAttachmentEntities
		{
			get
			{
				return this._EmployerMemberMessageAttachmentEntities;
			}
			set
			{
				this._EmployerMemberMessageAttachmentEntities.Assign(value);
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
		
		private void attach_EmployerMemberMessageAttachmentEntities(EmployerMemberMessageAttachmentEntity entity)
		{
			this.SendPropertyChanging();
			entity.EmployerMemberAttachmentEntity = this;
		}
		
		private void detach_EmployerMemberMessageAttachmentEntities(EmployerMemberMessageAttachmentEntity entity)
		{
			this.SendPropertyChanging();
			entity.EmployerMemberAttachmentEntity = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployerMemberMessageAttachment")]
	internal partial class EmployerMemberMessageAttachmentEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _messageId;
		
		private System.Guid _attachmentId;
		
		private EntityRef<EmployerMemberAttachmentEntity> _EmployerMemberAttachmentEntity;
		
		private EntityRef<EmployerMemberMessageEntity> _EmployerMemberMessageEntity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmessageIdChanging(System.Guid value);
    partial void OnmessageIdChanged();
    partial void OnattachmentIdChanging(System.Guid value);
    partial void OnattachmentIdChanged();
    #endregion
		
		public EmployerMemberMessageAttachmentEntity()
		{
			this._EmployerMemberAttachmentEntity = default(EntityRef<EmployerMemberAttachmentEntity>);
			this._EmployerMemberMessageEntity = default(EntityRef<EmployerMemberMessageEntity>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid messageId
		{
			get
			{
				return this._messageId;
			}
			set
			{
				if ((this._messageId != value))
				{
					if (this._EmployerMemberMessageEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmessageIdChanging(value);
					this.SendPropertyChanging();
					this._messageId = value;
					this.SendPropertyChanged("messageId");
					this.OnmessageIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_attachmentId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid attachmentId
		{
			get
			{
				return this._attachmentId;
			}
			set
			{
				if ((this._attachmentId != value))
				{
					if (this._EmployerMemberAttachmentEntity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnattachmentIdChanging(value);
					this.SendPropertyChanging();
					this._attachmentId = value;
					this.SendPropertyChanged("attachmentId");
					this.OnattachmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployerMemberAttachmentEntity_EmployerMemberMessageAttachmentEntity", Storage="_EmployerMemberAttachmentEntity", ThisKey="attachmentId", OtherKey="id", IsForeignKey=true)]
		public EmployerMemberAttachmentEntity EmployerMemberAttachmentEntity
		{
			get
			{
				return this._EmployerMemberAttachmentEntity.Entity;
			}
			set
			{
				EmployerMemberAttachmentEntity previousValue = this._EmployerMemberAttachmentEntity.Entity;
				if (((previousValue != value) 
							|| (this._EmployerMemberAttachmentEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EmployerMemberAttachmentEntity.Entity = null;
						previousValue.EmployerMemberMessageAttachmentEntities.Remove(this);
					}
					this._EmployerMemberAttachmentEntity.Entity = value;
					if ((value != null))
					{
						value.EmployerMemberMessageAttachmentEntities.Add(this);
						this._attachmentId = value.id;
					}
					else
					{
						this._attachmentId = default(System.Guid);
					}
					this.SendPropertyChanged("EmployerMemberAttachmentEntity");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployerMemberMessageEntity_EmployerMemberMessageAttachmentEntity", Storage="_EmployerMemberMessageEntity", ThisKey="messageId", OtherKey="id", IsForeignKey=true)]
		public EmployerMemberMessageEntity EmployerMemberMessageEntity
		{
			get
			{
				return this._EmployerMemberMessageEntity.Entity;
			}
			set
			{
				EmployerMemberMessageEntity previousValue = this._EmployerMemberMessageEntity.Entity;
				if (((previousValue != value) 
							|| (this._EmployerMemberMessageEntity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._EmployerMemberMessageEntity.Entity = null;
						previousValue.EmployerMemberMessageAttachmentEntities.Remove(this);
					}
					this._EmployerMemberMessageEntity.Entity = value;
					if ((value != null))
					{
						value.EmployerMemberMessageAttachmentEntities.Add(this);
						this._messageId = value.id;
					}
					else
					{
						this._messageId = default(System.Guid);
					}
					this.SendPropertyChanged("EmployerMemberMessageEntity");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployerMemberMessage")]
	internal partial class EmployerMemberMessageEntity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id;
		
		private System.DateTime _time;
		
		private System.Guid _employerId;
		
		private System.Guid _memberId;
		
		private System.Nullable<System.Guid> _contactId;
		
		private string _fromEmailAddress;
		
		private bool _sendcopyToEmployer;
		
		private string _subject;
		
		private string _body;
		
		private int _messageType;
		
		private System.Nullable<System.Guid> _representativeId;
		
		private EntitySet<EmployerMemberMessageAttachmentEntity> _EmployerMemberMessageAttachmentEntities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(System.Guid value);
    partial void OnidChanged();
    partial void OntimeChanging(System.DateTime value);
    partial void OntimeChanged();
    partial void OnemployerIdChanging(System.Guid value);
    partial void OnemployerIdChanged();
    partial void OnmemberIdChanging(System.Guid value);
    partial void OnmemberIdChanged();
    partial void OncontactIdChanging(System.Nullable<System.Guid> value);
    partial void OncontactIdChanged();
    partial void OnfromEmailAddressChanging(string value);
    partial void OnfromEmailAddressChanged();
    partial void OnsendCopyToEmployerChanging(bool value);
    partial void OnsendCopyToEmployerChanged();
    partial void OnsubjectChanging(string value);
    partial void OnsubjectChanged();
    partial void OnbodyChanging(string value);
    partial void OnbodyChanged();
    partial void OnmessageTypeChanging(int value);
    partial void OnmessageTypeChanged();
    partial void OnrepresentativeIdChanging(System.Nullable<System.Guid> value);
    partial void OnrepresentativeIdChanged();
    #endregion
		
		public EmployerMemberMessageEntity()
		{
			this._EmployerMemberMessageAttachmentEntities = new EntitySet<EmployerMemberMessageAttachmentEntity>(new Action<EmployerMemberMessageAttachmentEntity>(this.attach_EmployerMemberMessageAttachmentEntities), new Action<EmployerMemberMessageAttachmentEntity>(this.detach_EmployerMemberMessageAttachmentEntities));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime time
		{
			get
			{
				return this._time;
			}
			set
			{
				if ((this._time != value))
				{
					this.OntimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("time");
					this.OntimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employerId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_memberId", DbType="UniqueIdentifier NOT NULL", UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> contactId
		{
			get
			{
				return this._contactId;
			}
			set
			{
				if ((this._contactId != value))
				{
					this.OncontactIdChanging(value);
					this.SendPropertyChanging();
					this._contactId = value;
					this.SendPropertyChanged("contactId");
					this.OncontactIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fromEmailAddress", DbType="NVarChar(320)", UpdateCheck=UpdateCheck.Never)]
		public string fromEmailAddress
		{
			get
			{
				return this._fromEmailAddress;
			}
			set
			{
				if ((this._fromEmailAddress != value))
				{
					this.OnfromEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._fromEmailAddress = value;
					this.SendPropertyChanged("fromEmailAddress");
					this.OnfromEmailAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="sendcopyToEmployer", Storage="_sendcopyToEmployer", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool sendCopyToEmployer
		{
			get
			{
				return this._sendcopyToEmployer;
			}
			set
			{
				if ((this._sendcopyToEmployer != value))
				{
					this.OnsendCopyToEmployerChanging(value);
					this.SendPropertyChanging();
					this._sendcopyToEmployer = value;
					this.SendPropertyChanged("sendCopyToEmployer");
					this.OnsendCopyToEmployerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subject", DbType="NVarChar(500) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_body", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageType", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int messageType
		{
			get
			{
				return this._messageType;
			}
			set
			{
				if ((this._messageType != value))
				{
					this.OnmessageTypeChanging(value);
					this.SendPropertyChanging();
					this._messageType = value;
					this.SendPropertyChanged("messageType");
					this.OnmessageTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_representativeId", DbType="UniqueIdentifier", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.Guid> representativeId
		{
			get
			{
				return this._representativeId;
			}
			set
			{
				if ((this._representativeId != value))
				{
					this.OnrepresentativeIdChanging(value);
					this.SendPropertyChanging();
					this._representativeId = value;
					this.SendPropertyChanged("representativeId");
					this.OnrepresentativeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EmployerMemberMessageEntity_EmployerMemberMessageAttachmentEntity", Storage="_EmployerMemberMessageAttachmentEntities", ThisKey="id", OtherKey="messageId")]
		public EntitySet<EmployerMemberMessageAttachmentEntity> EmployerMemberMessageAttachmentEntities
		{
			get
			{
				return this._EmployerMemberMessageAttachmentEntities;
			}
			set
			{
				this._EmployerMemberMessageAttachmentEntities.Assign(value);
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
		
		private void attach_EmployerMemberMessageAttachmentEntities(EmployerMemberMessageAttachmentEntity entity)
		{
			this.SendPropertyChanging();
			entity.EmployerMemberMessageEntity = this;
		}
		
		private void detach_EmployerMemberMessageAttachmentEntities(EmployerMemberMessageAttachmentEntity entity)
		{
			this.SendPropertyChanging();
			entity.EmployerMemberMessageEntity = null;
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