﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.269
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreateStudentTable
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
	
	
	public partial class DataStudentsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertstudent(student instance);
    partial void Updatestudent(student instance);
    partial void Deletestudent(student instance);
    #endregion
		
		public DataStudentsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataStudentsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataStudentsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataStudentsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<student> student
		{
			get
			{
				return this.GetTable<student>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _id = default(System.Guid);
		
		private string _name;
		
		private string _sex;
		
		private uint _grade;
		
		private uint _result;
		
		private uint _age;
		
		private uint _number;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void OngradeChanging(uint value);
    partial void OngradeChanged();
    partial void OnresultChanging(uint value);
    partial void OnresultChanged();
    partial void OnageChanging(uint value);
    partial void OnageChanged();
    partial void OnnumberChanging(uint value);
    partial void OnnumberChanged();
    #endregion
		
		public student()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid id
		{
			get
			{
				return this._id;
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", CanBeNull=false)]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grade")]
		public uint grade
		{
			get
			{
				return this._grade;
			}
			set
			{
				if ((this._grade != value))
				{
					this.OngradeChanging(value);
					this.SendPropertyChanging();
					this._grade = value;
					this.SendPropertyChanged("grade");
					this.OngradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_result")]
		public uint result
		{
			get
			{
				return this._result;
			}
			set
			{
				if ((this._result != value))
				{
					this.OnresultChanging(value);
					this.SendPropertyChanging();
					this._result = value;
					this.SendPropertyChanged("result");
					this.OnresultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age")]
		public uint age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number")]
		public uint number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
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

/// <summary>重载ToString()函数</summary>
/// <returns>学生信息字符串</returns>
public override string ToString()
{
    return string.Format("{0}  {1}年级  {2}  {3}  {4,3}岁 {5,3}分",
        _number, _grade, _name, _sex, _age, _result);
}
	}
}
#pragma warning restore 1591
