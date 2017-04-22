	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class sys_subway : EntityExt
    {

		public sys_subway() : base("sys_subway") { }
	    #region Field

        private string _F_Id = string.Empty;
		      	
	    /// <summary>
        /// 主键
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
        /// 父级
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
        /// 层级
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
        /// 英文编号
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
        /// 全称
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
		
        private string _F_SimpleSpelling = string.Empty;
		      	
	    /// <summary>
        /// 简称
        /// </summary>
        public string F_SimpleSpelling
        {
            get { return _F_SimpleSpelling; }
            set
            {
                this.OnPropertyValueChange(_.F_SimpleSpelling, _F_SimpleSpelling, value);
                this._F_SimpleSpelling = value;
                
            }
        }
		
        private decimal _F_XCoordinate = 0;
		      	
	    /// <summary>
        /// 地铁站坐标（经度）
        /// </summary>
        public decimal F_XCoordinate
        {
            get { return _F_XCoordinate; }
            set
            {
                this.OnPropertyValueChange(_.F_XCoordinate, _F_XCoordinate, value);
                this._F_XCoordinate = value;
                
            }
        }
		
        private decimal _F_YCoordinate = 0;
		      	
	    /// <summary>
        /// 地铁站坐标（纬度）
        /// </summary>
        public decimal F_YCoordinate
        {
            get { return _F_YCoordinate; }
            set
            {
                this.OnPropertyValueChange(_.F_YCoordinate, _F_YCoordinate, value);
                this._F_YCoordinate = value;
                
            }
        }
		
        private int? _F_SortCode = int.MinValue;
		      	
	    /// <summary>
        /// 排序
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
        /// 删除标志
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
        /// 允许标志
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
        /// 描述
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
        /// 创建时间
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
        /// 创建人ID号
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
        /// 修改时间
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
        /// 修改人ID
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
        /// 删除时间
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
        /// 删除人ID
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
            return new Field[] {_.F_Id,_.F_ParentId,_.F_Layers,_.F_EnCode,_.F_FullName,_.F_SimpleSpelling,_.F_XCoordinate,_.F_YCoordinate,_.F_SortCode,_.F_DeleteMark,_.F_EnabledMark,_.F_Description,_.F_CreatorTime,_.F_CreatorUserId,_.F_LastModifyTime,_.F_LastModifyUserId,_.F_DeleteTime,_.F_DeleteUserId};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._F_Id,this._F_ParentId,this._F_Layers,this._F_EnCode,this._F_FullName,this._F_SimpleSpelling,this._F_XCoordinate,this._F_YCoordinate,this._F_SortCode,this._F_DeleteMark,this._F_EnabledMark,this._F_Description,this._F_CreatorTime,this._F_CreatorUserId,this._F_LastModifyTime,this._F_LastModifyUserId,this._F_DeleteTime,this._F_DeleteUserId };
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
							this._F_SimpleSpelling = DataUtils.ConvertValue<string>(reader["F_SimpleSpelling"]);
							this._F_XCoordinate = DataUtils.ConvertValue<decimal>(reader["F_XCoordinate"]);
							this._F_YCoordinate = DataUtils.ConvertValue<decimal>(reader["F_YCoordinate"]);
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
							this._F_SimpleSpelling =  DataUtils.ConvertValue<string>(row["F_SimpleSpelling"]);
							this._F_XCoordinate =  DataUtils.ConvertValue<decimal>(row["F_XCoordinate"]);
							this._F_YCoordinate =  DataUtils.ConvertValue<decimal>(row["F_YCoordinate"]);
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
            public readonly static Field All = new Field("*", "sys_subway");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field F_Id = new Field("F_Id", "sys_subway", "主键");
						/// <summary>
            /// 父级
            /// </summary>
            public readonly static Field F_ParentId = new Field("F_ParentId", "sys_subway", "父级");
						/// <summary>
            /// 层级
            /// </summary>
            public readonly static Field F_Layers = new Field("F_Layers", "sys_subway", "层级");
						/// <summary>
            /// 英文编号
            /// </summary>
            public readonly static Field F_EnCode = new Field("F_EnCode", "sys_subway", "英文编号");
						/// <summary>
            /// 全称
            /// </summary>
            public readonly static Field F_FullName = new Field("F_FullName", "sys_subway", "全称");
						/// <summary>
            /// 简称
            /// </summary>
            public readonly static Field F_SimpleSpelling = new Field("F_SimpleSpelling", "sys_subway", "简称");
						/// <summary>
            /// 地铁站坐标（经度）
            /// </summary>
            public readonly static Field F_XCoordinate = new Field("F_XCoordinate", "sys_subway", "地铁站坐标（经度）");
						/// <summary>
            /// 地铁站坐标（纬度）
            /// </summary>
            public readonly static Field F_YCoordinate = new Field("F_YCoordinate", "sys_subway", "地铁站坐标（纬度）");
						/// <summary>
            /// 排序
            /// </summary>
            public readonly static Field F_SortCode = new Field("F_SortCode", "sys_subway", "排序");
						/// <summary>
            /// 删除标志
            /// </summary>
            public readonly static Field F_DeleteMark = new Field("F_DeleteMark", "sys_subway", "删除标志");
						/// <summary>
            /// 允许标志
            /// </summary>
            public readonly static Field F_EnabledMark = new Field("F_EnabledMark", "sys_subway", "允许标志");
						/// <summary>
            /// 描述
            /// </summary>
            public readonly static Field F_Description = new Field("F_Description", "sys_subway", "描述");
						/// <summary>
            /// 创建时间
            /// </summary>
            public readonly static Field F_CreatorTime = new Field("F_CreatorTime", "sys_subway", "创建时间");
						/// <summary>
            /// 创建人ID号
            /// </summary>
            public readonly static Field F_CreatorUserId = new Field("F_CreatorUserId", "sys_subway", "创建人ID号");
						/// <summary>
            /// 修改时间
            /// </summary>
            public readonly static Field F_LastModifyTime = new Field("F_LastModifyTime", "sys_subway", "修改时间");
						/// <summary>
            /// 修改人ID
            /// </summary>
            public readonly static Field F_LastModifyUserId = new Field("F_LastModifyUserId", "sys_subway", "修改人ID");
						/// <summary>
            /// 删除时间
            /// </summary>
            public readonly static Field F_DeleteTime = new Field("F_DeleteTime", "sys_subway", "删除时间");
						/// <summary>
            /// 删除人ID
            /// </summary>
            public readonly static Field F_DeleteUserId = new Field("F_DeleteUserId", "sys_subway", "删除人ID");
			
        }
		#endregion
        
    }

}
