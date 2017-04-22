	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class orderpic
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
        /// 图片类型：0代表订单合同图片；
        /// </summary>
		 public int? PicType { get; set; }
	    /// <summary>
        /// 图片地址
        /// </summary>
		 public string ImgUrl { get; set; }
	    /// <summary>
        /// 新增时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 描述
        /// </summary>
		 public string Remark { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
		#endregion
    }

}
