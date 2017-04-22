	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class banners
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 标题
        /// </summary>
		 public string Title { get; set; }
	    /// <summary>
        /// 描述
        /// </summary>
		 public string Discription { get; set; }
	    /// <summary>
        /// 类别：1表示Banner，2表示引导页，3表示启动页，4表示弹出页，5 表示其他
        /// </summary>
		 public int? Category { get; set; }
	    /// <summary>
        /// 图片地址
        /// </summary>
		 public string PicUrl { get; set; }
	    /// <summary>
        /// 跳转链接
        /// </summary>
		 public string Href { get; set; }
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
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 创建时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 最后修改时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
		#endregion
    }

}
