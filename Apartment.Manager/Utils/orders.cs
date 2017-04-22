	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class orders
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 订单号
        /// </summary>
		 public string OrderNo { get; set; }
	    /// <summary>
        /// 订单状态：0代表已创建意向单；1代表预约看房中；2代表释放订单；3代表正式订单；4代表已出价；5代表已成交；6代表合同生成；7代表成功签约；
        /// </summary>
		 public int OrderStatus { get; set; }
	    /// <summary>
        /// 订单生成时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 订单更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 订单金额
        /// </summary>
		 public decimal OrderAmount { get; set; }
	    /// <summary>
        /// 租赁客户ID号
        /// </summary>
		 public int? LeaseCustomerId { get; set; }
	    /// <summary>
        /// 客户性别
        /// </summary>
		 public string LeaseCustomerGender { get; set; }
	    /// <summary>
        /// 租赁客户的姓名
        /// </summary>
		 public string LeasingCustomerName { get; set; }
	    /// <summary>
        /// 租赁客户手机号
        /// </summary>
		 public string LeasingCustomerMobile { get; set; }
	    /// <summary>
        /// 房屋ID号
        /// </summary>
		 public int? HouseID { get; set; }
	    /// <summary>
        /// 房源小区ID
        /// </summary>
		 public int? HouseVillageId { get; set; }
	    /// <summary>
        /// 房屋全称（小区名称+楼栋号+室号）
        /// </summary>
		 public string HouseName { get; set; }
	    /// <summary>
        /// 房屋名称
        /// </summary>
		 public string HouseTitle { get; set; }
	    /// <summary>
        /// 房屋所在省
        /// </summary>
		 public string HProvince { get; set; }
	    /// <summary>
        /// 房屋所在市
        /// </summary>
		 public string HCity { get; set; }
	    /// <summary>
        /// 房屋所在区
        /// </summary>
		 public string HDistrict { get; set; }
	    /// <summary>
        /// 房东ID号
        /// </summary>
		 public int? LandlordId { get; set; }
	    /// <summary>
        /// 房东名称
        /// </summary>
		 public string LandlordName { get; set; }
	    /// <summary>
        /// 房东手机号
        /// </summary>
		 public string LandlordMobileNo { get; set; }
	    /// <summary>
        /// 订单备注
        /// </summary>
		 public string OrderRemark { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 创建人ID
        /// </summary>
		 public string CreatorID { get; set; }
	    /// <summary>
        /// 操作人姓名
        /// </summary>
		 public string CreatorName { get; set; }
	    /// <summary>
        /// 操作人ID
        /// </summary>
		 public string OperatorID { get; set; }
	    /// <summary>
        /// 操作人姓名
        /// </summary>
		 public string OperatorName { get; set; }
	    /// <summary>
        /// 是否已经预约看房：0表示未预约；1表示已预约；
        /// </summary>
		 public int? IsBooking { get; set; }
	    /// <summary>
        /// 是否已经出价：0代表未出价；1代表已出价；
        /// </summary>
		 public int? IsPriced { get; set; }
	    /// <summary>
        /// 是否已经生成合同：0代表未生成合同；1代表已生成合同；
        /// </summary>
		 public int? IsGenerateContract { get; set; }
	    /// <summary>
        /// 来源：0表示系统；1表示微信端；2表示Ios；3表示安卓；4表示PC；5表示活动；6表示其他；
        /// </summary>
		 public int? Source { get; set; }
	    /// <summary>
        /// 订单成交时间
        /// </summary>
		 public DateTime? DealTime { get; set; }
	    /// <summary>
        /// 合同生成时间
        /// </summary>
		 public DateTime? ContractTime { get; set; }
		#endregion
    }

}
