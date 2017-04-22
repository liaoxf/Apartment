	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class activity
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 封面图片
        /// </summary>
		 public string PicUrl { get; set; }
	    /// <summary>
        /// 活动名称
        /// </summary>
		 public string ActivityName { get; set; }
	    /// <summary>
        /// 活动URL
        /// </summary>
		 public string ActivityUrl { get; set; }
	    /// <summary>
        /// 排序
        /// </summary>
		 public int? Sort { get; set; }
	    /// <summary>
        /// 操作人ID
        /// </summary>
		 public string OperatorID { get; set; }
	    /// <summary>
        /// 操作人姓名
        /// </summary>
		 public string OperatorName { get; set; }
	    /// <summary>
        /// 描述
        /// </summary>
		 public string Discription { get; set; }
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
