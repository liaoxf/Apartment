	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class housevillageauditlog
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 房源小区ID号
        /// </summary>
		 public int? HouseVillageId { get; set; }
	    /// <summary>
        /// 房源小区名称
        /// </summary>
		 public string HouseName { get; set; }
	    /// <summary>
        /// 房屋小区状态
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
        /// 创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
		#endregion
    }

}
