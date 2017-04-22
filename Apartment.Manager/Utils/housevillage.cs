	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class housevillage
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 所在版块
        /// </summary>
		 public string VillageArea { get; set; }
	    /// <summary>
        /// 住宅类型
        /// </summary>
		 public string HouseType { get; set; }
	    /// <summary>
        /// 建造年代
        /// </summary>
		 public string BuildingAge { get; set; }
	    /// <summary>
        /// 占地面积
        /// </summary>
		 public string AreaCover { get; set; }
	    /// <summary>
        /// 楼栋数
        /// </summary>
		 public int? BuildingTotal { get; set; }
	    /// <summary>
        /// 房屋总数
        /// </summary>
		 public int? HouseTotal { get; set; }
	    /// <summary>
        /// 停车位
        /// </summary>
		 public int? ParkingTotal { get; set; }
	    /// <summary>
        /// 物业费
        /// </summary>
		 public string PropertyFee { get; set; }
	    /// <summary>
        /// 绿化率
        /// </summary>
		 public string GreenCoverage { get; set; }
	    /// <summary>
        /// 容积率
        /// </summary>
		 public string VolumeRatio { get; set; }
	    /// <summary>
        /// 物业公司
        /// </summary>
		 public string PropertyCompany { get; set; }
	    /// <summary>
        /// 
        /// </summary>
		 public string Developer { get; set; }
	    /// <summary>
        /// 描述
        /// </summary>
		 public string Description { get; set; }
	    /// <summary>
        /// 房源坐标（经度）
        /// </summary>
		 public decimal XCoordinate { get; set; }
	    /// <summary>
        /// 房源坐标（纬度）
        /// </summary>
		 public decimal YCoordinate { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 小区状态,0:未审核，1已审核，2审核失败，-1已删除
        /// </summary>
		 public int? Status { get; set; }
	    /// <summary>
        /// 小区名字
        /// </summary>
		 public string VillagName { get; set; }
	    /// <summary>
        /// 房源数
        /// </summary>
		 public int? HouseCount { get; set; }
	    /// <summary>
        /// 成交记录
        /// </summary>
		 public int? SaledHouse { get; set; }
	    /// <summary>
        /// 路线
        /// </summary>
		 public string Line { get; set; }
	    /// <summary>
        /// 封面图片
        /// </summary>
		 public string Cover { get; set; }
	    /// <summary>
        /// 标签，逗号分隔
        /// </summary>
		 public string Tags { get; set; }
	    /// <summary>
        /// 小区点评
        /// </summary>
		 public string CommentsByAdmin { get; set; }
	    /// <summary>
        /// 收藏数
        /// </summary>
		 public int? CollectionNumber { get; set; }
	    /// <summary>
        /// 备注
        /// </summary>
		 public string Remark { get; set; }
	    /// <summary>
        /// 创建人
        /// </summary>
		 public int? AddBy { get; set; }
	    /// <summary>
        /// 省
        /// </summary>
		 public string Province { get; set; }
	    /// <summary>
        /// 市
        /// </summary>
		 public string City { get; set; }
	    /// <summary>
        /// 区
        /// </summary>
		 public string District { get; set; }
	    /// <summary>
        /// 详细地址
        /// </summary>
		 public string DetailsAddress { get; set; }
	    /// <summary>
        /// 最近地铁距离
        /// </summary>
		 public string SubwayDistance { get; set; }
	    /// <summary>
        /// 地铁线路, 用逗号分隔
        /// </summary>
		 public string SubwayLines { get; set; }
	    /// <summary>
        /// 地铁站，用逗号隔开
        /// </summary>
		 public string SubwayStations { get; set; }
	    /// <summary>
        /// 安居客ID
        /// </summary>
		 public string AnJuId { get; set; }
	    /// <summary>
        /// 来源：0默认 导入，1后台上传，2其他
        /// </summary>
		 public int? Source { get; set; }
	    /// <summary>
        /// 维护人
        /// </summary>
		 public string Maintenancer { get; set; }
		#endregion
    }

}
