﻿//===============================================================================
// Microsoft patterns & practices
// Windows Azure Architecture Guide
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://wag.codeplex.com/license)
//===============================================================================


#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tailspin.Web.Survey.Shared.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="adatum-survey")]
	public partial class SurveySqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSurveyData(SurveyData instance);
    partial void UpdateSurveyData(SurveyData instance);
    partial void DeleteSurveyData(SurveyData instance);
    partial void InsertQuestionResponseData(QuestionResponseData instance);
    partial void UpdateQuestionResponseData(QuestionResponseData instance);
    partial void DeleteQuestionResponseData(QuestionResponseData instance);
    partial void InsertResponseData(ResponseData instance);
    partial void UpdateResponseData(ResponseData instance);
    partial void DeleteResponseData(ResponseData instance);
    partial void InsertQuestionData(QuestionData instance);
    partial void UpdateQuestionData(QuestionData instance);
    partial void DeleteQuestionData(QuestionData instance);
    partial void InsertPossibleAnswerData(PossibleAnswerData instance);
    partial void UpdatePossibleAnswerData(PossibleAnswerData instance);
    partial void DeletePossibleAnswerData(PossibleAnswerData instance);
    #endregion
		
		public SurveySqlDataContext() : 
				base(global::Tailspin.Web.Survey.Shared.Properties.Settings.Default.adatum_surveyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SurveySqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SurveySqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SurveySqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SurveySqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SurveyData> SurveyDatas
		{
			get
			{
				return this.GetTable<SurveyData>();
			}
		}
		
		public System.Data.Linq.Table<QuestionResponseData> QuestionResponseDatas
		{
			get
			{
				return this.GetTable<QuestionResponseData>();
			}
		}
		
		public System.Data.Linq.Table<ResponseData> ResponseDatas
		{
			get
			{
				return this.GetTable<ResponseData>();
			}
		}
		
		public System.Data.Linq.Table<QuestionData> QuestionDatas
		{
			get
			{
				return this.GetTable<QuestionData>();
			}
		}
		
		public System.Data.Linq.Table<PossibleAnswerData> PossibleAnswerDatas
		{
			get
			{
				return this.GetTable<PossibleAnswerData>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Survey")]
	public partial class SurveyData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _Title;
		
		private System.DateTime _CreatedOn;
		
		private EntitySet<ResponseData> _ResponseDatas;
		
		private EntitySet<QuestionData> _QuestionDatas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    #endregion
		
		public SurveyData()
		{
			this._ResponseDatas = new EntitySet<ResponseData>(new Action<ResponseData>(this.attach_ResponseDatas), new Action<ResponseData>(this.detach_ResponseDatas));
			this._QuestionDatas = new EntitySet<QuestionData>(new Action<QuestionData>(this.attach_QuestionDatas), new Action<QuestionData>(this.detach_QuestionDatas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SurveyData_ResponseData", Storage="_ResponseDatas", ThisKey="Id", OtherKey="SurveyId")]
		public EntitySet<ResponseData> ResponseDatas
		{
			get
			{
				return this._ResponseDatas;
			}
			set
			{
				this._ResponseDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SurveyData_QuestionData", Storage="_QuestionDatas", ThisKey="Id", OtherKey="SurveyId")]
		public EntitySet<QuestionData> QuestionDatas
		{
			get
			{
				return this._QuestionDatas;
			}
			set
			{
				this._QuestionDatas.Assign(value);
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
		
		private void attach_ResponseDatas(ResponseData entity)
		{
			this.SendPropertyChanging();
			entity.SurveyData = this;
		}
		
		private void detach_ResponseDatas(ResponseData entity)
		{
			this.SendPropertyChanging();
			entity.SurveyData = null;
		}
		
		private void attach_QuestionDatas(QuestionData entity)
		{
			this.SendPropertyChanging();
			entity.SurveyData = this;
		}
		
		private void detach_QuestionDatas(QuestionData entity)
		{
			this.SendPropertyChanging();
			entity.SurveyData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuestionResponse")]
	public partial class QuestionResponseData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ResponseId;
		
		private string _QuestionId;
		
		private string _Answer;
		
		private EntityRef<ResponseData> _ResponseData;
		
		private EntityRef<QuestionData> _QuestionData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnResponseIdChanging(string value);
    partial void OnResponseIdChanged();
    partial void OnQuestionIdChanging(string value);
    partial void OnQuestionIdChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    #endregion
		
		public QuestionResponseData()
		{
			this._ResponseData = default(EntityRef<ResponseData>);
			this._QuestionData = default(EntityRef<QuestionData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResponseId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ResponseId
		{
			get
			{
				return this._ResponseId;
			}
			set
			{
				if ((this._ResponseId != value))
				{
					if (this._ResponseData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnResponseIdChanging(value);
					this.SendPropertyChanging();
					this._ResponseId = value;
					this.SendPropertyChanged("ResponseId");
					this.OnResponseIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._QuestionData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this.OnAnswerChanging(value);
					this.SendPropertyChanging();
					this._Answer = value;
					this.SendPropertyChanged("Answer");
					this.OnAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ResponseData_QuestionResponseData", Storage="_ResponseData", ThisKey="ResponseId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public ResponseData ResponseData
		{
			get
			{
				return this._ResponseData.Entity;
			}
			set
			{
				ResponseData previousValue = this._ResponseData.Entity;
				if (((previousValue != value) 
							|| (this._ResponseData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ResponseData.Entity = null;
						previousValue.QuestionResponseDatas.Remove(this);
					}
					this._ResponseData.Entity = value;
					if ((value != null))
					{
						value.QuestionResponseDatas.Add(this);
						this._ResponseId = value.Id;
					}
					else
					{
						this._ResponseId = default(string);
					}
					this.SendPropertyChanged("ResponseData");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionData_QuestionResponseData", Storage="_QuestionData", ThisKey="QuestionId", OtherKey="Id", IsForeignKey=true)]
		public QuestionData QuestionData
		{
			get
			{
				return this._QuestionData.Entity;
			}
			set
			{
				QuestionData previousValue = this._QuestionData.Entity;
				if (((previousValue != value) 
							|| (this._QuestionData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QuestionData.Entity = null;
						previousValue.QuestionResponseDatas.Remove(this);
					}
					this._QuestionData.Entity = value;
					if ((value != null))
					{
						value.QuestionResponseDatas.Add(this);
						this._QuestionId = value.Id;
					}
					else
					{
						this._QuestionId = default(string);
					}
					this.SendPropertyChanged("QuestionData");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Response")]
	public partial class ResponseData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _SurveyId;
		
		private System.DateTime _CreatedOn;
		
		private EntitySet<QuestionResponseData> _QuestionResponseDatas;
		
		private EntityRef<SurveyData> _SurveyData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnSurveyIdChanging(string value);
    partial void OnSurveyIdChanged();
    partial void OnCreatedOnChanging(System.DateTime value);
    partial void OnCreatedOnChanged();
    #endregion
		
		public ResponseData()
		{
			this._QuestionResponseDatas = new EntitySet<QuestionResponseData>(new Action<QuestionResponseData>(this.attach_QuestionResponseDatas), new Action<QuestionResponseData>(this.detach_QuestionResponseDatas));
			this._SurveyData = default(EntityRef<SurveyData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurveyId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SurveyId
		{
			get
			{
				return this._SurveyId;
			}
			set
			{
				if ((this._SurveyId != value))
				{
					if (this._SurveyData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSurveyIdChanging(value);
					this.SendPropertyChanging();
					this._SurveyId = value;
					this.SendPropertyChanged("SurveyId");
					this.OnSurveyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedOn", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedOn
		{
			get
			{
				return this._CreatedOn;
			}
			set
			{
				if ((this._CreatedOn != value))
				{
					this.OnCreatedOnChanging(value);
					this.SendPropertyChanging();
					this._CreatedOn = value;
					this.SendPropertyChanged("CreatedOn");
					this.OnCreatedOnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ResponseData_QuestionResponseData", Storage="_QuestionResponseDatas", ThisKey="Id", OtherKey="ResponseId")]
		public EntitySet<QuestionResponseData> QuestionResponseDatas
		{
			get
			{
				return this._QuestionResponseDatas;
			}
			set
			{
				this._QuestionResponseDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SurveyData_ResponseData", Storage="_SurveyData", ThisKey="SurveyId", OtherKey="Id", IsForeignKey=true)]
		public SurveyData SurveyData
		{
			get
			{
				return this._SurveyData.Entity;
			}
			set
			{
				SurveyData previousValue = this._SurveyData.Entity;
				if (((previousValue != value) 
							|| (this._SurveyData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SurveyData.Entity = null;
						previousValue.ResponseDatas.Remove(this);
					}
					this._SurveyData.Entity = value;
					if ((value != null))
					{
						value.ResponseDatas.Add(this);
						this._SurveyId = value.Id;
					}
					else
					{
						this._SurveyId = default(string);
					}
					this.SendPropertyChanged("SurveyData");
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
		
		private void attach_QuestionResponseDatas(QuestionResponseData entity)
		{
			this.SendPropertyChanging();
			entity.ResponseData = this;
		}
		
		private void detach_QuestionResponseDatas(QuestionResponseData entity)
		{
			this.SendPropertyChanging();
			entity.ResponseData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Question")]
	public partial class QuestionData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _SurveyId;
		
		private string _QuestionText;
		
		private string _QuestionType;
		
		private EntitySet<QuestionResponseData> _QuestionResponseDatas;
		
		private EntitySet<PossibleAnswerData> _PossibleAnswerDatas;
		
		private EntityRef<SurveyData> _SurveyData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnSurveyIdChanging(string value);
    partial void OnSurveyIdChanged();
    partial void OnQuestionTextChanging(string value);
    partial void OnQuestionTextChanged();
    partial void OnQuestionTypeChanging(string value);
    partial void OnQuestionTypeChanged();
    #endregion
		
		public QuestionData()
		{
			this._QuestionResponseDatas = new EntitySet<QuestionResponseData>(new Action<QuestionResponseData>(this.attach_QuestionResponseDatas), new Action<QuestionResponseData>(this.detach_QuestionResponseDatas));
			this._PossibleAnswerDatas = new EntitySet<PossibleAnswerData>(new Action<PossibleAnswerData>(this.attach_PossibleAnswerDatas), new Action<PossibleAnswerData>(this.detach_PossibleAnswerDatas));
			this._SurveyData = default(EntityRef<SurveyData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurveyId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SurveyId
		{
			get
			{
				return this._SurveyId;
			}
			set
			{
				if ((this._SurveyId != value))
				{
					if (this._SurveyData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSurveyIdChanging(value);
					this.SendPropertyChanging();
					this._SurveyId = value;
					this.SendPropertyChanged("SurveyId");
					this.OnSurveyIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionText", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string QuestionText
		{
			get
			{
				return this._QuestionText;
			}
			set
			{
				if ((this._QuestionText != value))
				{
					this.OnQuestionTextChanging(value);
					this.SendPropertyChanging();
					this._QuestionText = value;
					this.SendPropertyChanged("QuestionText");
					this.OnQuestionTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionType", DbType="NVarChar(50)")]
		public string QuestionType
		{
			get
			{
				return this._QuestionType;
			}
			set
			{
				if ((this._QuestionType != value))
				{
					this.OnQuestionTypeChanging(value);
					this.SendPropertyChanging();
					this._QuestionType = value;
					this.SendPropertyChanged("QuestionType");
					this.OnQuestionTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionData_QuestionResponseData", Storage="_QuestionResponseDatas", ThisKey="Id", OtherKey="QuestionId")]
		public EntitySet<QuestionResponseData> QuestionResponseDatas
		{
			get
			{
				return this._QuestionResponseDatas;
			}
			set
			{
				this._QuestionResponseDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionData_PossibleAnswerData", Storage="_PossibleAnswerDatas", ThisKey="Id", OtherKey="QuestionId")]
		public EntitySet<PossibleAnswerData> PossibleAnswerDatas
		{
			get
			{
				return this._PossibleAnswerDatas;
			}
			set
			{
				this._PossibleAnswerDatas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SurveyData_QuestionData", Storage="_SurveyData", ThisKey="SurveyId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public SurveyData SurveyData
		{
			get
			{
				return this._SurveyData.Entity;
			}
			set
			{
				SurveyData previousValue = this._SurveyData.Entity;
				if (((previousValue != value) 
							|| (this._SurveyData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SurveyData.Entity = null;
						previousValue.QuestionDatas.Remove(this);
					}
					this._SurveyData.Entity = value;
					if ((value != null))
					{
						value.QuestionDatas.Add(this);
						this._SurveyId = value.Id;
					}
					else
					{
						this._SurveyId = default(string);
					}
					this.SendPropertyChanged("SurveyData");
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
		
		private void attach_QuestionResponseDatas(QuestionResponseData entity)
		{
			this.SendPropertyChanging();
			entity.QuestionData = this;
		}
		
		private void detach_QuestionResponseDatas(QuestionResponseData entity)
		{
			this.SendPropertyChanging();
			entity.QuestionData = null;
		}
		
		private void attach_PossibleAnswerDatas(PossibleAnswerData entity)
		{
			this.SendPropertyChanging();
			entity.QuestionData = this;
		}
		
		private void detach_PossibleAnswerDatas(PossibleAnswerData entity)
		{
			this.SendPropertyChanging();
			entity.QuestionData = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PossibleAnswer")]
	public partial class PossibleAnswerData : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Id;
		
		private string _QuestionId;
		
		private string _Answer;
		
		private EntityRef<QuestionData> _QuestionData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(string value);
    partial void OnIdChanged();
    partial void OnQuestionIdChanging(string value);
    partial void OnQuestionIdChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    #endregion
		
		public PossibleAnswerData()
		{
			this._QuestionData = default(EntityRef<QuestionData>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string QuestionId
		{
			get
			{
				return this._QuestionId;
			}
			set
			{
				if ((this._QuestionId != value))
				{
					if (this._QuestionData.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIdChanging(value);
					this.SendPropertyChanging();
					this._QuestionId = value;
					this.SendPropertyChanged("QuestionId");
					this.OnQuestionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this.OnAnswerChanging(value);
					this.SendPropertyChanging();
					this._Answer = value;
					this.SendPropertyChanged("Answer");
					this.OnAnswerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="QuestionData_PossibleAnswerData", Storage="_QuestionData", ThisKey="QuestionId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public QuestionData QuestionData
		{
			get
			{
				return this._QuestionData.Entity;
			}
			set
			{
				QuestionData previousValue = this._QuestionData.Entity;
				if (((previousValue != value) 
							|| (this._QuestionData.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._QuestionData.Entity = null;
						previousValue.PossibleAnswerDatas.Remove(this);
					}
					this._QuestionData.Entity = value;
					if ((value != null))
					{
						value.PossibleAnswerDatas.Add(this);
						this._QuestionId = value.Id;
					}
					else
					{
						this._QuestionId = default(string);
					}
					this.SendPropertyChanged("QuestionData");
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
