	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_organize : EntityExt
    {

		public sys_organize() : base("sys_organize") { }
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
		
        private string _F_ParentId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ParentId
        {
            get { return _F_ParentId; }
            set
            {
                this.OnPropertyValueChange(_.F_ParentId, _F_ParentId, value);
                this._F_ParentId = value;
                
            }
        }
		
        private int? _F_Layers = int.MinValue;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public int? F_Layers
        {
            get { return _F_Layers; }
            set
            {
                this.OnPropertyValueChange(_.F_Layers, _F_Layers, value);
                this._F_Layers = value;
                
            }
        }
		
        private string _F_EnCode = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_EnCode
        {
            get { return _F_EnCode; }
            set
            {
                this.OnPropertyValueChange(_.F_EnCode, _F_EnCode, value);
                this._F_EnCode = value;
                
            }
        }
		
        private string _F_FullName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_FullName
        {
            get { return _F_FullName; }
            set
            {
                this.OnPropertyValueChange(_.F_FullName, _F_FullName, value);
                this._F_FullName = value;
                
            }
        }
		
        private string _F_ShortName = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ShortName
        {
            get { return _F_ShortName; }
            set
            {
                this.OnPropertyValueChange(_.F_ShortName, _F_ShortName, value);
                this._F_ShortName = value;
                
            }
        }
		
        private string _F_CategoryId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_CategoryId
        {
            get { return _F_CategoryId; }
            set
            {
                this.OnPropertyValueChange(_.F_CategoryId, _F_CategoryId, value);
                this._F_CategoryId = value;
                
            }
        }
		
        private string _F_ManagerId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ManagerId
        {
            get { return _F_ManagerId; }
            set
            {
                this.OnPropertyValueChange(_.F_ManagerId, _F_ManagerId, value);
                this._F_ManagerId = value;
                
            }
        }
		
        private string _F_TelePhone = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_TelePhone
        {
            get { return _F_TelePhone; }
            set
            {
                this.OnPropertyValueChange(_.F_TelePhone, _F_TelePhone, value);
                this._F_TelePhone = value;
                
            }
        }
		
        private string _F_MobilePhone = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_MobilePhone
        {
            get { return _F_MobilePhone; }
            set
            {
                this.OnPropertyValueChange(_.F_MobilePhone, _F_MobilePhone, value);
                this._F_MobilePhone = value;
                
            }
        }
		
        private string _F_WeChat = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_WeChat
        {
            get { return _F_WeChat; }
            set
            {
                this.OnPropertyValueChange(_.F_WeChat, _F_WeChat, value);
                this._F_WeChat = value;
                
            }
        }
		
        private string _F_Fax = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Fax
        {
            get { return _F_Fax; }
            set
            {
                this.OnPropertyValueChange(_.F_Fax, _F_Fax, value);
                this._F_Fax = value;
                
            }
        }
		
        private string _F_Email = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Email
        {
            get { return _F_Email; }
            set
            {
                this.OnPropertyValueChange(_.F_Email, _F_Email, value);
                this._F_Email = value;
                
            }
        }
		
        private string _F_AreaId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_AreaId
        {
            get { return _F_AreaId; }
            set
            {
                this.OnPropertyValueChange(_.F_AreaId, _F_AreaId, value);
                this._F_AreaId = value;
                
            }
        }
		
        private string _F_Address = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_Address
        {
            get { return _F_Address; }
            set
            {
                this.OnPropertyValueChange(_.F_Address, _F_Address, value);
                this._F_Address = value;
                
            }
        }
		
        private bool _F_AllowEdit = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_AllowEdit
        {
            get { return _F_AllowEdit; }
            set
            {
                this.OnPropertyValueChange(_.F_AllowEdit, _F_AllowEdit, value);
                this._F_AllowEdit = value;
                
            }
        }
		
        private bool _F_AllowDelete = false;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public bool F_AllowDelete
        {
            get { return _F_AllowDelete; }
            set
            {
                this.OnPropertyValueChange(_.F_AllowDelete, _F_AllowDelete, value);
                this._F_AllowDelete = value;
                
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
            return new Field[] {_.F_Id,_.F_ParentId,_.F_Layers,_.F_EnCode,_.F_FullName,_.F_ShortName,_.F_CategoryId,_.F_ManagerId,_.F_TelePhone,_.F_MobilePhone,_.F_WeChat,_.F_Fax,_.F_Email,_.F_AreaId,_.F_Address,_.F_AllowEdit,_.F_AllowDelete,_.F_SortCode,_.F_DeleteMark,_.F_EnabledMark,_.F_Description,_.F_CreatorTime,_.F_CreatorUserId,_.F_LastModifyTime,_.F_LastModifyUserId,_.F_DeleteTime,_.F_DeleteUserId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_ParentId,this._F_Layers,this._F_EnCode,this._F_FullName,this._F_ShortName,this._F_CategoryId,this._F_ManagerId,this._F_TelePhone,this._F_MobilePhone,this._F_WeChat,this._F_Fax,this._F_Email,this._F_AreaId,this._F_Address,this._F_AllowEdit,this._F_AllowDelete,this._F_SortCode,this._F_DeleteMark,this._F_EnabledMark,this._F_Description,this._F_CreatorTime,this._F_CreatorUserId,this._F_LastModifyTime,this._F_LastModifyUserId,this._F_DeleteTime,this._F_DeleteUserId };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._F_Id = DataUtils.ConvertValue<string>(reader["F_Id"]);
							this._F_ParentId = DataUtils.ConvertValue<string>(reader["F_ParentId"]);
							this._F_Layers = DataUtils.ConvertValue<int?>(reader["F_Layers"]);
							this._F_EnCode = DataUtils.ConvertValue<string>(reader["F_EnCode"]);
							this._F_FullName = DataUtils.ConvertValue<string>(reader["F_FullName"]);
							this._F_ShortName = DataUtils.ConvertValue<string>(reader["F_ShortName"]);
							this._F_CategoryId = DataUtils.ConvertValue<string>(reader["F_CategoryId"]);
							this._F_ManagerId = DataUtils.ConvertValue<string>(reader["F_ManagerId"]);
							this._F_TelePhone = DataUtils.ConvertValue<string>(reader["F_TelePhone"]);
							this._F_MobilePhone = DataUtils.ConvertValue<string>(reader["F_MobilePhone"]);
							this._F_WeChat = DataUtils.ConvertValue<string>(reader["F_WeChat"]);
							this._F_Fax = DataUtils.ConvertValue<string>(reader["F_Fax"]);
							this._F_Email = DataUtils.ConvertValue<string>(reader["F_Email"]);
							this._F_AreaId = DataUtils.ConvertValue<string>(reader["F_AreaId"]);
							this._F_Address = DataUtils.ConvertValue<string>(reader["F_Address"]);
							this._F_AllowEdit = DataUtils.ConvertValue<bool>(reader["F_AllowEdit"]);
							this._F_AllowDelete = DataUtils.ConvertValue<bool>(reader["F_AllowDelete"]);
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
							this._F_ParentId =  DataUtils.ConvertValue<string>(row["F_ParentId"]);
							this._F_Layers =  DataUtils.ConvertValue<int?>(row["F_Layers"]);
							this._F_EnCode =  DataUtils.ConvertValue<string>(row["F_EnCode"]);
							this._F_FullName =  DataUtils.ConvertValue<string>(row["F_FullName"]);
							this._F_ShortName =  DataUtils.ConvertValue<string>(row["F_ShortName"]);
							this._F_CategoryId =  DataUtils.ConvertValue<string>(row["F_CategoryId"]);
							this._F_ManagerId =  DataUtils.ConvertValue<string>(row["F_ManagerId"]);
							this._F_TelePhone =  DataUtils.ConvertValue<string>(row["F_TelePhone"]);
							this._F_MobilePhone =  DataUtils.ConvertValue<string>(row["F_MobilePhone"]);
							this._F_WeChat =  DataUtils.ConvertValue<string>(row["F_WeChat"]);
							this._F_Fax =  DataUtils.ConvertValue<string>(row["F_Fax"]);
							this._F_Email =  DataUtils.ConvertValue<string>(row["F_Email"]);
							this._F_AreaId =  DataUtils.ConvertValue<string>(row["F_AreaId"]);
							this._F_Address =  DataUtils.ConvertValue<string>(row["F_Address"]);
							this._F_AllowEdit =  DataUtils.ConvertValue<bool>(row["F_AllowEdit"]);
							this._F_AllowDelete =  DataUtils.ConvertValue<bool>(row["F_AllowDelete"]);
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
            public readonly static Field All = new Field("*", "sys_organize");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ParentId = new Field("F_ParentId", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Layers = new Field("F_Layers", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_EnCode = new Field("F_EnCode", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_FullName = new Field("F_FullName", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ShortName = new Field("F_ShortName", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CategoryId = new Field("F_CategoryId", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ManagerId = new Field("F_ManagerId", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_TelePhone = new Field("F_TelePhone", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_MobilePhone = new Field("F_MobilePhone", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_WeChat = new Field("F_WeChat", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Fax = new Field("F_Fax", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Email = new Field("F_Email", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_AreaId = new Field("F_AreaId", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Address = new Field("F_Address", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_AllowEdit = new Field("F_AllowEdit", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_AllowDelete = new Field("F_AllowDelete", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_SortCode = new Field("F_SortCode", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DeleteMark = new Field("F_DeleteMark", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_EnabledMark = new Field("F_EnabledMark", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Description = new Field("F_Description", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorTime = new Field("F_CreatorTime", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorUserId = new Field("F_CreatorUserId", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LastModifyTime = new Field("F_LastModifyTime", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_LastModifyUserId = new Field("F_LastModifyUserId", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DeleteTime = new Field("F_DeleteTime", "sys_organize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_DeleteUserId = new Field("F_DeleteUserId", "sys_organize", "");
			
        }
		#endregion
        
    }

}
