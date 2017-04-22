	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_housevillagepic : EntityExt
    {

		public ap_housevillagepic() : base("ap_housevillagepic") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 主键
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
		      	
        private long? _HouseVillageId = int.MinValue;
		      	
	    /// <summary>
        /// 房源小区Id
        /// </summary>
        public long? HouseVillageId
        {
            get { return _HouseVillageId; }
            set
            {
                this.OnPropertyValueChange(_.HouseVillageId, _HouseVillageId, value);
                this._HouseVillageId = value;
                
            }
        }
		
        private string _PicUrl = string.Empty;
		      	
	    /// <summary>
        /// 图片地址
        /// </summary>
        public string PicUrl
        {
            get { return _PicUrl; }
            set
            {
                this.OnPropertyValueChange(_.PicUrl, _PicUrl, value);
                this._PicUrl = value;
                
            }
        }
		
        private string _ThumbUrl = string.Empty;
		      	
	    /// <summary>
        /// 缩略图地址
        /// </summary>
        public string ThumbUrl
        {
            get { return _ThumbUrl; }
            set
            {
                this.OnPropertyValueChange(_.ThumbUrl, _ThumbUrl, value);
                this._ThumbUrl = value;
                
            }
        }
		
        private int? _ResourceType = int.MinValue;
		      	
	    /// <summary>
        /// 房源资源类型
        /// </summary>
        public int? ResourceType
        {
            get { return _ResourceType; }
            set
            {
                this.OnPropertyValueChange(_.ResourceType, _ResourceType, value);
                this._ResourceType = value;
                
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
        /// 房源图片创建时间
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
        /// 房源图片更新时间
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
            return new Field[] {_.Id,_.HouseVillageId,_.PicUrl,_.ThumbUrl,_.ResourceType,_.IsDel,_.AddTime,_.LastUpdateTime};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._HouseVillageId,this._PicUrl,this._ThumbUrl,this._ResourceType,this._IsDel,this._AddTime,this._LastUpdateTime };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._HouseVillageId = DataUtils.ConvertValue<long?>(reader["HouseVillageId"]);
							this._PicUrl = DataUtils.ConvertValue<string>(reader["PicUrl"]);
							this._ThumbUrl = DataUtils.ConvertValue<string>(reader["ThumbUrl"]);
							this._ResourceType = DataUtils.ConvertValue<int?>(reader["ResourceType"]);
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
							this._HouseVillageId =  DataUtils.ConvertValue<long?>(row["HouseVillageId"]);
							this._PicUrl =  DataUtils.ConvertValue<string>(row["PicUrl"]);
							this._ThumbUrl =  DataUtils.ConvertValue<string>(row["ThumbUrl"]);
							this._ResourceType =  DataUtils.ConvertValue<int?>(row["ResourceType"]);
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
            public readonly static Field All = new Field("*", "ap_housevillagepic");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_housevillagepic", "主键");
						/// <summary>
            /// 房源小区Id
            /// </summary>
            public readonly static Field HouseVillageId = new Field("HouseVillageId", "ap_housevillagepic", "房源小区Id");
						/// <summary>
            /// 图片地址
            /// </summary>
            public readonly static Field PicUrl = new Field("PicUrl", "ap_housevillagepic", "图片地址");
						/// <summary>
            /// 缩略图地址
            /// </summary>
            public readonly static Field ThumbUrl = new Field("ThumbUrl", "ap_housevillagepic", "缩略图地址");
						/// <summary>
            /// 房源资源类型
            /// </summary>
            public readonly static Field ResourceType = new Field("ResourceType", "ap_housevillagepic", "房源资源类型");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_housevillagepic", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 房源图片创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_housevillagepic", "房源图片创建时间");
						/// <summary>
            /// 房源图片更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_housevillagepic", "房源图片更新时间");
			
        }
		#endregion
        
    }

}
