	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class demand
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
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
        /// 用户性别
        /// </summary>
		 public string UserGender { get; set; }
	    /// <summary>
        /// 出价范围
        /// </summary>
		 public string Price { get; set; }
	    /// <summary>
        /// 出租方式
        /// </summary>
		 public string RentMode { get; set; }
	    /// <summary>
        /// 区
        /// </summary>
		 public string District { get; set; }
	    /// <summary>
        /// 户型
        /// </summary>
		 public string HRoom { get; set; }
	    /// <summary>
        /// 找房地址
        /// </summary>
		 public string Address { get; set; }
	    /// <summary>
        /// 其他需求
        /// </summary>
		 public string Other { get; set; }
	    /// <summary>
        /// 创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 操作人ID
        /// </summary>
		 public string OperatorId { get; set; }
	    /// <summary>
        /// 操作人账号
        /// </summary>
		 public string OperatorName { get; set; }
	    /// <summary>
        /// 是否已经处理（0表示未处理；1表示已处理；）
        /// </summary>
		 public int? IsHandle { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 退单原因
        /// </summary>
		 public string BackReason { get; set; }
	    /// <summary>
        /// 来源：0表示系统；1表示微信端；2表示Ios；3表示安卓；4表示PC；5表示活动；6表示其他；
        /// </summary>
		 public int? Source { get; set; }
	    /// <summary>
        /// 是否支付：0表示未支付；1表示已支付
        /// </summary>
		 public int? IsPay { get; set; }
	    /// <summary>
        /// 是否登录：0表示未登录；1表示已登录
        /// </summary>
		 public int? IsLogin { get; set; }
		#endregion
    }

}
