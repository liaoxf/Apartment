	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_log : EntityExt
    {

		public sys_log() : base("sys_log") { }
	    #region Field

        private string _F_Id = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Id
        {
            get { return _F_Id; }
            set
            {
                this.OnPropertyValueChange(_.F_Id, _F_Id, value);
                this._F_Id = value;
                
            }
        }
		
        private byte[] _F_Date = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_Date
        {
            get { return _F_Date; }
            set
            {
                this.OnPropertyValueChange(_.F_Date, _F_Date, value);
                this._F_Date = value;
                
            }
        }
		
        private string _F_Account = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Account
        {
            get { return _F_Account; }
            set
            {
                this.OnPropertyValueChange(_.F_Account, _F_Account, value);
                this._F_Account = value;
                
            }
        }
		
        private string _F_NickName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_NickName
        {
            get { return _F_NickName; }
            set
            {
                this.OnPropertyValueChange(_.F_NickName, _F_NickName, value);
                this._F_NickName = value;
                
            }
        }
		
        private string _F_Type = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Type
        {
            get { return _F_Type; }
            set
            {
                this.OnPropertyValueChange(_.F_Type, _F_Type, value);
                this._F_Type = value;
                
            }
        }
		
        private string _F_IPAddress = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_IPAddress
        {
            get { return _F_IPAddress; }
            set
            {
                this.OnPropertyValueChange(_.F_IPAddress, _F_IPAddress, value);
                this._F_IPAddress = value;
                
            }
        }
		
        private string _F_IPAddressName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_IPAddressName
        {
            get { return _F_IPAddressName; }
            set
            {
                this.OnPropertyValueChange(_.F_IPAddressName, _F_IPAddressName, value);
                this._F_IPAddressName = value;
                
            }
        }
		
        private string _F_ModuleId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ModuleId
        {
            get { return _F_ModuleId; }
            set
            {
                this.OnPropertyValueChange(_.F_ModuleId, _F_ModuleId, value);
                this._F_ModuleId = value;
                
            }
        }
		
        private string _F_ModuleName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ModuleName
        {
            get { return _F_ModuleName; }
            set
            {
                this.OnPropertyValueChange(_.F_ModuleName, _F_ModuleName, value);
                this._F_ModuleName = value;
                
            }
        }
		
        private bool _F_Result = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_Result
        {
            get { return _F_Result; }
            set
            {
                this.OnPropertyValueChange(_.F_Result, _F_Result, value);
                this._F_Result = value;
                
            }
        }
		
        private string _F_Description = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Description
        {
            get { return _F_Description; }
            set
            {
                this.OnPropertyValueChange(_.F_Description, _F_Description, value);
                this._F_Description = value;
                
            }
        }
		
        private byte[] _F_CreatorTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_CreatorTime
        {
            get { return _F_CreatorTime; }
            set
            {
                this.OnPropertyValueChange(_.F_CreatorTime, _F_CreatorTime, value);
                this._F_CreatorTime = value;
                
            }
        }
		
        private string _F_CreatorUserId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_CreatorUserId
        {
            get { return _F_CreatorUserId; }
            set
            {
                this.OnPropertyValueChange(_.F_CreatorUserId, _F_CreatorUserId, value);
                this._F_CreatorUserId = value;
                
            }
        }
				#endregion

		#region Method

				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.F_Id,_.F_Date,_.F_Account,_.F_NickName,_.F_Type,_.F_IPAddress,_.F_IPAddressName,_.F_ModuleId,_.F_ModuleName,_.F_Result,_.F_Description,_.F_CreatorTime,_.F_CreatorUserId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_Date,this._F_Account,this._F_NickName,this._F_Type,this._F_IPAddress,this._F_IPAddressName,this._F_ModuleId,this._F_ModuleName,this._F_Result,this._F_Description,this._F_CreatorTime,this._F_CreatorUserId };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._F_Id = DataUtils.ConvertValue<string>(reader["F_Id"]);
							this._F_Date = DataUtils.ConvertValue<byte[]>(reader["F_Date"]);
							this._F_Account = DataUtils.ConvertValue<string>(reader["F_Account"]);
							this._F_NickName = DataUtils.ConvertValue<string>(reader["F_NickName"]);
							this._F_Type = DataUtils.ConvertValue<string>(reader["F_Type"]);
							this._F_IPAddress = DataUtils.ConvertValue<string>(reader["F_IPAddress"]);
							this._F_IPAddressName = DataUtils.ConvertValue<string>(reader["F_IPAddressName"]);
							this._F_ModuleId = DataUtils.ConvertValue<string>(reader["F_ModuleId"]);
							this._F_ModuleName = DataUtils.ConvertValue<string>(reader["F_ModuleName"]);
							this._F_Result = DataUtils.ConvertValue<bool>(reader["F_Result"]);
							this._F_Description = DataUtils.ConvertValue<string>(reader["F_Description"]);
							this._F_CreatorTime = DataUtils.ConvertValue<byte[]>(reader["F_CreatorTime"]);
							this._F_CreatorUserId = DataUtils.ConvertValue<string>(reader["F_CreatorUserId"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._F_Id =  DataUtils.ConvertValue<string>(row["F_Id"]);
							this._F_Date =  DataUtils.ConvertValue<byte[]>(row["F_Date"]);
							this._F_Account =  DataUtils.ConvertValue<string>(row["F_Account"]);
							this._F_NickName =  DataUtils.ConvertValue<string>(row["F_NickName"]);
							this._F_Type =  DataUtils.ConvertValue<string>(row["F_Type"]);
							this._F_IPAddress =  DataUtils.ConvertValue<string>(row["F_IPAddress"]);
							this._F_IPAddressName =  DataUtils.ConvertValue<string>(row["F_IPAddressName"]);
							this._F_ModuleId =  DataUtils.ConvertValue<string>(row["F_ModuleId"]);
							this._F_ModuleName =  DataUtils.ConvertValue<string>(row["F_ModuleName"]);
							this._F_Result =  DataUtils.ConvertValue<bool>(row["F_Result"]);
							this._F_Description =  DataUtils.ConvertValue<string>(row["F_Description"]);
							this._F_CreatorTime =  DataUtils.ConvertValue<byte[]>(row["F_CreatorTime"]);
							this._F_CreatorUserId =  DataUtils.ConvertValue<string>(row["F_CreatorUserId"]);
			        }
		#endregion
		
		#region _
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// *
            /// </summary>
            public readonly static Field All = new Field("*", "sys_log");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Date = new Field("F_Date", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Account = new Field("F_Account", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_NickName = new Field("F_NickName", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Type = new Field("F_Type", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_IPAddress = new Field("F_IPAddress", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_IPAddressName = new Field("F_IPAddressName", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ModuleId = new Field("F_ModuleId", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ModuleName = new Field("F_ModuleName", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Result = new Field("F_Result", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Description = new Field("F_Description", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorTime = new Field("F_CreatorTime", "sys_log", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorUserId = new Field("F_CreatorUserId", "sys_log", "");
			
        }
		#endregion
        
    }

}
