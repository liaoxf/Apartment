	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_dbbackup : EntityExt
    {

		public sys_dbbackup() : base("sys_dbbackup") { }
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
		
        private string _F_BackupType = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_BackupType
        {
            get { return _F_BackupType; }
            set
            {
                this.OnPropertyValueChange(_.F_BackupType, _F_BackupType, value);
                this._F_BackupType = value;
                
            }
        }
		
        private string _F_DbName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_DbName
        {
            get { return _F_DbName; }
            set
            {
                this.OnPropertyValueChange(_.F_DbName, _F_DbName, value);
                this._F_DbName = value;
                
            }
        }
		
        private string _F_FileName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_FileName
        {
            get { return _F_FileName; }
            set
            {
                this.OnPropertyValueChange(_.F_FileName, _F_FileName, value);
                this._F_FileName = value;
                
            }
        }
		
        private string _F_FileSize = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_FileSize
        {
            get { return _F_FileSize; }
            set
            {
                this.OnPropertyValueChange(_.F_FileSize, _F_FileSize, value);
                this._F_FileSize = value;
                
            }
        }
		
        private string _F_FilePath = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_FilePath
        {
            get { return _F_FilePath; }
            set
            {
                this.OnPropertyValueChange(_.F_FilePath, _F_FilePath, value);
                this._F_FilePath = value;
                
            }
        }
		
        private byte[] _F_BackupTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_BackupTime
        {
            get { return _F_BackupTime; }
            set
            {
                this.OnPropertyValueChange(_.F_BackupTime, _F_BackupTime, value);
                this._F_BackupTime = value;
                
            }
        }
		
        private int? _F_SortCode = int.MinValue;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public int? F_SortCode
        {
            get { return _F_SortCode; }
            set
            {
                this.OnPropertyValueChange(_.F_SortCode, _F_SortCode, value);
                this._F_SortCode = value;
                
            }
        }
		
        private bool _F_DeleteMark = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_DeleteMark
        {
            get { return _F_DeleteMark; }
            set
            {
                this.OnPropertyValueChange(_.F_DeleteMark, _F_DeleteMark, value);
                this._F_DeleteMark = value;
                
            }
        }
		
        private bool _F_EnabledMark = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_EnabledMark
        {
            get { return _F_EnabledMark; }
            set
            {
                this.OnPropertyValueChange(_.F_EnabledMark, _F_EnabledMark, value);
                this._F_EnabledMark = value;
                
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
		
        private byte[] _F_LastModifyTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_LastModifyTime
        {
            get { return _F_LastModifyTime; }
            set
            {
                this.OnPropertyValueChange(_.F_LastModifyTime, _F_LastModifyTime, value);
                this._F_LastModifyTime = value;
                
            }
        }
		
        private string _F_LastModifyUserId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_LastModifyUserId
        {
            get { return _F_LastModifyUserId; }
            set
            {
                this.OnPropertyValueChange(_.F_LastModifyUserId, _F_LastModifyUserId, value);
                this._F_LastModifyUserId = value;
                
            }
        }
		
        private byte[] _F_DeleteTime = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public byte[] F_DeleteTime
        {
            get { return _F_DeleteTime; }
            set
            {
                this.OnPropertyValueChange(_.F_DeleteTime, _F_DeleteTime, value);
                this._F_DeleteTime = value;
                
            }
        }
		
        private string _F_DeleteUserId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_DeleteUserId
        {
            get { return _F_DeleteUserId; }
            set
            {
                this.OnPropertyValueChange(_.F_DeleteUserId, _F_DeleteUserId, value);
                this._F_DeleteUserId = value;
                
            }
        }
				#endregion

		#region Method

				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.F_Id,_.F_BackupType,_.F_DbName,_.F_FileName,_.F_FileSize,_.F_FilePath,_.F_BackupTime,_.F_SortCode,_.F_DeleteMark,_.F_EnabledMark,_.F_Description,_.F_CreatorTime,_.F_CreatorUserId,_.F_LastModifyTime,_.F_LastModifyUserId,_.F_DeleteTime,_.F_DeleteUserId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_BackupType,this._F_DbName,this._F_FileName,this._F_FileSize,this._F_FilePath,this._F_BackupTime,this._F_SortCode,this._F_DeleteMark,this._F_EnabledMark,this._F_Description,this._F_CreatorTime,this._F_CreatorUserId,this._F_LastModifyTime,this._F_LastModifyUserId,this._F_DeleteTime,this._F_DeleteUserId };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._F_Id = DataUtils.ConvertValue<string>(reader["F_Id"]);
							this._F_BackupType = DataUtils.ConvertValue<string>(reader["F_BackupType"]);
							this._F_DbName = DataUtils.ConvertValue<string>(reader["F_DbName"]);
							this._F_FileName = DataUtils.ConvertValue<string>(reader["F_FileName"]);
							this._F_FileSize = DataUtils.ConvertValue<string>(reader["F_FileSize"]);
							this._F_FilePath = DataUtils.ConvertValue<string>(reader["F_FilePath"]);
							this._F_BackupTime = DataUtils.ConvertValue<byte[]>(reader["F_BackupTime"]);
							this._F_SortCode = DataUtils.ConvertValue<int?>(reader["F_SortCode"]);
							this._F_DeleteMark = DataUtils.ConvertValue<bool>(reader["F_DeleteMark"]);
							this._F_EnabledMark = DataUtils.ConvertValue<bool>(reader["F_EnabledMark"]);
							this._F_Description = DataUtils.ConvertValue<string>(reader["F_Description"]);
							this._F_CreatorTime = DataUtils.ConvertValue<byte[]>(reader["F_CreatorTime"]);
							this._F_CreatorUserId = DataUtils.ConvertValue<string>(reader["F_CreatorUserId"]);
							this._F_LastModifyTime = DataUtils.ConvertValue<byte[]>(reader["F_LastModifyTime"]);
							this._F_LastModifyUserId = DataUtils.ConvertValue<string>(reader["F_LastModifyUserId"]);
							this._F_DeleteTime = DataUtils.ConvertValue<byte[]>(reader["F_DeleteTime"]);
							this._F_DeleteUserId = DataUtils.ConvertValue<string>(reader["F_DeleteUserId"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._F_Id =  DataUtils.ConvertValue<string>(row["F_Id"]);
							this._F_BackupType =  DataUtils.ConvertValue<string>(row["F_BackupType"]);
							this._F_DbName =  DataUtils.ConvertValue<string>(row["F_DbName"]);
							this._F_FileName =  DataUtils.ConvertValue<string>(row["F_FileName"]);
							this._F_FileSize =  DataUtils.ConvertValue<string>(row["F_FileSize"]);
							this._F_FilePath =  DataUtils.ConvertValue<string>(row["F_FilePath"]);
							this._F_BackupTime =  DataUtils.ConvertValue<byte[]>(row["F_BackupTime"]);
							this._F_SortCode =  DataUtils.ConvertValue<int?>(row["F_SortCode"]);
							this._F_DeleteMark =  DataUtils.ConvertValue<bool>(row["F_DeleteMark"]);
							this._F_EnabledMark =  DataUtils.ConvertValue<bool>(row["F_EnabledMark"]);
							this._F_Description =  DataUtils.ConvertValue<string>(row["F_Description"]);
							this._F_CreatorTime =  DataUtils.ConvertValue<byte[]>(row["F_CreatorTime"]);
							this._F_CreatorUserId =  DataUtils.ConvertValue<string>(row["F_CreatorUserId"]);
							this._F_LastModifyTime =  DataUtils.ConvertValue<byte[]>(row["F_LastModifyTime"]);
							this._F_LastModifyUserId =  DataUtils.ConvertValue<string>(row["F_LastModifyUserId"]);
							this._F_DeleteTime =  DataUtils.ConvertValue<byte[]>(row["F_DeleteTime"]);
							this._F_DeleteUserId =  DataUtils.ConvertValue<string>(row["F_DeleteUserId"]);
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
            public readonly static Field All = new Field("*", "sys_dbbackup");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_BackupType = new Field("F_BackupType", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DbName = new Field("F_DbName", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_FileName = new Field("F_FileName", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_FileSize = new Field("F_FileSize", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_FilePath = new Field("F_FilePath", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_BackupTime = new Field("F_BackupTime", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_SortCode = new Field("F_SortCode", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DeleteMark = new Field("F_DeleteMark", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_EnabledMark = new Field("F_EnabledMark", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Description = new Field("F_Description", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorTime = new Field("F_CreatorTime", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorUserId = new Field("F_CreatorUserId", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LastModifyTime = new Field("F_LastModifyTime", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LastModifyUserId = new Field("F_LastModifyUserId", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DeleteTime = new Field("F_DeleteTime", "sys_dbbackup", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DeleteUserId = new Field("F_DeleteUserId", "sys_dbbackup", "");
			
        }
		#endregion
        
    }

}
