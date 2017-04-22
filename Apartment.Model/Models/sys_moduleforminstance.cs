	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_moduleforminstance : EntityExt
    {

		public sys_moduleforminstance() : base("sys_moduleforminstance") { }
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
		
        private string _F_FormId = string.Empty;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public string F_FormId
        {
            get { return _F_FormId; }
            set
            {
                this.OnPropertyValueChange(_.F_FormId, _F_FormId, value);
                this._F_FormId = value;
                
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
		
        private object _F_InstanceJson = null;
		      	
	    /// <summary>
        /// 
        /// </summary>
        public object F_InstanceJson
        {
            get { return _F_InstanceJson; }
            set
            {
                this.OnPropertyValueChange(_.F_InstanceJson, _F_InstanceJson, value);
                this._F_InstanceJson = value;
                
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
            return new Field[] {_.F_Id,_.F_FormId,_.F_ObjectId,_.F_InstanceJson,_.F_SortCode,_.F_CreatorTime,_.F_CreatorUserId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_FormId,this._F_ObjectId,this._F_InstanceJson,this._F_SortCode,this._F_CreatorTime,this._F_CreatorUserId };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._F_Id = DataUtils.ConvertValue<string>(reader["F_Id"]);
							this._F_FormId = DataUtils.ConvertValue<string>(reader["F_FormId"]);
							this._F_ObjectId = DataUtils.ConvertValue<string>(reader["F_ObjectId"]);
							this._F_InstanceJson = DataUtils.ConvertValue<object>(reader["F_InstanceJson"]);
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
							this._F_FormId =  DataUtils.ConvertValue<string>(row["F_FormId"]);
							this._F_ObjectId =  DataUtils.ConvertValue<string>(row["F_ObjectId"]);
							this._F_InstanceJson =  DataUtils.ConvertValue<object>(row["F_InstanceJson"]);
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
            public readonly static Field All = new Field("*", "sys_moduleforminstance");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_moduleforminstance", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_FormId = new Field("F_FormId", "sys_moduleforminstance", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_ObjectId = new Field("F_ObjectId", "sys_moduleforminstance", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_InstanceJson = new Field("F_InstanceJson", "sys_moduleforminstance", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_SortCode = new Field("F_SortCode", "sys_moduleforminstance", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorTime = new Field("F_CreatorTime", "sys_moduleforminstance", "");
						/// <summary>
            /// 
            /// </summary>
            public readonly static Field F_CreatorUserId = new Field("F_CreatorUserId", "sys_moduleforminstance", "");
			
        }
		#endregion
        
    }

}
