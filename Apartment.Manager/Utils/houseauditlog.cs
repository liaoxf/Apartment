	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class houseauditlog
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
        /// 房源名称
        /// </summary>
		 public string HouseName { get; set; }
	    /// <summary>
        /// 是否前端显示，1显示，0不显示
        /// </summary>
		 public string TypeLog { get; set; }
	    /// <summary>
        /// 日志备注
        /// </summary>
		 public string LogRemark { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 房源审核日志创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 审核人
        /// </summary>
		 public string AddBy { get; set; }
	    /// <summary>
        /// 审核人
        /// </summary>
		 public string AddName { get; set; }
		#endregion
    }

}
