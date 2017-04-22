using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
   public class HousePicRequest
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string PicUrl { get; set; }
        /// <summary>
        /// 缩略图地址
        /// </summary>
        public string ThumbUrl { get; set; }
        /// <summary>
        /// 房源资源类型
        /// </summary>
        public int? ResourceType { get; set; }
        /// <summary>
        /// 房源Id
        /// </summary>
        public int? HouseId { get; set; }
        ///// <summary>
        ///// 软删除：0表示未删除；1表示已删除
        ///// </summary>
        //public int? IsDel { get; set; }
        ///// <summary>
        ///// 房源图片创建时间
        ///// </summary>
        //public DateTime? AddTime { get; set; }
        ///// <summary>
        ///// 房源图片更新时间
        ///// </summary>
        //public DateTime? LastUpdateTime { get; set; }
        #endregion
    }
}
