	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_fileinfo : EntityExt
    {

		public ap_fileinfo() : base("ap_fileinfo") { }
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
		      	
        private long? _DataId = int.MinValue;
		      	
	    /// <summary>
        /// 公寓/房间/其他数据Id
        /// </summary>
        public long? DataId
        {
            get { return _DataId; }
            set
            {
                this.OnPropertyValueChange(_.DataId, _DataId, value);
                this._DataId = value;
                
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
        /// 房源资源类型,0默认未图片，1视频
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
            return new Field[] {_.Id,_.DataId,_.PicUrl,_.ThumbUrl,_.ResourceType,_.IsDel,_.AddTime,_.LastUpdateTime};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._DataId,this._PicUrl,this._ThumbUrl,this._ResourceType,this._IsDel,this._AddTime,this._LastUpdateTime };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._DataId = DataUtils.ConvertValue<long?>(reader["DataId"]);
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
							this._DataId =  DataUtils.ConvertValue<long?>(row["DataId"]);
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
            public readonly static Field All = new Field("*", "ap_fileinfo");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_fileinfo", "主键");
						/// <summary>
            /// 公寓/房间/其他数据Id
            /// </summary>
            public readonly static Field DataId = new Field("DataId", "ap_fileinfo", "公寓/房间/其他数据Id");
						/// <summary>
            /// 图片地址
            /// </summary>
            public readonly static Field PicUrl = new Field("PicUrl", "ap_fileinfo", "图片地址");
						/// <summary>
            /// 缩略图地址
            /// </summary>
            public readonly static Field ThumbUrl = new Field("ThumbUrl", "ap_fileinfo", "缩略图地址");
						/// <summary>
            /// 房源资源类型,0默认未图片，1视频
            /// </summary>
            public readonly static Field ResourceType = new Field("ResourceType", "ap_fileinfo", "房源资源类型,0默认未图片，1视频");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_fileinfo", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 房源图片创建时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_fileinfo", "房源图片创建时间");
						/// <summary>
            /// 房源图片更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_fileinfo", "房源图片更新时间");
			
        }
		#endregion
        
    }

}
