	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class houserefreshlog
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 房源ID号
        /// </summary>
		 public int? HouseId { get; set; }
	    /// <summary>
        /// 操作人ID号
        /// </summary>
		 public int? OperatorId { get; set; }
	    /// <summary>
        /// 操作人名称
        /// </summary>
		 public string OperatorName { get; set; }
	    /// <summary>
        /// 房源标题
        /// </summary>
		 public string HouseTitle { get; set; }
	    /// <summary>
        /// 刷新时间
        /// </summary>
		 public DateTime? RefreshTime { get; set; }
		#endregion
    }

}
