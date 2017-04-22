	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_roleauthorize : EntityExt
    {

		public sys_roleauthorize() : base("sys_roleauthorize") { }
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
		
        private int? _F_ItemType = int.MinValue;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public int? F_ItemType
        {
            get { return _F_ItemType; }
            set
            {
                this.OnPropertyValueChange(_.F_ItemType, _F_ItemType, value);
                this._F_ItemType = value;
                
            }
        }
		
        private string _F_ItemId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ItemId
        {
            get { return _F_ItemId; }
            set
            {
                this.OnPropertyValueChange(_.F_ItemId, _F_ItemId, value);
                this._F_ItemId = value;
                
            }
        }
		
        private int? _F_ObjectType = int.MinValue;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public int? F_ObjectType
        {
            get { return _F_ObjectType; }
            set
            {
                this.OnPropertyValueChange(_.F_ObjectType, _F_ObjectType, value);
                this._F_ObjectType = value;
                
            }
        }
		
        private string _F_ObjectId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_ObjectId
        {
            get { return _F_ObjectId; }
            set
            {
                this.OnPropertyValueChange(_.F_ObjectId, _F_ObjectId, value);
                this._F_ObjectId = value;
                
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
            return new Field[] {_.F_Id,_.F_ItemType,_.F_ItemId,_.F_ObjectType,_.F_ObjectId,_.F_SortCode,_.F_CreatorTime,_.F_CreatorUserId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_ItemType,this._F_ItemId,this._F_ObjectType,this._F_ObjectId,this._F_SortCode,this._F_CreatorTime,this._F_CreatorUserId };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._F_Id = DataUtils.ConvertValue<string>(reader["F_Id"]);
							this._F_ItemType = DataUtils.ConvertValue<int?>(reader["F_ItemType"]);
							this._F_ItemId = DataUtils.ConvertValue<string>(reader["F_ItemId"]);
							this._F_ObjectType = DataUtils.ConvertValue<int?>(reader["F_ObjectType"]);
							this._F_ObjectId = DataUtils.ConvertValue<string>(reader["F_ObjectId"]);
							this._F_SortCode = DataUtils.ConvertValue<int?>(reader["F_SortCode"]);
							this._F_CreatorTime = DataUtils.ConvertValue<byte[]>(reader["F_CreatorTime"]);
							this._F_CreatorUserId = DataUtils.ConvertValue<string>(reader["F_CreatorUserId"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._F_Id =  DataUtils.ConvertValue<string>(row["F_Id"]);
							this._F_ItemType =  DataUtils.ConvertValue<int?>(row["F_ItemType"]);
							this._F_ItemId =  DataUtils.ConvertValue<string>(row["F_ItemId"]);
							this._F_ObjectType =  DataUtils.ConvertValue<int?>(row["F_ObjectType"]);
							this._F_ObjectId =  DataUtils.ConvertValue<string>(row["F_ObjectId"]);
							this._F_SortCode =  DataUtils.ConvertValue<int?>(row["F_SortCode"]);
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
            public readonly static Field All = new Field("*", "sys_roleauthorize");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ItemType = new Field("F_ItemType", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ItemId = new Field("F_ItemId", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ObjectType = new Field("F_ObjectType", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ObjectId = new Field("F_ObjectId", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_SortCode = new Field("F_SortCode", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorTime = new Field("F_CreatorTime", "sys_roleauthorize", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorUserId = new Field("F_CreatorUserId", "sys_roleauthorize", "");
			
        }
		#endregion
        
    }

}
