	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class ordertracklog
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
        /// 订单状态：0代表创建意向单；1代表释放订单；2代表正式订单；3代表确认成交；4代表合同生成；5代表成功签约；
        /// </summary>
		 public int? OrderStatus { get; set; }
	    /// <summary>
        /// 日志备注
        /// </summary>
		 public string LogRemark { get; set; }
	    /// <summary>
        /// 操作人ID号
        /// </summary>
		 public string OperatorId { get; set; }
	    /// <summary>
        /// 操作人姓名
        /// </summary>
		 public string OperatorName { get; set; }
	    /// <summary>
        /// 订单日志生成时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
		#endregion
    }

}
