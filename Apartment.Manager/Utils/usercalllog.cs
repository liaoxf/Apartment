	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class usercalllog
    {

	    #region Field
	    /// <summary>
        /// 主键自增ID号
        /// </summary>
		 public int Id { get; set; }
	    /// <summary>
        /// 用户ID号
        /// </summary>
		 public int? UserID { get; set; }
	    /// <summary>
        /// 登录账号
        /// </summary>
		 public string LoginAccount { get; set; }
	    /// <summary>
        /// 房源ID
        /// </summary>
		 public int? HouseId { get; set; }
	    /// <summary>
        /// 房源标题
        /// </summary>
		 public string HouseTitle { get; set; }
	    /// <summary>
        /// 拨打电话号码
        /// </summary>
		 public string CallMobile { get; set; }
	    /// <summary>
        /// 拨打时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
		#endregion
    }

}
