	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class house
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 房源标题
        /// </summary>
		 public string HouseTitle { get; set; }
	    /// <summary>
        /// 用户ID号
        /// </summary>
		 public int? UserId { get; set; }
	    /// <summary>
        /// 用户真实姓名
        /// </summary>
		 public string UserRealName { get; set; }
	    /// <summary>
        /// 房源总状态状态：0代表待审核；1代表审核通过；2代表审核被驳回；-1 已删除， 10 上架，-10 下架 ，31已刷新，32刷新失败，33 等待刷新
        /// </summary>
		 public int? AuditStatus { get; set; }
	    /// <summary>
        /// 房源状态：0表示未出租；1表示已出租；
        /// </summary>
		 public int? HStatus { get; set; }
	    /// <summary>
        /// 房源标签（多个标签以逗号隔开）
        /// </summary>
		 public string HTags { get; set; }
	    /// <summary>
        /// 出租方式
        /// </summary>
		 public string RentMode { get; set; }
	    /// <summary>
        /// 房源小区ID
        /// </summary>
		 public int? HouseVillageId { get; set; }
	    /// <summary>
        /// 小区名称
        /// </summary>
		 public string AreasName { get; set; }
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
        /// 商圈
        /// </summary>
		 public string TradingArea { get; set; }
	    /// <summary>
        /// 户型（室）
        /// </summary>
		 public int? HRoom { get; set; }
	    /// <summary>
        /// 户型（厅）
        /// </summary>
		 public int? HOffice { get; set; }
	    /// <summary>
        /// 户型（卫）
        /// </summary>
		 public int? HWashroom { get; set; }
	    /// <summary>
        /// 楼层（层级）
        /// </summary>
		 public int? HFloor { get; set; }
	    /// <summary>
        /// 楼层（共计）
        /// </summary>
		 public int? HFloorTotal { get; set; }
	    /// <summary>
        /// 出租面积
        /// </summary>
		 public decimal RentalArea { get; set; }
	    /// <summary>
        /// 卧室
        /// </summary>
		 public string Bedroom { get; set; }
	    /// <summary>
        /// 房源朝向
        /// </summary>
		 public string HDirection { get; set; }
	    /// <summary>
        /// 房屋装修情况
        /// </summary>
		 public string HDecoration { get; set; }
	    /// <summary>
        /// 房源租金
        /// </summary>
		 public decimal HRent { get; set; }
	    /// <summary>
        /// 房源坐标（经度）
        /// </summary>
		 public decimal XCoordinate { get; set; }
	    /// <summary>
        /// 房源坐标（纬度）
        /// </summary>
		 public decimal YCoordinate { get; set; }
	    /// <summary>
        /// 房源具体地址
        /// </summary>
		 public string DetailAddress { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 房源创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 房源更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 房源封面
        /// </summary>
		 public string HouseCorver { get; set; }
	    /// <summary>
        /// 点评
        /// </summary>
		 public string CommentsByAdmin { get; set; }
	    /// <summary>
        /// 图片数
        /// </summary>
		 public int? PicsCount { get; set; }
	    /// <summary>
        /// 视频数
        /// </summary>
		 public int? VideoCount { get; set; }
	    /// <summary>
        /// 收藏数
        /// </summary>
		 public int? CollectionNumber { get; set; }
	    /// <summary>
        /// 备注
        /// </summary>
		 public string Remark { get; set; }
	    /// <summary>
        /// 联系电话
        /// </summary>
		 public string LinkTel { get; set; }
	    /// <summary>
        /// 意向房源数
        /// </summary>
		 public int? InterestNumber { get; set; }
	    /// <summary>
        /// 通话量
        /// </summary>
		 public int? CallNumber { get; set; }
	    /// <summary>
        /// 来源,0 默认 用户上传,1 后台上传,2其他
        /// </summary>
		 public int? Source { get; set; }
	    /// <summary>
        /// 审核人Id
        /// </summary>
		 public string AuditId { get; set; }
	    /// <summary>
        /// 审核人名称
        /// </summary>
		 public string AuditName { get; set; }
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
        /// 栋号
        /// </summary>
		 public string BuildingNO { get; set; }
	    /// <summary>
        /// 室号
        /// </summary>
		 public string RoomNO { get; set; }
	    /// <summary>
        /// 上下架，0：未上架，1已上架
        /// </summary>
		 public int? IsOn { get; set; }
	    /// <summary>
        /// 刷新状态：-1 刷新失败，0已刷新，1 待刷新，
        /// </summary>
		 public int? RefreshStatus { get; set; }
	    /// <summary>
        /// 上架时间
        /// </summary>
		 public DateTime? IsOnTime { get; set; }
	    /// <summary>
        /// 审核通过时间
        /// </summary>
		 public DateTime? AuditedTime { get; set; }
	    /// <summary>
        /// 租金方式
        /// </summary>
		 public string RentMoneyWay { get; set; }
	    /// <summary>
        /// 是否公寓，默认0，不是；1是公寓
        /// </summary>
		 public bool? IsAppartment { get; set; }
	    /// <summary>
        /// 房屋配置（多个房屋配置以逗号隔开）
        /// </summary>
		 public string HouseConfig { get; set; }
	    /// <summary>
        /// 浏览量
        /// </summary>
		 public int? VisitCount { get; set; }
	    /// <summary>
        /// 是否置顶，0表示否，1表示置顶
        /// </summary>
		 public int? IsUp { get; set; }
	    /// <summary>
        /// 自定义顺序，采用字母数字混合排序。如a_b_
        /// </summary>
		 public string SelfSort { get; set; }
	    /// <summary>
        /// 是否锁定，0表示默认不锁定，1表示锁定
        /// </summary>
		 public int? IsLock { get; set; }
	    /// <summary>
        /// 删除时间
        /// </summary>
		 public DateTime? DeletedTime { get; set; }
	    /// <summary>
        /// 出租时间
        /// </summary>
		 public DateTime? RentTime { get; set; }
	    /// <summary>
        /// 删除时间
        /// </summary>
		 public DateTime? LockedTime { get; set; }
		#endregion
    }

}
