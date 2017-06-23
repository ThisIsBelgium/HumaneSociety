﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSocietyFinal
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HumaneSociety")]
	public partial class HumaneSocietyDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdopter(Adopter instance);
    partial void UpdateAdopter(Adopter instance);
    partial void DeleteAdopter(Adopter instance);
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    #endregion
		
		public HumaneSocietyDbDataContext() : 
				base(global::HumaneSocietyFinal.Properties.Settings.Default.HumaneSocietyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Adopter> Adopters
		{
			get
			{
				return this.GetTable<Adopter>();
			}
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adopter")]
	public partial class Adopter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdopterID;
		
		private string _Name;
		
		private string _Gender;
		
		private System.Nullable<double> _Budget;
		
		private System.Nullable<bool> _HaveChildren;
		
		private string _HousingEnvironment;
		
		private string _AnimalTypePreference;
		
		private string _AnimalSizePreference;
		
		private System.Nullable<int> _age;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdopterIDChanging(int value);
    partial void OnAdopterIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnBudgetChanging(System.Nullable<double> value);
    partial void OnBudgetChanged();
    partial void OnHaveChildrenChanging(System.Nullable<bool> value);
    partial void OnHaveChildrenChanged();
    partial void OnHousingEnvironmentChanging(string value);
    partial void OnHousingEnvironmentChanged();
    partial void OnAnimalTypePreferenceChanging(string value);
    partial void OnAnimalTypePreferenceChanged();
    partial void OnAnimalSizePreferenceChanging(string value);
    partial void OnAnimalSizePreferenceChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    #endregion
		
		public Adopter()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdopterID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdopterID
		{
			get
			{
				return this._AdopterID;
			}
			set
			{
				if ((this._AdopterID != value))
				{
					this.OnAdopterIDChanging(value);
					this.SendPropertyChanging();
					this._AdopterID = value;
					this.SendPropertyChanged("AdopterID");
					this.OnAdopterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(100)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(15)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Budget", DbType="Float")]
		public System.Nullable<double> Budget
		{
			get
			{
				return this._Budget;
			}
			set
			{
				if ((this._Budget != value))
				{
					this.OnBudgetChanging(value);
					this.SendPropertyChanging();
					this._Budget = value;
					this.SendPropertyChanged("Budget");
					this.OnBudgetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HaveChildren", DbType="Bit")]
		public System.Nullable<bool> HaveChildren
		{
			get
			{
				return this._HaveChildren;
			}
			set
			{
				if ((this._HaveChildren != value))
				{
					this.OnHaveChildrenChanging(value);
					this.SendPropertyChanging();
					this._HaveChildren = value;
					this.SendPropertyChanged("HaveChildren");
					this.OnHaveChildrenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HousingEnvironment", DbType="VarChar(50)")]
		public string HousingEnvironment
		{
			get
			{
				return this._HousingEnvironment;
			}
			set
			{
				if ((this._HousingEnvironment != value))
				{
					this.OnHousingEnvironmentChanging(value);
					this.SendPropertyChanging();
					this._HousingEnvironment = value;
					this.SendPropertyChanged("HousingEnvironment");
					this.OnHousingEnvironmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalTypePreference", DbType="VarChar(50)")]
		public string AnimalTypePreference
		{
			get
			{
				return this._AnimalTypePreference;
			}
			set
			{
				if ((this._AnimalTypePreference != value))
				{
					this.OnAnimalTypePreferenceChanging(value);
					this.SendPropertyChanging();
					this._AnimalTypePreference = value;
					this.SendPropertyChanged("AnimalTypePreference");
					this.OnAnimalTypePreferenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalSizePreference", DbType="VarChar(50)")]
		public string AnimalSizePreference
		{
			get
			{
				return this._AnimalSizePreference;
			}
			set
			{
				if ((this._AnimalSizePreference != value))
				{
					this.OnAnimalSizePreferenceChanging(value);
					this.SendPropertyChanging();
					this._AnimalSizePreference = value;
					this.SendPropertyChanged("AnimalSizePreference");
					this.OnAnimalSizePreferenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
		public System.Nullable<int> age
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animal")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _Age;
		
		private System.Nullable<int> _AnimalWeight;
		
		private string _AnimalType;
		
		private System.Nullable<bool> _HasShots;
		
		private System.Nullable<int> _RoomNumber;
		
		private string _Name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnAnimalWeightChanging(System.Nullable<int> value);
    partial void OnAnimalWeightChanged();
    partial void OnAnimalTypeChanging(string value);
    partial void OnAnimalTypeChanged();
    partial void OnHasShotsChanging(System.Nullable<bool> value);
    partial void OnHasShotsChanged();
    partial void OnRoomNumberChanging(System.Nullable<int> value);
    partial void OnRoomNumberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Animal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalWeight", DbType="Int")]
		public System.Nullable<int> AnimalWeight
		{
			get
			{
				return this._AnimalWeight;
			}
			set
			{
				if ((this._AnimalWeight != value))
				{
					this.OnAnimalWeightChanging(value);
					this.SendPropertyChanging();
					this._AnimalWeight = value;
					this.SendPropertyChanged("AnimalWeight");
					this.OnAnimalWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalType", DbType="VarChar(75)")]
		public string AnimalType
		{
			get
			{
				return this._AnimalType;
			}
			set
			{
				if ((this._AnimalType != value))
				{
					this.OnAnimalTypeChanging(value);
					this.SendPropertyChanging();
					this._AnimalType = value;
					this.SendPropertyChanged("AnimalType");
					this.OnAnimalTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HasShots", DbType="Bit")]
		public System.Nullable<bool> HasShots
		{
			get
			{
				return this._HasShots;
			}
			set
			{
				if ((this._HasShots != value))
				{
					this.OnHasShotsChanging(value);
					this.SendPropertyChanging();
					this._HasShots = value;
					this.SendPropertyChanged("HasShots");
					this.OnHasShotsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomNumber", DbType="Int")]
		public System.Nullable<int> RoomNumber
		{
			get
			{
				return this._RoomNumber;
			}
			set
			{
				if ((this._RoomNumber != value))
				{
					this.OnRoomNumberChanging(value);
					this.SendPropertyChanging();
					this._RoomNumber = value;
					this.SendPropertyChanged("RoomNumber");
					this.OnRoomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(60)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
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