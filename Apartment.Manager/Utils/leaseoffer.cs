	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class leaseoffer
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
        /// 房源Id号
        /// </summary>
		 public int? HouseId { get; set; }
	    /// <summary>
        /// 房源名称
        /// </summary>
		 public string HouseName { get; set; }
	    /// <summary>
        /// 房东ID号
        /// </summary>
		 public int? LandlordId { get; set; }
	    /// <summary>
        /// 房东账号：即为登录手机号
        /// </summary>
		 public string LandlordAccount { get; set; }
	    /// <summary>
        /// 房东姓名
        /// </summary>
		 public string LandlordName { get; set; }
	    /// <summary>
        /// 用户ID号
        /// </summary>
		 public int? UserId { get; set; }
	    /// <summary>
        /// 用户账号
        /// </summary>
		 public string UserAccount { get; set; }
	    /// <summary>
        /// 用户姓名
        /// </summary>
		 public string UserName { get; set; }
	    /// <summary>
        /// 出价金额
        /// </summary>
		 public decimal OfferPrice { get; set; }
	    /// <summary>
        /// 对房东说的话
        /// </summary>
		 public string ToLandlordContent { get; set; }
	    /// <summary>
        /// 0代表：普通出价；1表示当面签约出价；
        /// </summary>
		 public int? Type { get; set; }
	    /// <summary>
        /// 出价创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 出价更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 房东是否同意：0表示待确认；1表示同意；2表示不同意；
        /// </summary>
		 public int? IsAgree { get; set; }
	    /// <summary>
        /// 房东不同意的原因
        /// </summary>
		 public string NoPassReason { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
		#endregion
    }

}
