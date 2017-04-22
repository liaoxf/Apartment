	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class bookinghouse
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
        /// 租赁客户ID号
        /// </summary>
		 public int? LeaseCustomerId { get; set; }
	    /// <summary>
        /// 租赁客户的姓名
        /// </summary>
		 public string LeaseCustomerName { get; set; }
	    /// <summary>
        /// LeaseCustomerAccount
        /// </summary>
		 public string LeaseCustomerAccount { get; set; }
	    /// <summary>
        /// 房东ID
        /// </summary>
		 public int? LandlordId { get; set; }
	    /// <summary>
        /// 房屋ID号
        /// </summary>
		 public int? HouseId { get; set; }
	    /// <summary>
        /// 预约看房时间
        /// </summary>
		 public DateTime? BookingTime { get; set; }
	    /// <summary>
        /// 看房状态：0表示待看；1表示满意；2不满意；
        /// </summary>
		 public int? LookStatus { get; set; }
	    /// <summary>
        /// 预约失败的原因
        /// </summary>
		 public string Reason { get; set; }
	    /// <summary>
        /// 创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 预约看房备注
        /// </summary>
		 public string BookingRemark { get; set; }
		#endregion
    }

}
