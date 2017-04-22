	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_houseexpand : EntityExt
    {

		public ap_houseexpand() : base("ap_houseexpand") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 主键自增ID号
        /// </summary>
        public new long Id
        {
            get { return _Id ==0 ? base.Id :_Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
                
            }
        }
		      	
        private long? _HouseId = int.MinValue;
		      	
	    /// <summary>
        /// 房屋的ID号
        /// </summary>
        public long? HouseId
        {
            get { return _HouseId; }
            set
            {
                this.OnPropertyValueChange(_.HouseId, _HouseId, value);
                this._HouseId = value;
                
            }
        }
		
        private int? _IsDelegate = int.MinValue;
		      	
	    /// <summary>
        /// 是否委托：0代表否；1代表是；
        /// </summary>
        public int? IsDelegate
        {
            get { return _IsDelegate; }
            set
            {
                this.OnPropertyValueChange(_.IsDelegate, _IsDelegate, value);
                this._IsDelegate = value;
                
            }
        }
		
        private string _HouseRemark = string.Empty;
		      	
	    /// <summary>
        /// 房源备注
        /// </summary>
        public string HouseRemark
        {
            get { return _HouseRemark; }
            set
            {
                this.OnPropertyValueChange(_.HouseRemark, _HouseRemark, value);
                this._HouseRemark = value;
                
            }
        }
		
        private string _GenderLimit = string.Empty;
		      	
	    /// <summary>
        /// 性别限制
        /// </summary>
        public string GenderLimit
        {
            get { return _GenderLimit; }
            set
            {
                this.OnPropertyValueChange(_.GenderLimit, _GenderLimit, value);
                this._GenderLimit = value;
                
            }
        }
		
        private int? _HouseType = int.MinValue;
		      	
	    /// <summary>
        /// 住宅类型
        /// </summary>
        public int? HouseType
        {
            get { return _HouseType; }
            set
            {
                this.OnPropertyValueChange(_.HouseType, _HouseType, value);
                this._HouseType = value;
                
            }
        }
		
        private string _HouseConfig = string.Empty;
		      	
	    /// <summary>
        /// 房屋配置（多个房屋配置以逗号隔开）
        /// </summary>
        public string HouseConfig
        {
            get { return _HouseConfig; }
            set
            {
                this.OnPropertyValueChange(_.HouseConfig, _HouseConfig, value);
                this._HouseConfig = value;
                
            }
        }
		
        private string _HDetails = string.Empty;
		      	
	    /// <summary>
        /// 详细介绍
        /// </summary>
        public string HDetails
        {
            get { return _HDetails; }
            set
            {
                this.OnPropertyValueChange(_.HDetails, _HDetails, value);
                this._HDetails = value;
                
            }
        }
		
        private string _LinkTel = string.Empty;
		      	
	    /// <summary>
        /// 联系电话
        /// </summary>
        public string LinkTel
        {
            get { return _LinkTel; }
            set
            {
                this.OnPropertyValueChange(_.LinkTel, _LinkTel, value);
                this._LinkTel = value;
                
            }
        }
		
        private string _LinkMan = string.Empty;
		      	
	    /// <summary>
        /// 联系人
        /// </summary>
        public string LinkMan
        {
            get { return _LinkMan; }
            set
            {
                this.OnPropertyValueChange(_.LinkMan, _LinkMan, value);
                this._LinkMan = value;
                
            }
        }
		
        private int? _IsDel = 0;
		      	
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
        public int? IsDel
        {
            get { return _IsDel; }
            set
            {
                this.OnPropertyValueChange(_.IsDel, _IsDel, value);
                this._IsDel = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange(_.AddTime, _AddTime, value);
                this._AddTime = value;
                
            }
        }
		
        private DateTime? _LastUpdateTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return _LastUpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.LastUpdateTime, _LastUpdateTime, value);
                this._LastUpdateTime = value;
                
            }
        }
				#endregion

		#region Method

		        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {_.Id };
        }
				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.Id,_.HouseId,_.IsDelegate,_.HouseRemark,_.GenderLimit,_.HouseType,_.HouseConfig,_.HDetails,_.LinkTel,_.LinkMan,_.IsDel,_.AddTime,_.LastUpdateTime};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._HouseId,this._IsDelegate,this._HouseRemark,this._GenderLimit,this._HouseType,this._HouseConfig,this._HDetails,this._LinkTel,this._LinkMan,this._IsDel,this._AddTime,this._LastUpdateTime };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._HouseId = DataUtils.ConvertValue<long?>(reader["HouseId"]);
							this._IsDelegate = DataUtils.ConvertValue<int?>(reader["IsDelegate"]);
							this._HouseRemark = DataUtils.ConvertValue<string>(reader["HouseRemark"]);
							this._GenderLimit = DataUtils.ConvertValue<string>(reader["GenderLimit"]);
							this._HouseType = DataUtils.ConvertValue<int?>(reader["HouseType"]);
							this._HouseConfig = DataUtils.ConvertValue<string>(reader["HouseConfig"]);
							this._HDetails = DataUtils.ConvertValue<string>(reader["HDetails"]);
							this._LinkTel = DataUtils.ConvertValue<string>(reader["LinkTel"]);
							this._LinkMan = DataUtils.ConvertValue<string>(reader["LinkMan"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._HouseId =  DataUtils.ConvertValue<long?>(row["HouseId"]);
							this._IsDelegate =  DataUtils.ConvertValue<int?>(row["IsDelegate"]);
							this._HouseRemark =  DataUtils.ConvertValue<string>(row["HouseRemark"]);
							this._GenderLimit =  DataUtils.ConvertValue<string>(row["GenderLimit"]);
							this._HouseType =  DataUtils.ConvertValue<int?>(row["HouseType"]);
							this._HouseConfig =  DataUtils.ConvertValue<string>(row["HouseConfig"]);
							this._HDetails =  DataUtils.ConvertValue<string>(row["HDetails"]);
							this._LinkTel =  DataUtils.ConvertValue<string>(row["LinkTel"]);
							this._LinkMan =  DataUtils.ConvertValue<string>(row["LinkMan"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
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
            public readonly static Field All = new Field("*", "ap_houseexpand");
						/// <summary>
            /// 主键自增ID号
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_houseexpand", "主键自增ID号");
						/// <summary>
            /// 房屋的ID号
            /// </summary>
            public readonly static Field HouseId = new Field("HouseId", "ap_houseexpand", "房屋的ID号");
						/// <summary>
            /// 是否委托：0代表否；1代表是；
            /// </summary>
            public readonly static Field IsDelegate = new Field("IsDelegate", "ap_houseexpand", "是否委托：0代表否；1代表是；");
						/// <summary>
            /// 房源备注
            /// </summary>
            public readonly static Field HouseRemark = new Field("HouseRemark", "ap_houseexpand", "房源备注");
						/// <summary>
            /// 性别限制
            /// </summary>
            public readonly static Field GenderLimit = new Field("GenderLimit", "ap_houseexpand", "性别限制");
						/// <summary>
            /// 住宅类型
            /// </summary>
            public readonly static Field HouseType = new Field("HouseType", "ap_houseexpand", "住宅类型");
						/// <summary>
            /// 房屋配置（多个房屋配置以逗号隔开）
            /// </summary>
            public readonly static Field HouseConfig = new Field("HouseConfig", "ap_houseexpand", "房屋配置（多个房屋配置以逗号隔开）");
						/// <summary>
            /// 详细介绍
            /// </summary>
            public readonly static Field HDetails = new Field("HDetails", "ap_houseexpand", "详细介绍");
						/// <summary>
            /// 联系电话
            /// </summary>
            public readonly static Field LinkTel = new Field("LinkTel", "ap_houseexpand", "联系电话");
						/// <summary>
            /// 联系人
            /// </summary>
            public readonly static Field LinkMan = new Field("LinkMan", "ap_houseexpand", "联系人");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_houseexpand", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_houseexpand", "创建时间");
						/// <summary>
            /// 更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_houseexpand", "更新时间");
			
        }
		#endregion
        
    }

}
