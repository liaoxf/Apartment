using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
    public class HouseResponse
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 房源标题
        /// </summary>
        public string HouseTitle { get; set; }
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        public string UserRealName { get; set; }
        /// <summary>
        /// 审核状态：0代表待审核；1代表审核通过；2代表审核被驳回；
        /// </summary>
        public int? AuditStatus { get; set; }
        /// <summary>
        /// 房源状态：0表示未出租；1表示已出租；
        /// </summary>
        public int? HStatus { get; set; }
        /// <summary>
        /// 房源标签（多个标签以逗号隔开）
        /// </summary>
        public string HTags { get; set; }
        /// <summary>
        /// 出租方式
        /// </summary>
        public string RentMode { get; set; }
        /// <summary>
        /// 小区名称
        /// </summary>
        public string AreasName { get; set; }
        /// <summary>
        /// 区
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// 商圈
        /// </summary>
        public string TradingArea { get; set; }
        /// <summary>
        /// 户型（室）
        /// </summary>
        public int? HRoom { get; set; }
        /// <summary>
        /// 户型（厅）
        /// </summary>
        public int? HOffice { get; set; }
        /// <summary>
        /// 户型（卫）
        /// </summary>
        public int? HWashroom { get; set; }
        /// <summary>
        /// 楼层（层级）
        /// </summary>
        public int? HFloor { get; set; }
        /// <summary>
        /// 楼层（共计）
        /// </summary>
        public int? HFloorTotal { get; set; }
        /// <summary>
        /// 出租面积
        /// </summary>
        public decimal RentalArea { get; set; }
        /// <summary>
        /// 卧室
        /// </summary>
        public string Bedroom { get; set; }
        /// <summary>
        /// 房源朝向
        /// </summary>
        public string HDirection { get; set; }
        /// <summary>
        /// 房屋装修情况
        /// </summary>
        public string HDecoration { get; set; }
        /// <summary>
        /// 房源租金
        /// </summary>
        public decimal HRent { get; set; }
        /// <summary>
        /// 房源坐标（经度）
        /// </summary>
        public decimal XCoordinate { get; set; }
        /// <summary>
        /// 房源坐标（纬度）
        /// </summary>
        public decimal YCoordinate { get; set; }
        /// <summary>
        /// 房源具体地址
        /// </summary>
        public string DetailAddress { get; set; }

        /// <summary>
        /// 房源更新时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }
        /// <summary>
        /// 房源封面图片
        /// </summary>
        public string HouseCover { get; set; }
        #endregion
        #region Field
        ///// <summary>
        ///// 主键自增ID号
        ///// </summary>
        //public int Id { get; set; }
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
        /// <summary>
        /// 房源小区Id
        /// </summary>
        public int HouseVillageId { get; set; }

        ///// <summary>
        ///// 软删除：0表示未删除；1表示已删除
        ///// </summary>
        //public int? IsDel { get; set; }
        ///// <summary>
        ///// 创建时间
        ///// </summary>
        //public DateTime? AddTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        //public DateTime? LastUpdateTime { get; set; }
        #endregion
    }
}
