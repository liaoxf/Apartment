	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class activityqrcode
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 活动ID号
        /// </summary>
		 public int? ActivityId { get; set; }
	    /// <summary>
        /// 二维码地址
        /// </summary>
		 public string QrCode { get; set; }
	    /// <summary>
        /// 扫码次数
        /// </summary>
		 public int? ScanCount { get; set; }
	    /// <summary>
        /// 备注
        /// </summary>
		 public string Remark { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 添加时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
		#endregion
    }

}
