using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
   public class HouseExpandRequest
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 房屋的ID号
        /// </summary>
        public int? HouseId { get; set; }
        /// <summary>
        /// 是否委托：0代表否；1代表是；
        /// </summary>
        public int? IsDelegate { get; set; }
        /// <summary>
        /// 房源备注
        /// </summary>
        public string HouseRemark { get; set; }
        /// <summary>
        /// 性别限制
        /// </summary>
        public string GenderLimit { get; set; }
        /// <summary>
        /// 住宅类型
        /// </summary>
        public string HouseType { get; set; }
        /// <summary>
        /// 房屋配置（多个房屋配置以逗号隔开）
        /// </summary>
        public string HouseConfig { get; set; }
        /// <summary>
        /// 详细介绍
        /// </summary>
        public string HDetails { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string LinkTel { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string LinkMan { get; set; }
        ///// <summary>
        ///// 软删除：0表示未删除；1表示已删除
        ///// </summary>
        //public int? IsDel { get; set; }
        ///// <summary>
        ///// 创建时间
        ///// </summary>
        //public DateTime? AddTime { get; set; }
        ///// <summary>
        ///// 更新时间
        ///// </summary>
        //public DateTime? LastUpdateTime { get; set; }
        #endregion
    }
}
